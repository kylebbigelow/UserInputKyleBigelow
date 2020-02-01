using System;

namespace UserInputKyleBigelow
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Console.WriteLine("Hi, this is Kyle Bigelow! " +
                 "Tell me how you are feeling today, then hit Enter.");

            response = Console.ReadLine();

            Console.WriteLine("You typed: "+ response);
            
        }
    }
}
