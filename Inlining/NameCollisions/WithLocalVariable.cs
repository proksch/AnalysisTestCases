namespace Inlining.NameCollisions
{
    internal class WithLocalVariable
    {
        public void M()
        {
            var o = new object();
            o.ToString();
            N();
            o.GetHashCode()
        }

        private void N()
        {
            var o = new object();
            o.GetType();
        }
    }
}