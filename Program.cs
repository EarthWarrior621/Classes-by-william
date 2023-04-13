using System;

namespace Classes_by_william
{
    class Program
    {
        static void Main(string[] args)
        {
           //
            Greetings greetings = new Greetings();
           
            //
            greetings.Welcome();
           
            //
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
           
            //
            greetings.Hello("William");
        }
    }
}
