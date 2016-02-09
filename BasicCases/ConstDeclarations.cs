namespace BasicCases
{
    internal class ConstDeclarations
    {
        private const int ConstField = 1;

        private void M()
        {
            const int constVar = 2;
            var i = 3;
        }
    }
}