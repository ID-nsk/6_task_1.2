using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа находит самое длинное слово в предложении");
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();
            string[] str = input.Split(' ', ',', '.', ':', '!', '?', ';');
            int max = str.Select(word => word.Length).Max();
            Console.WriteLine("Самое длинное слово содержит: {0} букв", max);
            Console.WriteLine("Для выхода нажмине любую клавишу");
            Console.ReadKey();
        }
    }
}
