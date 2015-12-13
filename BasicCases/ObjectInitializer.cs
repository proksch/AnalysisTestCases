using System.Collections.Generic;

namespace BasicCases
{
    internal class ObjectInitializer
    {
        public void InAssign_RegularConstructor()
        {
            var t = new T();
        }

        public void InAssign_ObjectInitializer_1a()
        {
            object t;
            t = new T
            {
                P = 1
            };
        }

        public void InAssign_ObjectInitializer_1b()
        {
            T t;
            t = new T
            {
                P = 1
            };
        }

        public void InAssign_ObjectInitializer_2a()
        {
            object t = new T
            {
                P = 1
            };
        }

        public void InAssign_ObjectInitializer_2b()
        {
            T t = new T
            {
                P = 1
            };
        }

        public void InAssign_ObjectInitializer_2c()
        {
            var t = new T
            {
                P = 1
            };
        }

        public void InAssign_CollectionInitializer()
        {
            var t = new HashSet<int> {-1, 0, 1};
        }

        public void InAssign_NestedInitializers()
        {
            var t = new T
            {
                P = new T
                {
                    P = 2
                }
            };
        }


        public void InAssign_Complex()
        {
            var t = new T
            {
                P = new T
                {
                    P = 1
                },
                CP = {2}
            };
        }

        public void Nested_RegularConstructor()
        {
            Equals(new T());
        }

        public void Nested_ObjectInitializer()
        {
            Equals(new T
            {
                P = 1
            });
        }

        public void Nested_CollectionInitializer()
        {
            Equals(new List<int> {-1, 0, 1});
        }

        public void Nested_NestedInitializers()
        {
            Equals(new T
            {
                P = new T
                {
                    P = 2
                }
            });
        }

        public void Nested_Complex()
        {
            Equals(new T
            {
                P = new T
                {
                    P = 1
                },
                CP = {2}
            });
        }
    }

    internal class T
    {
        public object P { get; set; }
        public List<object> CP { get; set; }
    }
}