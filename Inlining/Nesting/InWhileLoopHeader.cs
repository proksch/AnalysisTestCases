namespace Inlining.Nesting
{
    internal class InWhileLoopHeader
    {
        public void M()
        {
            var o = new object();
            while (N())
            {
                o.GetHashCode();
            }
        }

        private bool N()
        {
            var o = new object();
            return o != null;
        }
    }
}