using System.Globalization;
using System.Reflection.PortableExecutable;

namespace oefeningen_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CodeTiming()
            DateTime time = DateTime.Now;
            int[] ints = new int[1000000];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
                time = time.AddMicroseconds(1);
            }
            Console.WriteLine($"Aantal milliseconden: {time.Millisecond}");
        }

        public static void Menu()
        {
            bool again = true;
            Console.WriteLine("Welkom bij de oefeningen van OOP");

            do
            {
                Console.WriteLine("Kies uw topic: ");
                Console.WriteLine("1. DateTime()");
                Console.WriteLine("2. Propereties en access mofifiers()");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

                Console.WriteLine("Nog een topic?");
                string newTopic = Console.ReadLine();
                if(newTopic.ToLower() == "ja")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
            } while (again == true);
        }
    }
}
