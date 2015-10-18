namespace BasicCases.Unchecked
{
    internal class Expression
    {
        public int Calculation()
        {
            const int i = 1;
            return unchecked(i + 1);
        }

        public int UnnecessaryGuardIsRemoved()
        {
            return unchecked(1);
        }
    }
}