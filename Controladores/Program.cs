using Ejercicio5Bucles.Servicios;

namespace Ejercicio5Bucles;

/// <summary>
/// Clase principal de la aplicación
/// 051123 - ebp
/// </summary>

    class Program
    {

    /// <summary>
    /// Método principal de la aplicación 
    /// 051123 - ebp
    /// </summary>
    /// <param name="args"></param>
    static public void Main(string[] args)
    {
        MenuInterfaz mI = new MenuImplementacion();

        int numMes, año;

        numMes = mI.PedirYMostrarMes();
        año = mI.PedirYMostrarAño();

        if (numMes == 1 || numMes == 3 || numMes == 5 || numMes == 7 || numMes == 8 || numMes == 10 || numMes == 12)

        {
            Console.WriteLine("El mes número " + numMes + " del año " + año + " tiene 31 dias");
        }
        else (numMes == 4 || numMes == 6 || numMes == 9 || numMes == 11)
            {
               if (numMes == 2) 
            {
            }
            }
    }
    }