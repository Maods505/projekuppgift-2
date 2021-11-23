using System;
using System.IO;

namespace projekuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("välj ett av följande alternativ");
            Console.WriteLine("1. visa topplistan");
            Console.WriteLine("2. ändra på topplistan");
            Console.WriteLine("3. visa hela topplistan");
            Console.WriteLine("4. söka efter ett låtnamn");
            Console.WriteLine("5. avsluta programmet");

            string användarensval = "";
            användarensval = Console.ReadLine();

            string[] låtar = new string[20];

            for (int i = 0; i < låtar.Length; i++)
            {
                låtar[i] = "tom";
            }
            

            switch (användarensval)
            {
                case "1":
                    Console.WriteLine($"här är alla låtar som finns inskrivna ");
                    for (int i = 0; i < låtar.Length; i++)
                    {
                        Console.WriteLine(låtar[i]);
                    }
                    break;


                case "2":
                    for (int i = 0; i < låtar.Length; i++)
                    {
                        Console.WriteLine($"skriv in låt number {i + 1}");
                        låtar[i] = Console.ReadLine();
                    }
                    break;
            }

            
            

            

        }
    }
}
