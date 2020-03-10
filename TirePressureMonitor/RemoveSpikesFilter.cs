using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirePressureMonitor
{
    public class RemoveSpikesFilter : IFilter
    {

        private int currentSample;
        private List<int> sampleList = new List<int>();
        public int Filter(int Sample)
        {

            sampleList.Add(Sample);

            if (sampleList.Count == 2)
            {
                if (sampleList[1] > sampleList[0] + 5)
                {
                    currentSample = sampleList[0];
                }

                else
                {
                    currentSample = sampleList[1];
                }

                sampleList.Clear();
            }
            else
            {
                currentSample = Sample;
            }

            return currentSample;
        }
    }
}
