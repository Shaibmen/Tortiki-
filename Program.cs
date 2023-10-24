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

            Console.WriteLine("adrgasgdags");
            Console.WriteLine("asdvxc");
            Console.WriteLine("-------------------");
            FirstMenu();


        }

        static void FirstMenu()
        {
            Strelochki strelochki = new Strelochki();
            Console.WriteLine("   Форма торта");
            Console.WriteLine("   Размер торта");
            Console.WriteLine("   Вкус коржей");
            Console.WriteLine("   Количество коржей");
            Console.WriteLine("   Глазурь");
            Console.WriteLine("   Конец заказа");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Цена: ");
            Console.WriteLine("Ваш торт: ");
            int position = strelochki.Show();

            if (position == 3)
            {

            }
            


        }

        static void form()
        {
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("-------------------");

            Console.WriteLine();

        }
    }
}
