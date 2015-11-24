namespace BasicCases
{
    internal class ResolvingFullyQualifiedTypes
    {
        public void FullyQualifiedFieldAccess_BuiltInType()
        {
            var s = string.Empty;
            var f = float.MinValue;
            var d = double.MinValue;
            var i = int.MinValue;
            var b = byte.MinValue;
            var b2 = bool.FalseString;
        }

        public void FullyQualifiedFieldAccess()
        {
            var x = SomeNamespace.SomeClass.F;
        }

        public void FullyQualifiedPropertyAccess()
        {
            var x = SomeNamespace.SomeClass.P;
        }

        public void FullyQualifiedMethodInvocation()
        {
            SomeNamespace.SomeClass.M();
        }
    }
}

namespace SomeNamespace
{
    internal class SomeClass
    {
        public static string F = "x";

        public static string P
        {
            get { return string.Empty; }
        }

        public static void M()
        {
        }
    }
}