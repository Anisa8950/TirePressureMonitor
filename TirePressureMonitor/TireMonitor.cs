using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TirePressureMonitor
{
    public class TireMonitor
    {
        private Tire tire_;
        private BlockingCollection<int> sample_;
        private IFilter evenFilter_;
        private EvaluateSample evaluateSample_;
        private int Sample;

        private List<int> SampleList;



        public TireMonitor(Tire Tire, BlockingCollection<int> Sample, IFilter EvenFilter, EvaluateSample EvaluateSample)
        {
            tire_ = Tire;
            sample_ = Sample;
            evenFilter_ = EvenFilter;
            evaluateSample_ = EvaluateSample;
        }


        public void Run()
        {
            while (true)
            {

                Sample = sample_.Take();

                tire_.pressure_ = evenFilter_.Filter(Sample);


                evaluateSample_.Evaluate(tire_.pressure_);
                Thread.Sleep(1000);

                


            }
        }


    }
}
