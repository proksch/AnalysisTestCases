using System;

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

        public void FullyQualifiedEventAccess()
        {
            SomeNamespace.SomeClass.E += () => { };
        }

        public void FullyQualifiedFieldAccess()
        {
            var x = SomeNamespace.SomeClass.F;
        }

        public void RegularFieldAccess()
        {
           var x = new R().F.F;
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

    internal class R
    {
        public R F;
    }
}

namespace SomeNamespace
{
    internal class SomeClass
    {
        public static event Action E;

        public static int F = 1;

        public static int P { get; set; }

        public static void M()
        {
        }
    }
}