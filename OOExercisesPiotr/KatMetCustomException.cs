using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class KatMetCustomException
    {
        private int _age;

        public int Age
        {
            get { return this._age; }
            private set
            {
                if (value > 25) throw new KatLeeftijdException(value, 0, 25);
                this._age = value;
            }
        }

        public KatMetCustomException(int age)
        {
            Age = age;
        }
    }
}
