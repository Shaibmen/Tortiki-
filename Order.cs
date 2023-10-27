using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace Tortalettki
{
    internal class Order
    {
       
        public static void FirstMenu()
        {
            bool IsDone = true;
            do
            {

                Console.Clear();
                Console.WriteLine("Добро пожаловать в костыль((!!!");
                Console.WriteLine("Сделайте заказ:");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("  форма");
                Console.WriteLine("  размер");
                Console.WriteLine("  коржи");
                Console.WriteLine("  глазурь");
                Console.WriteLine("  конец заказа");
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(Torti.forma + Torti.razmer + Torti.korzi + Torti.glazur);
                Console.WriteLine("Цена: " + Torti.itog);
                Ordermenu();
            } while (IsDone != false);

        }
        private static void Ordermenu()
        {
            Strelochki strelochki = new Strelochki();
            int position = strelochki.Show();

            if (position == 3)
            {
                Console.Clear();
                secondMenu();
                Console.WriteLine("  1.квадрат - 250");
                Console.WriteLine("  2.круг - 200");
                Console.WriteLine("  3.башня - 300");
                int pos = strelochki.Show();
                if (pos == 3)
                {
                    Torti.forma = " квадратный";
                    Torti.itog += 250;
                    FirstMenu();
                }
                if (pos == 4)
                {
                    Torti.forma = " круглый";
                    Torti.itog += 200;
                    FirstMenu();
                }
                if (pos == 5)
                {
                    Torti.forma = " башня";
                    Torti.itog += 300;
                    FirstMenu();
                }
            }
            if (position == 4)
            {
                Console.Clear();
                secondMenu();
                Console.WriteLine("  1.большой - 600");
                Console.WriteLine("  2.средний - 500");
                Console.WriteLine("  3.маленький - 400");
                int pos = strelochki.Show();
                if (pos == 3)
                {
                    Torti.razmer = " большой";
                    Torti.itog += 600;
                    FirstMenu();
                }
                if (pos == 4)
                {
                    Torti.razmer = " средний";
                    Torti.itog += 500;
                    FirstMenu();
                }
                if (pos == 5)
                {
                    Torti.razmer = " маленький";
                    Torti.itog += 400;
                    FirstMenu();
                }
            }
            if (position == 5)
            {
                Console.Clear();
                secondMenu();
                Console.WriteLine("  1.6 - 350");
                Console.WriteLine("  2.3 - 250");
                Console.WriteLine("  3.1 - 100");
                int pos = strelochki.Show();
                if (pos == 3)
                {
                    Torti.korzi = " 6 коржей";
                    Torti.itog += 200;
                    FirstMenu();
                }
                if (pos == 4)
                {
                    Torti.korzi = " 3 коржа";
                    Torti.itog += 300;
                    FirstMenu();
                }
                if (pos == 5)
                {
                    Torti.korzi = " 1 корж";
                    Torti.itog += 100;
                    FirstMenu();
                }
            }
            if (position == 6)
            {
                Console.Clear();
                secondMenu();
                Console.WriteLine("  1.Чёрный шоколад - 200");
                Console.WriteLine("  2.Белый шоколад - 250");
                Console.WriteLine("  3.Экзотическая - 300");
                int pos = strelochki.Show();
                if (pos == 3)
                {
                    Torti.glazur = " чёрный шоколад";
                    Torti.itog += 200;
                    FirstMenu();
                }
                if (pos == 4)
                {
                    Torti.glazur = " белый шоколад";
                    Torti.itog += 250;
                    FirstMenu();
                }
                if (pos == 5)
                {
                    Torti.glazur = " экзотическая";
                    Torti.itog += 300;
                    FirstMenu();
                }
            }
            if (position == 7)
            {
                Console.Clear();
                Console.WriteLine("Конец заказа");
                Console.WriteLine("цена: " + Torti.itog);
                Console.WriteLine("ваш торт:" + Torti.forma + Torti.razmer + Torti.korzi + Torti.glazur);
                Console.WriteLine("Файл с заказом находиться по этому пути: C:\\Users\\Миша\\Projects\\ProjectC\\Tortiki\\bin\\Debug");
                Console.WriteLine("забыл про универсальный путь((");
                TXTEnjoyer();

                Console.WriteLine("\n\nЕсли вы хотите сделать еще один заказ, нажмите Enter, если хотите выйти из программы, нажмите Escape");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Torti.forma = " ";
                    Torti.razmer = " ";
                    Torti.korzi = " ";
                    Torti.glazur = " ";
                    Torti.itog = 0;
                    FirstMenu();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
        static public void secondMenu()
        {
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("------------------------------");
        }

        private static void TXTEnjoyer()
        {
            DateTime date = DateTime.Now;
            File.AppendAllText("zakazik.txt", "\nЗаказ от " + date + "\nДетали заказа: " + Torti.forma + Torti.razmer + Torti.korzi + Torti.glazur + "\nЦена заказа: " + Torti.itog);
        }
    }
}
