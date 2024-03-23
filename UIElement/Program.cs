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
            string health;
            int maxHealth = 100;
            int convertHealth;

            Console.SetCursorPosition(0, 1);
            Console.Write("введите количество здоровья:");
            health = Console.ReadLine();

           if (int.TryParse(health, out convertHealth))
           {
               if(convertHealth > maxHealth)
                   convertHealth = maxHealth;
           }
            
                DrawHealthBar(convertHealth, maxHealth, ConsoleColor.Red, 0);
        }

        static void DrawHealthBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = null;
            char fillBar = ' ';
            char emptyBar = '_';

            AddSymbolsInHealthBar(0, value, fillBar, ref bar);

            Console.SetCursorPosition (position, 0);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = null;

            AddSymbolsInHealthBar(value, maxValue, emptyBar, ref bar);

            Console.WriteLine(bar + ']');
        }

        static void AddSymbolsInHealthBar(int value, int maxValue, char symbol, ref string bar)
        {
            for (int i = value; i < maxValue; i++)
                 bar += symbol;
        }
    }
}
