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
            int maxHealth = 10;
            int percentHealth = 0;

            GetHelthColculation(ref percentHealth, maxHealth);
            
            DrawHealthBar(percentHealth, maxHealth, ConsoleColor.Red, 0);
        }

        static void DrawHealthBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = null;
            char fillBar = ' ';
            char emptyBar = '_';

            AddSymbolsInHealthBar(0, value, fillBar, ref bar);

            GetColorBar(position, color, bar);
            
            bar = null;

            AddSymbolsInHealthBar(value, maxValue, emptyBar, ref bar);

            Console.WriteLine(bar + ']');
        }

        static void AddSymbolsInHealthBar(int value, int maxValue, char symbol, ref string bar)
        {
            for (int i = value; i < maxValue; i++)
                 bar += symbol;
        }

        static void GetColorBar(int position, ConsoleColor color, string bar)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            Console.SetCursorPosition(position, 0);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
        }

        static void GetHelthColculation(ref int percentHealth, int maxHealth)
        {
            int convertHealth;
            string health;
            int maxPercent = 100;

            Console.SetCursorPosition(0, 1);
            Console.Write("введите процент заполненности здоровья:");
            health = Console.ReadLine();

            if (int.TryParse(health, out convertHealth))
            {
                percentHealth = maxHealth * convertHealth / maxPercent;

                if (percentHealth > maxHealth)
                    percentHealth = maxHealth;
            }
        }
    }
}
