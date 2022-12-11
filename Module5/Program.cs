using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;


            Console.WriteLine("Напишите свое имя: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите любимое блюдо {0}: ", i+1);
                User.Dishes[i] = Console.ReadLine();
                
            }

            Console.ReadKey();

        }
    }
}
