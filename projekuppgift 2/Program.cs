using System;
using System.IO;

namespace projekuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] låtar = new string[20];

            for (int i = 0; i < låtar.Length; i++)
            {
                låtar[i] = "tom";
            }

            string menyval = "0";
            while (menyval != "5")
            {

                Console.WriteLine("välj ett av följande alternativ");
                Console.WriteLine("1. visa topplistan");
                Console.WriteLine("2. ändra på topplistan");
                Console.WriteLine("3. Ändra på en Låt i topplistan");
                Console.WriteLine("4. söka efter ett låtnamn");
                Console.WriteLine("5. avsluta programmet");

                string användarensval = "";
                användarensval = Console.ReadLine();

                

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



                    case "3":
                        {
                            Console.WriteLine("Ändra en låt i din lista. Välj ett nummer i din topplista.");
                            int LåtVal = int.Parse(Console.ReadLine());
                            Console.WriteLine("Vad vill du ändra låten till?");
                            låtar[LåtVal - 1] = Console.ReadLine();
                        }
                        break;

                    case "4":


                        break;

                }
            }






        }
    }
}
