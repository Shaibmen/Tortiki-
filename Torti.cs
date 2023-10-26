using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tortalettki
{
    internal class Torti
    {

        public Dictionary<string, int> Forma()
        {

            Dictionary<string, int> forma = new Dictionary<string, int>()
            {
                {"Круг", 200},
                {"Квадрат", 250},
                {"Треугольник", 240},
                {"Башня", 230},
                {"Прямоугольник", 210}
            };
            return forma;
        }

        public Dictionary<string, int> Razmer()
        {
            Dictionary<string, int> razmer = new Dictionary<string, int>()
            {
                {"Большой", 600},
                {"Средний", 400},
                {"Маленький", 200}
            };
            return razmer;
        }

        public Dictionary <string, int> Korzi() 
        {
            Dictionary<string, int> korzi = new Dictionary<string, int>()
            {
                {"6", 350},
                {"3", 300},
                {"2", 200},
            };
            return korzi;
        }

        public Dictionary<string, int> Glazur()
        {
            Dictionary<string, int> glazur = new Dictionary<string, int>()
            {

                {"чёрный шоколад", 200},
                {"белый шоколад", 210},
                {"экзотическая глазурь", 300},
                {"шоколадная глазурь с зефиром", 400},
                {"глазурь из ягод", 600},
            };
            return glazur;
        }
        public void ShowTortiki(Dictionary<string, int> tort, int PosAdd)
        {
            PosAdd = 2;
            Console.Clear();
            Console.WriteLine("Выберите парамтер пиццы.");
            Console.WriteLine("___________________________________________");
            foreach (var name, price in tort)
            {
                Console.SetCursorPosition(2, PosAdd);
                Console.WriteLine(name + " - " + price);
                PosAdd++;
            }

        }
    }
}
