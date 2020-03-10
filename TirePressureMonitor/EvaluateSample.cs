using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirePressureMonitor
{
    public class EvaluateSample
    {

        private IWarning warning_;

        public EvaluateSample(IWarning Warning)
        {
            warning_ = Warning;
        }


        public void Evaluate(int TirePressure)
        {

            if (TirePressure < 30 && TirePressure >= 0)
            {
                warning_.alarmOn();
            }
            else if (TirePressure >= 30 && TirePressure <= 40)
            {
                warning_.alarmOff();
            }
            else
            {
                Console.WriteLine("Tire pressure is out of range, somethings wrong");
                //throw new ArgumentException("Tire pressure is out of range, somethings wrong");
            }
        }
    }
}
