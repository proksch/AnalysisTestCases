namespace Inlining.NameCollisions
{
    internal class WithParameter
    {
        public void EP(object o)
        {
            o.ToString();
            H();
            o.GetHashCode();
        }

        private void H()
        {
            var o = new object();
            o.GetType();
        }
    }
}