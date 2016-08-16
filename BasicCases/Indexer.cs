namespace BasicCases
{
    public class IndexedNumber
    {
        public int[] Nums = new int[100];
        
        public int this[int p]
        {
            get { return Nums[p]; }
            set { Nums[p] = value; }
        }
        
        /* $ */
    }

    internal class Client
    {
        public void M()
        {
            var i = 1 + 2 + 3;
            var x = 1%2;
            var x2 = 1*2;
            var x3 = 1/2;
            
            var idx = new IndexedNumber();
            idx[1] = 123;

            var idx2 = new IndexedNumber[123]; // array of indexedNumber
            var i = 1 + 2 + 3;
            
            {
                var i = 2;
            }
            
            var b = (true ^ true) || false;

            var arr = new int[1,2,3];
            var arr2 = new[,] {{1,2}, {2,3}};
            var arr3 = new[2][] {{1},{1,2}};
        }
    }
}