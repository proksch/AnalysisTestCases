namespace BasicCases
{
    internal class ExtensionMethods
    {
        public void M()
        {
            1.ExtM();
            this.ExtM();
            "".ExtM();
            GetHashCode().ExtM();
        }
    }

    internal static class H
    {
        public static void ExtM(this object em)
        {
        }
    }
}