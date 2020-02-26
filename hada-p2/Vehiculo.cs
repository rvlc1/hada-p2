using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    class Vehiculo
    {
        public static int maxVelocidad;
        public static int maxTemperatura;
        public static int minCombustible;
        public static Random rand
        {
            set; private get;
        }
        public string nombre { get; private set; }
        private int _velocidad; 
        private int velocidad 
        {
            get { return _velocidad; }
            set
            {
                if (value > maxVelocidad)
                    _velocidad = -1; //velocidadMaximaExcedida();
                else if (value < 0)
                    _velocidad = 0;
                else
                    _velocidad = value;
            }
            
        }
        private int _temperatura;
        private int temperatura
        {
            get { return _temperatura; }
            set
            {
                if (value > maxTemperatura)
                    _temperatura = -1; //temperaturaMaximaExcedida();
                else
                _temperatura = value;
            }
        }
        private int _combustible;
        private int combustible
        {
            get { return _combustible; }
            set
            {
                if (value < minCombustible)
                    _combustible = -1; //combustibleMinimoExcedido();
                if (value < 0)
                    _combustible = 0;
                else if (value > 100)
                    _combustible = 100;

            }
           
        }
    }
}
