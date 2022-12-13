using System;

class MainClass
{
    static void Main(string[] args)
    {
        ShowUser();
    }

    static (string Name, string Lastname, double Age, string [] Pets, string [] favcolors) EnterUser()
    {

        (string Name, string LastName, double Age, string [] Pets , string[] favcolors) User;

        Console.WriteLine("Введите свое имя: ");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию: ");
        User.LastName = Console.ReadLine();

        string age;
        int intage;
        do
        {
            Console.WriteLine("Введите возраст цифрами");
            age = Console.ReadLine();

        } while (CheckNum(age, out intage));
        User.Age = intage;


        #region Домашние питомцы
        User.Pets = CreatePetsArray();
        #endregion


        #region Любимые цвета
        User.favcolors = CreateFavColorsArray();
        #endregion

        return User;
    }

    static bool CheckNum(string number, out int corrnum)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum >0)
            {
                corrnum = intnum;
                return false; 
            }
        }
        {
            corrnum = 0;
            return true;
        }
    }

    static string [] CreatePetsArray(int itg = 0)
    {
        //Есть ли и сколько домашних питомцев
        Console.WriteLine("Есть ли у вас домашнее животное? Да\\Нет");
        string HasPet = Console.ReadLine();

        string count;
        if (HasPet.ToUpper() == "ДА")
        {
            do
            {
                Console.WriteLine("Укажите количество домашних животных");
                count = Console.ReadLine();

            } while (CheckNum(count, out itg));
        }

        var result = new string[itg];

        //Если животных > 0
        if (itg > 0)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите кличку {0} животного", i+1);
                result[i] = Console.ReadLine();
            }
        }
        return result;
        
    }

    static string[] CreateFavColorsArray(int itg = 0)
    {
    //Есть ли и сколько домашних питомцев
    Console.WriteLine("Есть ли у вас любимые цвета? Да\\Нет");
    string IsFavColHas = Console.ReadLine();

        if (IsFavColHas.ToUpper() == "ДА")
        {
            string count;
            do
            {
                Console.WriteLine("Укажите количество любимых цветов");
                count = Console.ReadLine();

            } while (CheckNum(count, out itg));
        }

        var result = new string[itg];

        //Если цветов > 0
        if (itg > 0)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите {0} любимый цвет", i+1);
                result[i] = Console.ReadLine();
            }
        }
        return result;
    }

    static void ShowUser()
    {
        var result = EnterUser();
        Console.WriteLine("----------------------\nВаше имя: {0}\nВаша фамилия: {1}\nВаш возраст: {2}", result.Name, result.Lastname, result.Age);

        if (result.Pets.Length > 0)
        {
            Console.WriteLine("\nВаши питомцы:");
            foreach (var item in result.Pets)
            {
                Console.WriteLine("{0}", item);
            }
            
        }
        
        if (result.favcolors.Length > 0)
        {
            Console.WriteLine("\nВаши любимые цвета:");
            foreach (var item in result.favcolors)
            {
                Console.WriteLine("{0}", item);
            }
        }
        
        Console.ReadKey();
    }



    ///Задания не относящиеся к 5.6. Итоговый проект
    
    //static void Echo(string saidworld, int deep)
    //{
    //    var modif = saidworld;
    //    if (modif.Length > 2)
    //    {
    //        modif = modif.Remove(0, 2).Trim();
    //    }
    //    Console.BackgroundColor = (ConsoleColor)deep;
    //    Console.WriteLine("..." + modif);

    //    if (deep > 1)
    //    {
    //        Echo(modif, deep - 1);
    //    }
    //}

    //static decimal Factorial(decimal x)
    //{
    //    if (x == 0)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        return x * Factorial(x - 1);
    //    }
    //}

    //private static int PowerUp(int N, byte pow)
    //{
    //    if (pow == 0)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        if (pow == 1)
    //        {
    //            return N;
    //        }
    //        else
    //        {
    //            return N * PowerUp(N, --pow);
    //        }
    //    }
    //}
}