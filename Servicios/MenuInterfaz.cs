using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que pide el número del mes deseado por el usuario
        /// 061123 - ebp
        /// </summary>
        /// <returns></returns>
        public int PedirYMostrarMes();

        /// <summary>
        /// Método que pide el número del año deseado por el usuario
        /// </summary>
        /// <returns></returns>

        public int PedirYMostrarAño();

       

    }
}
