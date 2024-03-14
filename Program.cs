using System.Collections.Specialized;

namespace ConsoleApp5
{
    public class program
    {
        static void Main(string[] args)
        {
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-9 or 0 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.WriteLine("\nTask 1: ");
                        Work.Task1();
                        break;
                    case 2:
                        Console.WriteLine("\nTask 2: ");
                        Work.Task2();
                        break;
                    case 3:
                        Console.WriteLine("\nTask 3: ");
                        Work.Task3();
                        break;
                    case 4:
                        Console.WriteLine("\nTask 4: ");
                        Work.Task4();
                        break;
                    case 5:
                        Console.WriteLine("\nTask 5: ");
                        Work.Task5();
                        break;
                    case 6:
                        Console.WriteLine("\nTask 6: ");
                        Work.Task6();
                        break;
                    case 7:
                        Console.WriteLine("\nTask 7: ");
                        Work.Task7();
                        break;
                    case 8:
                        Console.WriteLine("\nTask 8: ");
                        Work.Task8();
                        break;
                    case 9:
                        Console.WriteLine("\nTask 9: ");
                        Work.Task9();
                        break;
                    case 0:
                        whil = 1;
                        break;

                }
            }
        }
    }
}