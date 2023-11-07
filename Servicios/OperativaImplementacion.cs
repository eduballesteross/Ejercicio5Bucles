using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public bool CalcularAñoBisiesto(int año)
        {

            bool añobisiesto = false;
            
            if ((año % 4) == 0)
            {
                añobisiesto = false;

                if ((año % 100) == 0)
                {
                    añobisiesto = false;

                    if ((año % 400) == 0)
                    {
                        añobisiesto = true;
                        
                    }
                    else
                    {
                        añobisiesto = false;
                    }
                }
            }

            return añobisiesto;    
        }
    }
}
