using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Interface
{
    internal interface Ialgorithm
    {
         Task Sort(int[] array);
    }
}
