using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortalettki
{
    internal class Strelochki
    {

        public int Show()
        {
            FirstMenu firstMenu = new FirstMenu();
            int pos = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");


                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == 2)
                    {
                        pos = 7;
                    }
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 8)
                    {
                        pos = 3;
                    }
                }

                if (key.Key == ConsoleKey.Escape)
                {
                   
                    firstMenu.ShowFirstMenu();
                }


                Console.SetCursorPosition(0, 10);
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}

 