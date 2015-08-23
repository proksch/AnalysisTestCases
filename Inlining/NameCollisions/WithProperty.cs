namespace Inlining.NameCollisions
{
    internal class WithProperty
    {
        private object o { get; set; }

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