using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid
{
    public class Timer
    {
        public void Start()
        {
            tmStart = DateTime.Now;
        }

        public void End()
        {
            tmEnd = DateTime.Now;
        }

        public string Spend()
        {
            return
                $"start:{tmStart.ToString("HH:mm:ss.fff")}, " +
                $"end:{tmEnd.ToString("HH:mm:ss.fff")}, " +
                $"spend:{(tmEnd - tmStart).TotalMilliseconds}(ms)";
        }

        private DateTime tmStart = DateTime.Now;
        private DateTime tmEnd = DateTime.Now;
    }
}
