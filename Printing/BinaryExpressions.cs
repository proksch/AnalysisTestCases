namespace Printing
{
    internal class BinaryExpressions
    {
        private bool B1 { get; set; }
        private bool B2 { get; set; }

        private int I1 { get; set; }
        private int I2 { get; set; }

        public void Logial()
        {
            bool b;
            b = I1 < I2;
            b = I1 <= I2;
            b = I1 == I2;
            b = I1 >= I2;
            b = I1 > I2;
            b = I1 != I2;
            b = B1 && B2;
            b = B1 || B2;
        }

        public void Arithmetic()
        {
            int i;
            i = I1 + I2;
            i = I1 - I2;
            i = I1*I2;
            i = I1/I2;
            i = I1%I2;
        }

        public void Bitwise()
        {
            int i;
            i = I1 & I2;
            i = I1 | I2;
            i = I1 ^ I2;
            i = I1 << I2;
            i = I1 >> I2;
        }
    }
}