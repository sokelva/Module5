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

            GetArrayFromConsole();

            #region Tuple
            var (name, age) = ("Елена", 42);
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            age = int.Parse(Console.ReadLine());
            #endregion


            Console.WriteLine("Напишите свое имя: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите любимое блюдо {0}: ", i + 1);
                User.Dishes[i] = Console.ReadLine();

            }
            Console.WriteLine("Ваши любимые блюда: ");
            foreach (var dish in User.Dishes)
            {
                Console.WriteLine(dish);
            }


            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }


            //int [] array = new int[3];
            //int[] array = GetArrayFromConsole();
            Console.ReadKey();

        }

        static string ShowColor(string username, int userage)//, string [] favcolors
        {
            Console.WriteLine("{0} {1} лет,\nнапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        //static void ShowColors(string[] favcolors)
        //{
        //    Console.WriteLine("Ваши любимые цвета:");
        //    foreach (var color in favcolors)
        //    {
        //        Console.WriteLine(color);
        //    }
        //}

        //метод возвращает массив

        static void GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int[] sortResult = SortArray(result);
            
            foreach (var item in sortResult)
            {
                Console.WriteLine("Элементы массива: {0}", item);
            }
            Console.ReadKey();

        }

        static int[] SortArray(int[] result)
        {
            Array.Sort(result);
            return result;
        }

        //Массив параметров

        //static void ShowColors(name, favcolors)
        //{
        //    Console.WriteLine("Ваши любимые цвета:");
        //    foreach (var color in favcolors)
        //    {
        //        Console.WriteLine(color);
        //    }
        //}


        static void SortComplexArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
            }
        }

        static void Sort(string[] args)
        {

            int[,] arr = {
                    { - 5,6,9,1,2,-3},
                    { - 8,8,1,1,2,-3}
                  };

            SortComplexArray(arr);

        }

    }
}
