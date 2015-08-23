namespace Inlining.NameCollisions
{
    internal class WithProperty
    {
        private object o { get; set; }

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