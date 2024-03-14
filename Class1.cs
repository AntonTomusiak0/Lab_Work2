
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace ConsoleApp5
{
    public static class Work
    {
        public static void Task1()
        {
            int[] numbers = new int[5];
            int res = 0, doub = 0, thre = 0, spec = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = int.Parse(Console.ReadLine());
                numbers[i] = res;
                if (res % 2 == 0)
                {
                    doub++;
                }
                else
                {
                    thre++;
                }
            }
            Console.WriteLine(doub);
            Console.WriteLine(thre);
            foreach (int i in numbers) { Console.Write(i + " "); }
        }
        public static void Task2()
        {
            int a = int.Parse(Console.ReadLine());
            int[] numbers = new int[5];
            int res = 0, seach = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = int.Parse(Console.ReadLine());
                numbers[i] = res;
                if (res < a)
                {
                    seach++;
                }
            }
            Console.WriteLine(seach);
            foreach (int i in numbers) { Console.Write(i + " "); }
        }
        public static void Task3()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] {  }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
        public static void Task4()
        {
            int[] numbers1 = { 7, 2, 5, 1, 9 };
            int[] numbers2 = { 3, 2, 5, 9, 8 };
            int[] numbers3 = new int[5];
            int w = 0;
            Console.WriteLine("Arr 1: ");
            foreach (int i1 in numbers1) { Console.Write(i1 + " "); }
            Console.WriteLine("Arr 2: ");
            foreach (int i2 in numbers2) { Console.Write(i2 + " "); }
            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int i2 = 0; i2 < numbers2.Length; i2++)
                {
                    if (numbers1[i] == numbers2[i])
                    {
                        numbers3[i] = numbers1[i];
                    }
                }
            }
            Console.WriteLine("Arr 3: ");
            foreach (int i3 in numbers3) { Console.Write(i3 + " "); }
        }
        public static void Task5()
        {
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };
            int min, max;
            min = array[0, 0];
            max = array[0, 0];
            foreach (int i in array)
            {
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
            }
        }
        public static void Task6()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
        public static void Task7()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
        public static void Task8()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { 'a', 'e', 'o', 'i', 'u', 'y' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
        public static void Task9()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            Console.WriteLine("Input: ");
            string inputw = Console.ReadLine();
            string[] words = input.Split(new char[] { inputw }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
    }
}