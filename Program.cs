using System;

namespace Multiple_Greetings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many greetings you want?");
            int greetings = Int32.Parse(Console.ReadLine());

            for (int stop=0; greetings>stop; greetings--)
            {
                Console.WriteLine("Hola");
            }

            
        }
    }
}
