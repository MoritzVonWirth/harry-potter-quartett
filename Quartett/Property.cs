using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartett
{
    class Property
    {
        private Int32 value;

        private string unit;

        private bool higherValueWins;

        public Int32 Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
            }
        }

        public bool HigherValueWins
        {
            get
            {
                return higherValueWins;
            }
            set
            {
                higherValueWins = value;
            }
        }
    }
}
