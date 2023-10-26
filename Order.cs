using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortalettki
{
    internal class Order
    {
        public static void order()
        {
            Torti torti = new Torti();
            Strelochki strelochki = new Strelochki();
            int position = strelochki.Show();

            int cena = 0;
            var itog = "";

            if (position == 3)
            {
                cena = 200;
                itog = "квадрат - 200";
            }


            Console.WriteLine("Цена:", cena);
            Console.WriteLine("Ваш торт:", itog);
        }

        

    }
}
