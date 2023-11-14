using System;

namespace advanced_Csharp
{

    public struct book
    {
        private string _title ;
        private string _author;
        private string _subject;
        private  int bookid;



        public book(string title, string author, string subject, int id)
        {
            _title = title;
            _author = author;
            _subject = subject;
            bookid = id;
        }
        /*public book(string auth,string sub)
        {
            _author = "akshat kumar";
            _subject = "c++ for beginners";
        }
        */

        public void PrintBook()
        {
            Console.WriteLine($" Book_id :{bookid} \n Title:{_title}\n" +
                $"Author : {_author}");
        }



    }


    class Program
    {


        public enum LogTypes
        {
            Error = 66,
            Warning = 800,
            Fatal = 700,
            Information = 900
        }
        static void Main(string[] args)
        {
            int myVar1 = (int)LogTypes.Error;
            LogTypes myVar10 = LogTypes.Error;

            int myVar2 = (int)LogTypes.Warning;
            int myVar3 = (int)LogTypes.Fatal;
            int myVar4 = (int)LogTypes.Information;
            Console.WriteLine((myVar10));
            Console.WriteLine(myVar1);
            Console.WriteLine(myVar2);
            Console.WriteLine(myVar3);
            Console.WriteLine(myVar4);

            Program p1 = new Program();
            p1.ErrorLogging("this is the error message", LogTypes.Error);



            book book1 = new book("Encyclopedia ", "utkarsh", "science", 100001);
            book1.PrintBook();



        }

        public void ErrorLogging(string message, LogTypes logtype)
        {
            switch (logtype)
            {
                case LogTypes.Error:
                    Console.WriteLine(message);
                    break;
                case LogTypes.Fatal:
                    Console.WriteLine(message);
                    break;
                case LogTypes.Warning:
                    Console.WriteLine(message);
                    break;

                case LogTypes.Information:
                    Console.WriteLine(message);
                    break;
            }
        }
    }
}

