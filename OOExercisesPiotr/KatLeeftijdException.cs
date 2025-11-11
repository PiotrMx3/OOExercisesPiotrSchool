using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class KatLeeftijdException : ArgumentException
    {
        private int _value;
        private int _lowValue;
        private int _maxValue;

        public int MaxValue
        {
            get { return this._maxValue; }
        }
        public int LowValue
        {
            get { return this._lowValue; }
        }

        public int Value
        {
            get { return this._value; }
        }

        public KatLeeftijdException(int value, int lowValue, int maxValue) : base("Fout: De opgegeven leeftijd valt buiten het toegestane bereik.")
        {
            this._value = value;
            this._lowValue = lowValue;
            this._maxValue = maxValue;

        }
    }
}
