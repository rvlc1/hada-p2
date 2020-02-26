using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    class Vehiculo
    {
        public static int maxVelocidad { get; set; }
        public static int maxTemperatura { get; set; }
        public static int minCombustible { get; set; }
        public static Random rand
        {
            set; private get;
        }
        public string nombre { get; private set; }
        private int velocidad;
        private int temperatura;
        private int combustible;
    }
}
