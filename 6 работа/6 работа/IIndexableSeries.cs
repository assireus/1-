using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_работа
{
  interface IIndexableSeries : IIndexable, ISeries
   {
        double this[int index] { get; }
        double GetCurrent();
        bool MoveNext();
        void Reset();
       
   }
}
