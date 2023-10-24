﻿using System;
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
                        pos = 8;
                    }
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 9)
                    {
                        pos = 3;
                    }
                }


                Console.SetCursorPosition(0, 10);
            } while (key.Key != ConsoleKey.Spacebar);
            return pos;
        }
    }
}

 