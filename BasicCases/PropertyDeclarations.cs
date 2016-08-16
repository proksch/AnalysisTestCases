namespace BasicCases
{
    internal class PropertyDeclarations
    {
        public int P1 { get; set; }

        public int P2
        {
            get { return P1; }
        }

        public int P3
        {
            get { return 1; }
            set { var i = value; }
        }
        
        /* $ */
    }
}