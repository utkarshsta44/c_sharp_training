using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount");
            var amount = Console.ReadLine();
            double changedAmount;
            if (double.TryParse(amount,out changedAmount))
            {
            }
            else
            {
                Console.WriteLine("please enter the amount in correct format");
            }

            Console.WriteLine("Please enter the rate of interest per  annum ");
            var interest = Console.ReadLine();
            double changedInterest;
            if (double.TryParse(interest, out changedInterest))
            {
            }
            else
            {
                Console.WriteLine("please enter the interest in correct format");
            }
            Console.WriteLine("Please enter the  time in years ");
            var time = Console.ReadLine();
            double changedTime;
            if (double.TryParse(time, out changedTime))
            {
            }
            else
            {
                Console.WriteLine("please enter the time in correct format");
            }
            var SI = changedAmount * changedInterest * changedTime * 0.01;


            Console.WriteLine("The simple interest for the above provided  values will be " + changedAmount * changedInterest * changedTime * 0.01);
            Console.WriteLine("TOTAL AMOUNT THAT IS TO BE PAID IS " + (SI + changedAmount));

            Console.ReadKey();

        }
       string Myname(string name)
        {
            return "hello," + name;
        }
    }
}
