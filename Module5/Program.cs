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
            Console.WriteLine("Ваши любимые блюда: ");
            foreach (var dish in User.Dishes)
            {
                Console.WriteLine(dish);
            }
            

            string [] favcolors = new string [3];

            for (int i = 0;i< favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();

        }

        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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

    }
}
