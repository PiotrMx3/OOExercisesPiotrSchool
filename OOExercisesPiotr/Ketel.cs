using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal abstract class Ketel
    {
        private int _volmue;
        private int _temperature = 20;

        public Ketel(int volume)
        {
            Volume = volume;
        }
        public int Temperature
        {
            get { return _temperature; }
           private set { _temperature = value; }
        }


        public int Volume
        {
            get { return _volmue; }
            private set { _volmue = value; }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }

    }
}
