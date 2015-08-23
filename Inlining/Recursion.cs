namespace Inlining
{
    internal class Recursion
    {
        public void M(int i = 10)
        {
            var o = new object();
            if (i > 0)
            {
                M(i - 1);
            }
            o.GetHashCode();
        }
    }
}