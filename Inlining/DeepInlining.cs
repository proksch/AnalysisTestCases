namespace Inlining
{
    internal class DeepInlining
    {
        public void M()
        {
            var o = new object();
            o.GetHashCode();
            N(o);
        }

        private void N(object o)
        {
            o.GetType();
            O(o);
        }

        private void O(object o)
        {
            o.ToString();
        }
    }
}