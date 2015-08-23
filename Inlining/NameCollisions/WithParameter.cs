namespace Inlining.NameCollisions
{
    internal class WithParameter
    {
        public void M(object o)
        {
            o.ToString();
            N();
            o.GetHashCode();
        }

        private void N()
        {
            var o = new object();
            o.GetType();
        }
    }
}