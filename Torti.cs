using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tortalettki
{
    internal class Torti
    {
        public Dictionary<string, int> Forma()
        {

            Dictionary<string, int> forma = new Dictionary<string, int>()
            {
                { "  квадрат", 200},
                { "  круг", 250 },
                { "  прямоугольник", 300 },
            };
            return forma;
        }
        public Dictionary<string, int> Razmer()
        {

            Dictionary<string, int> razmer = new Dictionary<string, int>()
            {
                { "  большой", 600},
                { "  средний", 400 },
                { "  маленький", 250 }
            };
            return razmer;
        }
        public Dictionary<string, int> Korzi()
        {

            Dictionary<string, int> korzi = new Dictionary<string, int>()
            {
                { "  6", 600},
                { "  4", 400 },
                { "  2", 200 }
            };
            return korzi;
        }

        public Dictionary<string, int> Glazur()
        {

            Dictionary<string, int> glazur = new Dictionary<string, int>()
            {
                { "  чёрный шоколад", 300},
                { "  белый шоколад", 100 },
                { "  экхотическая", 400 },
                { "  тропичекая", 300}
            };
            return glazur;
        }


    }


}
