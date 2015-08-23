namespace Inlining
{
    public class SimpleCase
    {
        public void EP1()
        {
            var o = new object();
            o.Equals(null);
            H1(o);
        }

        public void H1(object o)
        {
            o.GetHashCode();
        }
    }
}