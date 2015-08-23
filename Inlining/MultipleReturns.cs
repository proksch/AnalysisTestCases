namespace Inlining
{
    internal class MultipleReturns
    {
        public void M()
        {
            var o = new object();
            N(o);
            o.GetHashCode();
        }

        private void N(object o)
        {
            if (o == null)
            {
                o.GetType();
                return;
            }
            o.ToString();
        }
    }
}