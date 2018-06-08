using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace GrblPanel
{
    public class Elapsed
    {
        public string ElapsedMillis

        {
            get;
        }

        public Elapsed(object target)
        {
            // this._stopwatch = new Stopwatch();
            //  this._timer = new System.Threading.Timer(new TimerCallback(this._timerCB), RuntimeHelpers.GetObjectValue(target), 0, 1000);
        }

        public void BeginTimer()
        {
            this._stopwatch.Reset();
            this._stopwatch.Start();
        }

        public void StopTimer()
        {
            this._stopwatch.Stop();
        }

        public void ResumeTimer()
        {
            this._stopwatch.Start();
        }

        public void ResetTimer()
        {
            this._stopwatch.Reset();
        }

        private void _timerCB(object state)
        {
            // this._span.ToString("hh\\:mm\\:ss")
        }
    }
}