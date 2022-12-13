using System;

class MainClass
{
    static void Main(string[] args)
    {

        string name = EnterUser().Name;
        Console.WriteLine("Ваше имя: {0}", name);


        //Console.WriteLine(PowerUp(2,6));
        //Console.WriteLine("Напишите что-то");
        //var str = Console.ReadLine();
        //Console.WriteLine("Укажите глубину эха");
        //var deep = int.Parse(Console.ReadLine());
        //Echo(str, deep);
        //Console.WriteLine(Factorial(20));
        //Console.ReadKey();
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
        //Есть ли и сколько домашних питомцев
        Console.WriteLine("Есть ли у вас домашнее животное? Да\\Нет");
        string HasPet = Console.ReadLine();
        string [] Pets;
        if (HasPet == "Да")
        {
            string count;
            int itg;
            do
            {
                Console.WriteLine("Укажите количество домашних животных");
                count = Console.ReadLine();

            } while (CheckNum(count, out itg));

            //Если животных > 0
            if (itg > 0)
            {
                Pets = CreateArrayPets(itg);
                User.Pets = Pets;
                return User;
            }
        }
      
        #endregion


        #region Любимые цвета
        //Есть ли и сколько домашних питомцев
        Console.WriteLine("Есть ли у вас любимые цвета? Да\\Нет");
        string IsFavColHas = Console.ReadLine();

        string[] favcolors;
        if (IsFavColHas == "Да")
        {
            string count;
            int itg;
            do
            {
                Console.WriteLine("Укажите количество любимых цветов");
                count = Console.ReadLine();

            } while (CheckNum(count, out itg));

            //Если любимых цветом > 0
            if (itg > 0)
            {
                favcolors = CreateFavColorsArray(itg);
                User.favcolors = favcolors;
                return User;
            }
        }    
       
        #endregion

        //return User;
    }

    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum >0)
            {
                corrnumber = intnum;
                return false; 
            }
        }
        
        {
            corrnumber = 0;
            return true;
        }
    }

    static string [] CreateArrayPets(int num)
    {
        var result = new string[num];
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите кличку {0} животного", i);
            result[i] = Console.ReadLine();
        }
       
        return result;
        
    }

    static string[] CreateFavColorsArray(int num)
    {

        var result = new string[num];
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите {0} любимый цвет", i);
            result[i] = Console.ReadLine();
        }

        return result;

    }



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