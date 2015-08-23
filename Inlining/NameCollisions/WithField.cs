namespace Inlining.NameCollisions
{
    internal class WithField
    {
        private object o;

        public void EP()
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