using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3modules
{
    internal class Zadanie1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            for (int i = 1; i <= 7; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                Console.WriteLine($"Факториал {i}! = {factorial}");
            }
            Console.WriteLine("Нажмите на любую кнопку, чтобы перейти к заданию 2");
            Console.ReadKey();
            Console.WriteLine("Задание 2:");
            Console.WriteLine("Введите изначальное население, не больше 1 млн.");
            int population = Convert.ToInt32(Console.ReadLine());
            if (population >= 1000000)
            {
                Console.WriteLine("Число больше миллиона, вы чего наделали?");

            }
            else
            {
                while (population < 1000000)
                {
                    population += 100;
                    Console.WriteLine($"Население: {population}");
                }
                Console.WriteLine("Поздравляю, итоговая популяция достигла миллиона! Мы все умрём!");
            }
            Console.WriteLine("Нажмите на любую кнопку, чтобы перейти к заданию 3");
            Console.ReadKey();
            Console.WriteLine("Задание 3:");
            Console.WriteLine("Добро пожаловать в игру 'Угадай число!'. \n Сейчас будет загадано случайное число, попытайстесь его отгадать. \n Число от 0 до 11.");
            Random random = new Random();
            int number = random.Next(11);
            int answer;

            do
            {
                Console.WriteLine("Введите число от 0 до 10:");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == number)
                {
                    Console.WriteLine($"Угадали! Это число {number})");
                }
                else
                {
                    Console.WriteLine("Неправильно, попробуй ещё раз!");
                }
            }
            while (answer != number);
        }
    }
}
