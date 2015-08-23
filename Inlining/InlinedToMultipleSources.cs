namespace Inlining
{
    internal class InlinedToMultipleSources
    {
        public void EP1()
        {
            var o = new object();
            o.GetHashCode();
            H(o);
        }

        public void EP2()
        {
            var o = new object();
            o.GetType();
            H(o);
        }

        private void H(object o)
        {
            o.ToString();
        }
    }
}