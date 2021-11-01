using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai 'A', konsool kuvab "Suurepärane!";
            //kui kasutaja sai 'B', konsool kuvab "Väga hea!";
            //kui kasutaja sai 'C', konsool kuvab "Hea!";
            //kui kasutaja sai 'D', konsool kuvab "Rahuldav!";
            //kui kasutaja sai 'E', konsool kuvab "Kasin!";
            //kui kasutaja sai 'F', konsool kuvab "Puudulik!";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "Vale väärtus!"

            Console.WriteLine("Sisetage oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine("Vale väärtus!");
                    break;
            
            }
            Console.WriteLine("Kena päeva!");
            Console.Read();

        }
    }
}
