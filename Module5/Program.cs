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
            int data = 5;
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr, data);

            Console.WriteLine(arr[0]);

            Console.WriteLine("Введите свое имя: ");
            //GetName();
            Console.ReadKey();

        }

        static void BigDataOperation(in int[] arr,in int data) //in защищает данные от изменения/ используется лишь в случаях, когда изменять данные не нужно
        {
            //data = 4;
            arr[0] = data;
        }

        static void GetName(out string name, out string oldname)
        {
            oldname = "Евгения";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void GetAge(out string Name, out byte Age)
        {
            Name = "Елена";
            Age = 42;
        }

        //num1, num2, num3, num4
        static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
        {
            num3 = (num1 + num2)* num4;
            return num3;
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
