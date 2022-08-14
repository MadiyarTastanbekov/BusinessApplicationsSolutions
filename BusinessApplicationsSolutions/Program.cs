using System;
using System.Collections.Generic;

namespace BusinessApplicationsSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, string>() { [3] = "Hello three", [5] = "Hello five" };
            Functions(30, dic);
            Console.ReadLine();
        }
        public static void Functions(int number, Dictionary<int, string> conditions)

        {
            int m = 0, x = 0;
            for (int i = 1; i <= number; i++)
            {
                foreach (var keys in conditions)
                {
                    if ((i % keys.Key) == 0)
                    {
                        Console.Write(keys.Value); m = i;
                        x++;
                    }
                };
                if (i == m) { Console.WriteLine(); continue; }
                else Console.WriteLine(i); 
            }
            if (x == 0) Console.WriteLine("Проверка непрошел");
        }
    }
}
