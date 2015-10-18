namespace BasicCases.Casting
{
    internal class Cast
    {
        public void NumberCast()
        {
            var i = (int) 0.0;
        }

        public void TypeCast_Variable()
        {
            object o = "xzy";
            var s = (string) o;
        }

        public void TypeCast_Method()
        {
            var f = (float) GetHashCode();
        }
        
        public void TypeCheck()
        {
            var x = 1 is int;
        }
    }
}