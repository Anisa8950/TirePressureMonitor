using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirePressureMonitor
{
    public class EvenFilter : IFilter
    {
        private int currentSample;
        private int sum;
        private Queue<int> gemListe = new Queue<int>();
        private List<int> normalListe;


        public int Filter(int Sample)
        {

            gemListe.Enqueue(Sample);

            if (gemListe.Count > 3)
            {
                normalListe = gemListe.ToList();

                for (int i = 0; i < normalListe.Count; i++)
                {
                    sum += normalListe[i];
                }

                currentSample = sum / 3;
                sum = 0;
                normalListe.Clear();
                gemListe.Dequeue();
            }
            else
            {
                currentSample = 30;
            }


            return currentSample;

        }
    }
}
