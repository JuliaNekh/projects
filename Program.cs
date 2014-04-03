using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_4
{
    class Program
    {
        static MyList Find(MyList words)
        {
            return words;
        }
        static void Main(string[] args)
        {
            MyList words = new MyList();
            MyList result = new MyList();
            string tmp = Convert.ToString(Console.ReadLine());
            string[] arr = tmp.Split(',', ' ', '.');
            for (int i = 0; i < arr.Length; i++)
            {
                words.Add(arr[i]);
            }
            Console.WriteLine("начальный список:");
            words.Printer();
            Console.WriteLine();
            Console.WriteLine("результат выполнения операции:");
            result = words.ChangeList(words);
            result.Printer();
            Console.ReadKey();
        }
    }
}