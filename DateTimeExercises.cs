using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oefeningen_OOP
{
    internal class DateTimeExercises
    {
        public static void Submenu()
        {
            Console.WriteLine("Uit te voeren oefening: ");
            Console.WriteLine("1. H10-Clock");
            Console.WriteLine("2. H10-Birthday");
            Console.WriteLine("3. H10-DayOfWeek");
            Console.WriteLine("4. H10-TicksSince2000");
            Console.WriteLine("5. H10-LeapyearCount");
            Console.WriteLine("6. H10-CodeTiming");
            Console.WriteLine("7. H10-CombinationOf2Numbers");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Clock();
                    break;
                case 2:
                    Birthday();
                    break;
                case 3:
                    DayOfWeek();
                    break;
                case 4:
                    TicksSince2000();
                    break;
                case 5:
                    LeapYearCount();
                    break;
                case 6:
                    CodeTiming();
                    break;
                default: break;

            }
        }

        // oefeningen H10
        public static void Clock()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                DateTime time = DateTime.Now;
                Console.WriteLine(time.ToString("T"));
            }
        }
        
        public static void Birthday()
        {
            Console.WriteLine("Wanneer ben je jarig?");
            string input = Console.ReadLine();
            DateTime birthday = DateTime.Parse(input);
            DateTime today = DateTime.Now;
            TimeSpan timeSpan = birthday - today;
            Console.WriteLine($"Over {timeSpan.Days} dagen ben je jarig");
        }

        public static void DayOfWeek()
        {
            DateTime date = new DateTime(2020, 04, 12);
            string day = date.ToString("dddd");
            //Console.WriteLine($"{date.ToString("dd MMMM yyyy")} is een {day}");
            //Console.WriteLine($"{date.ToShortDateString()} is een {day}");
        }

        public static void TicksSince2000()
        {
            DateTime start = new DateTime(2000, 01, 01);
            DateTime now = DateTime.Now;
            TimeSpan diff = now - start;
            long ticks = diff.Ticks;
            Console.WriteLine($"Number of ticks: {ticks}");
        }

        public static void LeapYearCount()
        {
            DateTime start = new DateTime(1799, 01, 01);
            DateTime end = new DateTime(2000, 01, 01);

            int numberOfLeaps = 0;
            bool isLeapYear = false;
            while (start <= end)
            {
                if (DateTime.IsLeapYear(start.Year))
                {
                    isLeapYear = true;
                    numberOfLeaps++;
                }
                start = start.AddYears(1);
            }
            Console.WriteLine($"Aantal schrikkeljaren tussen 1799 en 2000: {numberOfLeaps}");
        }

        public static void CodeTiming()
        {
            DateTime time = DateTime.Now;
            int[] ints = new int[1000000];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
                time = time.AddMicroseconds(1);
            }
            Console.WriteLine($"Aantal milliseconden: {time.Millisecond}");
        }

    }
}
