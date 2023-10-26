using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tortalettki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torti tort = new Torti();
            FirstMenu firstMenu = new FirstMenu();
            firstMenu.ShowFirstMenu();
            do
            {
                Strelochki strelochki = new Strelochki();

                int position = strelochki.Show();

                switch (position)
                {
                    case 3:
                        form();
                        foreach ( in tort)
                        {

                        }
                        break;

                }

            } while (true);

        }


        static void form()
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("-------------------");

            Console.WriteLine();

        }
    }
}

