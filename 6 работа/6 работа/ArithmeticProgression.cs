using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_работа
{
   public class ArithmeticProgression : IIndexableSeries
    {
        public double this[int index] => _start + (index- 1)*_shag;
        private double _start;
        private int _shag;
        private double _current;

     public ArithmeticProgression(double start, int shag)
        {
            _start = start;
            _shag = shag;
            _current = start;
        }

        public double GetCurrent()
        {
            return _current;
        }

        public bool MoveNext()
        {
            _current = _current + _shag;
            return true;
        }

        public void Reset()
        {
            _current = _start;
        }
    }
}
