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
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);
            Console.ReadKey();

        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }

        //(string Name, string[] Dishes) User;

        //Console.WriteLine("Напишите свое имя: ");
        //User.Name = Console.ReadLine();

        //User.Dishes = new string[5];

        //for (int i = 0; i < User.Dishes.Length; i++)
        //{
        //    Console.WriteLine("Введите любимое блюдо {0}: ", i + 1);
        //    User.Dishes[i] = Console.ReadLine();

        //}

        //GetDishes(User.Dishes, ref User.Name);

        //}

        //static void GetDishes(string [] dishes, ref string name)
        //{
        //    Console.WriteLine("Ваши любимые блюда: ");
        //    foreach (var dish in dishes)
        //    {
        //        Console.WriteLine(dish);
        //    }
        //}

       

    }
}
