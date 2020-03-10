using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TirePressureMonitor.Test.Unit
{
    class FakeWarning : IWarning
    {

        public int alarmOnCounter { get; set; }
        public int alarmOffCounter { get; set; }

        public int Outt { get; set; }
        

        public void alarmOff()
        {
            alarmOffCounter++;
        }

        public void alarmOn()
        {
            alarmOnCounter++;
        }


        public void Out()
        {
            Outt++;
        }
    }
}
