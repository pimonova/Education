using System;

namespace Перечисления_enum
{
    internal class Program
    {
        enum Menu
        {
            Регистрация = 1,
            Авторизация = 2,
            Генерация_персонажа = 3,
            Уровень_1 = 4,
            Уровень_2 = 5,
            Выход = 6,
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Чтобы зарегистрироваться, наберите {(int)Menu.Регистрация}.");
            Console.WriteLine($"Для авторизации наберите {(int)Menu.Авторизация}.");
            Console.WriteLine($"Для генерации персонажа наберите {(int)Menu.Генерация_персонажа}.");
            Console.WriteLine($"Для выбора 1 уровня наберите {(int)Menu.Уровень_1}.");
            Console.WriteLine($"Для выбора 2 уровня наберите {(int)Menu.Уровень_2}.");
            Console.WriteLine($"Для выхода наберите {(int)Menu.Выход}.");
            int input = int.Parse(Console.ReadLine());
            Menu knopka = (Menu)input;
            Console.WriteLine($"Вы выбрали '{knopka}'.");
        }
    }
}