namespace Inlining
{
    internal class PartiallyInlined
    {
        private object o;

        public void EP1()
        {
            o.GetHashCode();
            H1();
        }

        public void EP2()
        {
            o.GetType();
            H2();
        }

        private void H1()
        {
            o.ToString();
        }

        private void H2()
        {
            o.Equals(null);
        }
    }
}