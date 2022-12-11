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
                Console.WriteLine("Введите любимое блюдо {0}: ", i+1);
                User.Dishes[i] = Console.ReadLine();
                
            }
            Console.WriteLine("Ваши любимые блюда: ");
            foreach (var dish in User.Dishes)
            {
                Console.WriteLine(dish);
            }
            

            string [] favcolors = new string [3];

            for (int i = 0;i< favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }


            //int [] array = new int[3];
            int[] array = GetArrayFromConsole();
            Console.ReadKey();

        }

        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0} {1} лет," + Environment.NewLine+ "напишите свой любимый цвет на английском с маленькой буквы", username, userage);
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
        
        //метод возвращает массив
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

    }
}
