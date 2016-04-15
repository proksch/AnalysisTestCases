namespace BasicCases
{
    internal interface F<T>
    {
        void M(T t);
    }

    internal class S<U> : F<U>
    {
        public virtual void M(U u)
        {
        }
    }

    internal class C : S<int>
    {
        public override void M(int u)
        {
            
        }
    }
}