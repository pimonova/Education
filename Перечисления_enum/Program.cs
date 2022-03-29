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
            Бой = 4,
            Выход = 5,
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Чтобы зарегистрироваться, наберите {(int)Menu.Регистрация}.");
            Console.WriteLine($"Для авторизации наберите {(int)Menu.Авторизация}.");
            Console.WriteLine($"Для генерации персонажа наберите {(int)Menu.Генерация_персонажа}.");
            Console.WriteLine($"Для начала боя наберите {(int)Menu.Бой}.");
            Console.WriteLine($"Для выхода наберите {(int)Menu.Выход}.");
            int input = int.Parse(Console.ReadLine());
            Menu knopka = (Menu)input;
            Console.WriteLine($"Вы выбрали '{knopka}'.");
        }
    }
}