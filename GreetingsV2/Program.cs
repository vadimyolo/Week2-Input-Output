using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutajat, kasutades neid andmeid

            Console.WriteLine("Mis on su eesnimi?");

            string FirstName = Console.ReadLine();

            Console.WriteLine("Mis on su perekonnanimi?");
            
            string Lastname = Console.ReadLine();

            Console.WriteLine($"Hello, {FirstName} {Lastname}");
            Console.Read(); 


          
        }
    }
}
