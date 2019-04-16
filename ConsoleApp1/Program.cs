using System;

namespace ConsoleApp1
{
   class Program
    {
      
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Podaj swoje imie ");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            greetings(name);
            int age;
            int licznik = 1;
            bool result = int.TryParse(Console.ReadLine(), out age);
            Data(ref age, ref result);

            Console.ReadLine();
        }

        private static void Data(ref int age, ref bool result)
        {
            if (result == false)
            {
                Console.WriteLine("Zle dane , wpisz jeszcze raz");
                do
                {

                    result = int.TryParse(Console.ReadLine(), out age);

                } while (age == 0);

                Console.WriteLine("tera wiek to" + age);
            }
        }

        private static void greetings(string name)
        {
            Console.WriteLine("Witaj  " + name);
            Console.WriteLine("Podaj swoj wiek  ");
        }

    }
}
