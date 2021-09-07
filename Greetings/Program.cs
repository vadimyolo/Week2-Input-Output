using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja nime
            //programm tervitab kasutajat nimepidi
            Console.WriteLine("Mis on su nimi?");


            string UserName = Console.ReadLine();

            //Console.WriteLine("Hello, " + UserName);

            //string interpolation

            Console.WriteLine($"Hello, {UserName}");

            Console.Read();

        }
    }
}
