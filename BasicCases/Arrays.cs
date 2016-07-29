using System.Collections.Generic;

namespace BasicCases
{
    internal class Arrays<T1>
    {
        // generic
        private IEnumerable<N>[] _g;
        // regular
        private int[] _i;

        // nested
        private N[] _n;

        // type parameters
        private T1[] _t;

        /* $ */

        internal class N
        {
        }
    }
}