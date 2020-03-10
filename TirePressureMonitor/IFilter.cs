using System.Collections.Generic;

namespace TirePressureMonitor
{
    public interface IFilter
    {

        int Filter(int Sample);
    }
}