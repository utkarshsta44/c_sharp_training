using System;
using System.Text;

namespace string_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            String s1 = "welcome";
            Console.WriteLine(s1);


            //CLONE :
            string s2 = (string)s1.Clone();
            Console.WriteLine(s2);


            //COMPARE:
            Console.WriteLine(string.Compare(s1, s2));

            //CONACT:
            Console.WriteLine(string.Concat(s1, s2));

            //CONTAIN:
            Console.WriteLine(s1.Contains(s2));

            //HASHCODE:

            Console.WriteLine(s1.GetHashCode());

         //LOWER CASE:

          Console.WriteLine(s1.ToLower());


            //UPPER CASE:
            Console.WriteLine(s1.ToUpper());

            //LENGTH:

            Console.WriteLine(s1.Length);


            //REPLACE:
            Console.WriteLine(s1.Replace('e', 'i'));

            //SPLIT:
            string[] split = s1.Split(new char[] { 'e' });


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);
 
 
         // CONVERT TO CHARACTER ARRAY:
            Console.WriteLine(s1.ToCharArray());




            //USING STRING BUILDER CLASS:

            StringBuilder sb = new StringBuilder();
            StringBuilder sb1= new StringBuilder("hello everyone my name is utkarsh srivastava");
            Console.WriteLine(sb1);

            // format string
            string name = "abhay";
            string sb3 = String.Format("Hello {0}",name );

            Console.WriteLine(sb3);



            int a = 10;
            float b = a;
            double c = b;
            decimal d = (decimal)b;

            //Explicit Conversion

            //--double to int
            double age = 22.2;
            int correctAge = Convert.ToInt32(age);
            Console.WriteLine(correctAge);

            //--float to int
            float salary = 1232.32f;
            int correctSalary = Convert.ToInt32(salary);

            //--string to int with TryParse
            string weight = "23";
            int correctWeight;
            if (int.TryParse(weight, out correctWeight))
            {
                correctWeight = Convert.ToInt32(weight);
                Console.WriteLine(correctWeight);
            }

            //--string to float with Parse
            float floatWeight = float.Parse(weight);
            Console.WriteLine(floatWeight);

            //--int to string
            int height = 8888;
            string correctedHeight = height.ToString();
            Console.WriteLine(correctedHeight);

        }


    }
}
