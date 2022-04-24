using System;

namespace MyNamespace
{
    class Program
    {
        static bool CheckNum(string number, out int corrnumber)
        {
            if(int.TryParse(number, out int intnum))
            {
                if(intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            corrnumber = 0;
            return true;
        }
        
        static string[] FavColors(int numbers)
        {
            string[] favcolors = new string[numbers];

            Console.WriteLine("Напишите ваши любимые цвета: ");
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine($"Цвет № {i + 1}");
                favcolors[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach(string color in favcolors)
            {
                Console.WriteLine(color);
            }

            return favcolors;

        }


        static string[] Pet(int amountPet)
        {
            string[] Pets = new string[amountPet];
            for (int i = 0; i < Pets.Length; i++)
            {
                Console.WriteLine($"Введит кличку вашего питомца № {i + 1}");
                Pets[i] = Console.ReadLine();
            }

            return Pets;
        }



        static (string Name, string LastName, int Age) UserInformation()
        {

            // Сбор данных о пользователе
            #region
            (string Name, string LastName, int Age) User;
            User.Name = "Name";
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            User.LastName = "LastName";
            Console.WriteLine("Введите фамилию: ");
            User.LastName = Console.ReadLine();

            User.Age = 0;
            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами: ");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));

            User.Age = intage;

            Console.WriteLine("\n***********************************************************************************\n");
            #endregion

            // Домашнее животное
            #region
            Console.WriteLine("У вас есть домашее животное?\nВведите Да или Нет");
            string petAvailability = Console.ReadLine();
            int amountPet;

            if (petAvailability == "Да")
            {
                
                string age1;
                int intage1;
                do
                {
                    Console.WriteLine("Введите количество ваших питомцев цифрами: ");
                    age1 = Console.ReadLine();
                } while (CheckNum(age1, out intage1));

                amountPet = intage1;
                Pet(amountPet);
            }
            else
            {
                Console.WriteLine("У вас нет домашнего животного.");
            }
            #endregion
            Console.WriteLine("\n***********************************************************************************\n");

            // любимые цвета
            #region
            int numbers;
            string numberOfColors;
            int intage2;
            do
            {
                Console.WriteLine("Введите количество любимых цветов цифрами: ");
                numberOfColors = Console.ReadLine();
            } while (CheckNum(numberOfColors, out intage2));
             numbers = intage2;
            FavColors(numbers);
            #endregion

            return User;
        }

        public static void Main(string[] agrs)
        {
            UserInformation();

        }
    }
}