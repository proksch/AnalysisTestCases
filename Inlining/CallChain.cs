namespace Inlining
{
    internal class CallChain
    {
        private object o;

        public void M()
        {
            o.GetHashCode();
            C1().C2().ToString();
        }

        private CallChain C1()
        {
            o.GetType();
            return this;
        }

        private CallChain C2()
        {
            o.ToString();
            return this;
        }
    }
}