using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirePressureMonitor
{
    public class Warning: IWarning
    {

        public void alarmOn()
        {
            Console.WriteLine("Light is on");
        }

        public void alarmOff()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
