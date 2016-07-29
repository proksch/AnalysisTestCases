using System.Collections.Generic;

namespace BasicCases
{
    internal class Delegates
    {
        // basic case
        public delegate int D0(int p);

        // recursive definition 1
        public delegate D1 D1(D1 p);

        // recursive definition 2
        public delegate IEnumerable<D2> D2(IEnumerable<D2> p);

        public void M(D0 p0, D1 p1, D2 p2)
        {
            /* $ */
        }
    }
}