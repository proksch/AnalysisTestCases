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

        private void H1()
        {
            o.ToString();
            H2();
        }

        private void H2()
        {
            o.Equals(null);
        }

        public void EP2()
        {
            o.GetType();
            H2();
        }
    }
}