namespace Printing
{
    internal class UnaryExpressions
    {
        private bool B1 { get; set; }
        private bool B2 { get; set; }

        private int I1 { get; set; }
        private int I2 { get; set; }

        public void Logical()
        {
            var b = !B1;
        }

        public void Arithmetic()
        {
            int i;
            i = ++I1;
            i = I1++;
            i = --I1;
            i = I1--;
            i = -I1;
            i = +I1;
        }

        public void Bitwise()
        {
            var b = ~I1;
        }
    }
}