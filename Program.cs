using System;

namespace ProvaScrittaPMO_25_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            var notifier = Notifier.GetInstance();
            notifier.wrongInput += Notifier_wrongInput;

            while (true)
            {
                Console.WriteLine("Please type a number:");

                var input = Console.ReadLine();
                var intInput = int.Parse(input);
                if (intInput == 3)
                    Notifier.GetInstance().FireEvent();
                    Console.WriteLine("Input is 3!");
            }
        }

        private static void Notifier_wrongInput(object sender, EventArgs e)
        {
            Console.WriteLine("Wrong input");
        }
    }
}
