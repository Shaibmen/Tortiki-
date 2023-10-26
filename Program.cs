using Microsoft.SqlServer.Server;
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
            bool IsDone = true;

            Torti torti = new Torti();
            FirstMenu firstMenu = new FirstMenu();
           
            do
            {
                firstMenu.ShowFirstMenu();
                Strelochki strelochki = new Strelochki();

                int position = strelochki.Show();

                switch (position)
                {
                    case 3:
                        SecondMenu();
                        
                        Dictionary<string, int> forma = torti.Forma();
                        foreach (KeyValuePair<string, int> items in forma)
                        {
                            Console.WriteLine("{0} - {1}", items.Key, items.Value);
                        }
                        IsDone = true;
                        break;

                    case 4:
                        SecondMenu();

                        Dictionary<string, int> razmer = torti.Razmer();
                        foreach (KeyValuePair<string, int> items in razmer)
                        {
                            Console.WriteLine("{0} - {1}", items.Key, items.Value);
                        }
                        IsDone = true;
                        break;
                    
                    case 5:
                        SecondMenu();

                        Dictionary<string, int> korzi = torti.Korzi();
                        foreach (KeyValuePair<string, int> items in korzi)
                        {
                            Console.WriteLine("{0} - {1}", items.Key, items.Value);
                        }
                        IsDone = true;
                        break;

                    case 6:
                        SecondMenu();

                        Dictionary<string, int> glazur = torti.Glazur();
                        foreach (KeyValuePair<string, int> items in glazur)
                        {
                            Console.WriteLine("{0} - {1}", items.Key, items.Value);
                        }
                        IsDone = true;
                        break;

                    case 7:
                        IsDone = false;
                        break;


                }

            } while (IsDone != false);

        }


        static void SecondMenu()
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("-------------------");

        }
    }
}

