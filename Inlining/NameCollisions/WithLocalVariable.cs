namespace Inlining.NameCollisions
{
    internal class WithLocalVariable
    {
        public void EP()
        {
            var o = new object();
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