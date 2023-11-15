using System;



//IMPLEMENTING STRUCTURE USING INTERFACES :

interface IMyInterface
{
    void MyMethod();
}

struct MyStruct : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("MyStruct's MyMethod implementation");
    }
}



namespace generics
{
    class Program
    {
       
        //GENERICS :
        public class compare
        {
            public bool IsEquals<T>(T a, T b)
            {
                return a.Equals(b);
            }

        }


       



        public class TestGenericsClass<T>
        {
         

            private T variable1;
            public T property { get; set; }
            public TestGenericsClass(T value)
            {
                variable1 = value;
                property = value;
            }
                        
            

            public TestGenericsClass()
            {
                Console.WriteLine("hello genrics ");
            }

            
       
            public T TestFunction(T param1)
            {
                Console.WriteLine("Parameter type:{0},value:{1}", typeof(T).ToString(), param1);
                Console.WriteLine("Return type:{0},value:{1}", typeof(T).ToString(), variable1);
                return variable1;

            }
        }
        public static void Main(string[] args)
        {
           
            //STRUCTURE USING INTERFACE:
            MyStruct myStruct = new MyStruct();
             myStruct.MyMethod();



            //GENERICS AND ITS IMPLEMENTATIONS   :
            compare c1 = new compare();
            Console.WriteLine(c1.IsEquals(1, 1));

            TestGenericsClass<string> t2 = new TestGenericsClass<string>("this is demo of generics");
            TestGenericsClass<long > t3 = new TestGenericsClass<long >(100001019190);
            TestGenericsClass<char> t4 = new TestGenericsClass<char>('f');

            t2.TestFunction("hello");
            t3.TestFunction(4436467);
            t4.TestFunction('f');

        }
    }
}
