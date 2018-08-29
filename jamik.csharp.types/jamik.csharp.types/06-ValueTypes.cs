using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jamik.csharp.types
{
    public struct Cow4
    {
        public int mooCount;
        int numStomachs;
    }

    public struct Fraction
    {
        int numerator;
        int denominator;
        private int v1;
        private int v2;

        public Fraction(int v1, int v2) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
