namespace Inlining
{
    internal class InlinedToMultipleSources
    {
        public void EP1()
        {
            var o = new object();
            o.GetHashCode();
            P(o);
        }

        public void EP2()
        {
            var o = new object();
            o.GetType();
            P(o);
        }

        private void P(object o)
        {
            o.ToString();
        }
    }
}