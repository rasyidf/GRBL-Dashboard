using GrblPanel.My.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GrblPanel
{
    public class GrblIF
    {
        public enum ConnectionType
        {
            IP,
            Serial,
            None
        }

        private delegate void _dataReceived();

        public delegate void grblDataReceived(string data);

        public delegate void SerialDataEventEventHandler(string data);

        private TcpClient _client;
        private int _portNum;
        private ConnectionType _type;
        private readonly List<grblDataReceived> _recvDelegates;
        private readonly byte[] readBuffer;
        private StringBuilder sb;

        public event SerialDataEventEventHandler SerialDataEvent;

        private SerialPort _port { get; set; }

        public string Comport { get; set; }

        public int Baudrate { get; set; }

        public IPAddress IpAddress { get; set; }
        public bool Connected { get; private set; }

        public int PortNum
        {
            get => this._portNum;
            set => this._portNum = (value > 65535 || value < 0) ? 2000 : value;
        }

        public GrblIF()
        {
            Comport = "COM1";
            Baudrate = 115200;
            Connected = false;

            _client = new TcpClient();
            _portNum = 0;

            readBuffer = new byte[257];
            _port = new SerialPort
            {
                ReceivedBytesThreshold = 2
            };
            _recvDelegates = new List<grblDataReceived>();
            SerialDataEvent += new SerialDataEventEventHandler(RaiseSerialDataEvent);
        }

        public bool Connect(ConnectionType typeIn)
        {
            this._type = typeIn;
            switch (_type)
            {
                case ConnectionType.IP:
                    if (this._client.Connected)
                    {
                        return false;
                    }
                    else
                    {
                        try
                        {
                            this._client = new TcpClient();
                            this._client.Connect(this.IpAddress, this._portNum);
                            new _dataReceived(this._client_DataReceived).BeginInvoke(null, null);
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                        this.Connected = true;
                        return true;
                    }

                case ConnectionType.Serial:
                    if (this._port.IsOpen)
                    {
                        return false;
                    }
                    else
                    {
                        this._port.PortName = this.Comport;
                        this._port.BaudRate = this.Baudrate;
                        this._port.ReadTimeout = 5000;
                        try
                        {
                            this._port.Open();
                        }
                        catch (IOException)
                        {
                            return false;
                        }
                        catch (UnauthorizedAccessException)
                        {
                            return false;
                        }
                        this._port.DtrEnable = true;
                        this.Connected = true;
                        return true;
                    }

                case ConnectionType.None:
                default:
                    return false;
            }
        }

        public void Disconnect()
        {
            GrblIF.ConnectionType type = this._type;
            switch (type)
            {
                case ConnectionType.IP:
                    this._client.Close();
                    break;

                case ConnectionType.Serial:
                    try
                    {
                        if (this._port.IsOpen)
                        {
                            this._port.BaseStream.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Resources.GrblIF_Disconnect_ErrorOnCloseOfGrblPort);
                        throw;
                    }
                    break;

                default:
                    break;
            }

            this.Connected = false;
            this._type = GrblIF.ConnectionType.None;
        }

        public string[] Rescan()
        {
            return SerialPort.GetPortNames();
        }

        public string[] GetComports()
        {
            return SerialPort.GetPortNames();
        }

        public bool AddRcvDelegate(grblDataReceived param)
        {
            this._recvDelegates.Add(param);
            return true;
        }

        public bool DeleteRcvDelegate(grblDataReceived param)
        {
            this._recvDelegates.Remove(param);
            return true;
        }

        private void _client_DataReceived()
        {
            NetworkStream _stream = _client.GetStream();
            StreamReader _reader = new StreamReader(_stream);
            while (this.Connected)
            {
                string data = _reader.ReadLine();
                if (data.Length != 0)
                {
                    using (var enumerator = this._recvDelegates.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            enumerator.Current(data);
                        }
                    }
                }
            }
        }

        private void RaiseSerialDataEvent(string data)
        {
            sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                char ch = data[i];
                if (String.Compare(ch.ToString(), "\0", false) != 0)
                {
                    if (String.Compare(ch.ToString(), "\n", false) == 0)
                    {
                        sb.Append(ch);
                        using (var enumerator = _recvDelegates.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                enumerator.Current(this.sb.ToString());
                            }
                        }
                        this.sb.Clear();
                    }
                    else
                    {
                        this.sb.Append(ch);
                    }
                }
            }
        }

        public bool SendData(string data)
        {
            switch (this._type)
            {
                case ConnectionType.IP:
                    return SendDataViaIP(data);

                case ConnectionType.Serial:
                    return SendDataViaSerial(data);

                case ConnectionType.None:
                default:
                    break;
            }
            return false;
        }

        private bool SendDataViaSerial(string data)
        {
            if (!Connected && !_port.IsOpen)
            {
                return false;
            }
            if (data.Length == 1)
            {
                byte[] c = Encoding.GetEncoding(1252).GetBytes(data);
                try
                {
                    this._port.BaseStream.Write(c, 0, c.Length);
                }
                catch (Exception e)
                {
                    this.Connected = false;
                    MessageBox.Show(Resources.GrblIF_sendData_FatalErrorOnWriteToGrbl + ", " + e.Message);
                }
            }
            byte[] c2 = Encoding.ASCII.GetBytes(data + "\n");
            try
            {
                this._port.BaseStream.Write(c2, 0, c2.Length);
            }
            catch (Exception e)
            {
                this.Connected = false;
                MessageBox.Show(Resources.GrblIF_sendData_FatalErrorOnWriteToGrbl + ", " + e.Message);
            }

            return true;
        }

        private bool SendDataViaIP(string data)
        {
            if (this.Connected && this._client.Connected)
            {
                if (data.Length == 1)
                {
                    byte[] c3 = Encoding.GetEncoding(1252).GetBytes(data);
                    try
                    {
                        this._client.GetStream().Write(c3, 0, c3.Length);
                    }
                    catch (Exception)
                    {
                        this.Connected = false;
                        MessageBox.Show(Resources.GrblIF_sendData_FatalErrorOnWriteToGrbl);
                        throw;
                    }
                }
                byte[] c4 = Encoding.ASCII.GetBytes(data + "\n");
                try
                {
                    this._client.GetStream().Write(c4, 0, c4.Length);
                }
                catch (Exception)
                {
                    this.Connected = false;
                }
                return true;
            }
            return false;
        }
    }
}