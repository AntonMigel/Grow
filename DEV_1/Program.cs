using System;

namespace DEV_1
{  
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность:");
            string line = Console.ReadLine();
            int result = 1, number = 1;
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] == line[i + 1])
                {
                    number++;
                    if (number > result)
                    {
                        result = number;
                    }
                }
                else
                {
                    number = 1;
                }
            }
            Console.WriteLine($"Максимальное количество одинаковых последовательных символов в строке:{result}");
        }
    }
}