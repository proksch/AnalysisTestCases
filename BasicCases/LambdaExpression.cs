using System;

namespace BasicCases
{
    internal class LambdaExpression
    {
        public void Regular()
        {
            Func<int, int> f = i => { return i + 1; };
        }

        public void ExpressionStyle()
        {
            Func<int, int> f = i => i + 1;
        }

        public void AnonymousMethod()
        {
            Func<int, int> f = delegate { return 1; };
        }

        public void LambdaInvocation_Implicit(Action<int> f)
        {
            f(1);
        }

        public void LambdaInvocation_Explicit(Action<int> f)
        {
            f.Invoke(1);
        }

        private Action<int> _f;
        public void LambdaInvocation_Field()
        {
            _f(1);
            
        }

        public void LambdaInLambda()
        {
            Func<int, int> f = i =>
            {
                Func<int, int> f2 = i2 => i2 + 1;
                return f2(i);
            };
        }

        public void MethodInLambda()
        {
            Func<int, int> f = i => { return M(); };
        }

        public int M()
        {
            return 1;
        }

        public void Assignment()
        {
            Func<int> f = M;
        }

        public void LocalVariable()
        {
            Action<int> a = null;
            a(1);
        }
    }
}