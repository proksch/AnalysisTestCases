namespace BasicCases
{
    public interface I
    {
    }

    public class Super
    {
    }

    public delegate int D();

    public class xC : Super, I
    {
        public delegate int D();

        public int _f;
        
        public int P { get; set; }

        public event D E;

        public void M()
        {
        }

        /* $ */
    }

    public interface xI : I
    {
        int P { get; set; }
        event D E;

        void M();

        /* $ */
    }

    public enum E : long // extension is ignored by R#
    {
        X,
        Y

        /* $ */
    }

    public struct S : I // extension is ignored by R#
    {
        public delegate int D();

        public int _f;

        public int P { get; set; }

        public event D E;

        public void M()
        {
        }

        /* $ */
    }
}