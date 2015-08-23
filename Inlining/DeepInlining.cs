namespace Inlining
{
    internal class DeepInlining
    {
        public void EP()
        {
            var o = new object();
            o.GetHashCode();
            H1(o);
        }

        private void H1(object o)
        {
            o.GetType();
            H2(o);
        }

        private void H2(object o)
        {
            o.ToString();
        }
    }
}