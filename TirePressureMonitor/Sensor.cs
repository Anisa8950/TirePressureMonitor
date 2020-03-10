using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TirePressureMonitor
{
    class Sensor
    {


        private BlockingCollection<int> sample_;

        Random random = new Random();
        public Tire tire_;


        public Sensor(Tire Tire, BlockingCollection<int> Sample)
        {
            tire_ = Tire;
            sample_ = Sample;
        }


        public void Run()
        {
            while (true)
            {
                sensePressue();
                Thread.Sleep(1000);
            }
        }





        public void sensePressue()
        {
            int ss = random.Next(0, 101);

            if (ss < 98)
            {
                sample_.Add(random.Next(20, 41));
            }

            else if(ss >= 99)
            {
                sample_.Add(random.Next(20, 41) + 10);
            }


        }
    }
}
