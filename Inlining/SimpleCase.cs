namespace Inlining
{
    public class SimpleCase
    {
        public void M1()
        {
            var o = new object();
            o.Equals(null);
            M2(o);
        }

        public void M2(object o)
        {
            o.GetHashCode();
        }
    }
}