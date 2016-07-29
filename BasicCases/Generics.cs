namespace BasicCases
{
    internal class Generics<T2> : I<T2>
    {
        public void M(T2 obj)
        {
        }

        public void M<T3>(T2 t2, T3 t3)
        {
            M(t2);
            /* $ */
        }
    }

    internal interface I<in T1>
    {
        void M(T1 obj);
    }
}