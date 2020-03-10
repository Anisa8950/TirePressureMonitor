using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TirePressureMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> Sample = new BlockingCollection<int>();



            Tire tire1 = new Tire();
            IWarning warning = new Warning();
            //IFilter evenFilter = new EvenFilter();
            IFilter spikesFilter = new RemoveSpikesFilter();

            EvaluateSample evaluateSample1 = new EvaluateSample(warning);


            Sensor sensor1 = new Sensor(tire1, Sample);
            TireMonitor tireMonitor1 = new TireMonitor(tire1, Sample, spikesFilter, evaluateSample1);



            Thread thread1 = new Thread(tireMonitor1.Run);
            Thread thread2 = new Thread(sensor1.Run);


            thread1.Start();
            thread2.Start();

            Console.ReadKey();


        }
    }

}

