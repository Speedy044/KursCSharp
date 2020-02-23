using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueType()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia.
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisuje komunikat zależny od wieku.
        /// </summary>
        private static void Age()
        {
            Console.Write("Wprowadź swój wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jesteś pełnoletni, może browarka?");
            }
            else if (result == false)
            {
                Console.WriteLine("Wpisz poprawny wiek");
            }
            else
            {
                Console.WriteLine("Napij się mleka, gówniarzu!");
            }
        }
        /// <summary>
        /// Wypisuje powitanie użytkownika.
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wprowadź swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("No siemanko, " + name);
        }
    }
}
