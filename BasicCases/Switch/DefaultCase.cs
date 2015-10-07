namespace BasicCases.Switch
{
    internal class DefaultCase
    {
        public enum E
        {
            A,
            B,
            C
        }

        public void EmptySwitch()
        {
            switch ()
            {
            }
        }

        public void OnEnum(E e)
        {
            switch (e)
            {
                case E.A:
                    break;
            }
        }

        public void OnInt(int i)
        {
            switch (i)
            {
                case 2:
                    break;
            }
        }

        public void MultipleSections(int i)
        {
            switch (i)
            {
                case 1:
                    Equals(null);
                    break;
                case 2:
                    GetHashCode();
                    break;
            }
        }

        public void WithDefaultSection(int i)
        {
            switch (i)
            {
                case 1:
                    Equals(null);
                    break;
                default:
                    GetHashCode();
                    break;
            }
        }
    }
}