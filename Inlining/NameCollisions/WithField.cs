namespace Inlining.NameCollisions
{
    internal class WithField
    {
        private object o;

        public void M()
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