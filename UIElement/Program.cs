using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health;
            int maxHealth = 10;
            int healthConvertInPercent;

                Console.SetCursorPosition(0, 1);
                Console.Write("введите количество здоровья в процентах:");
                health = Convert.ToInt32(Console.ReadLine());

            healthConvertInPercent = health / maxHealth;

            if (healthConvertInPercent >= maxHealth)
                    healthConvertInPercent = maxHealth;

                HealthBar(healthConvertInPercent, maxHealth, ConsoleColor.Red, 0);
        }

        static void HealthBar (int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = null;
            char fillBar = '#';
            char emptyBar = '_';

            for (int i = 0; i < value; i++)
            {
                bar += fillBar;
            }

            Console.SetCursorPosition (position, 0);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = null;

            for (int i = value ;i < maxValue; i++)
            {
                bar += emptyBar;
            }

            Console.WriteLine(bar + ']');
        }
    }
}
