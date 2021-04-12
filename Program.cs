using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 31. Solicite un ingreso al usuario y determine si  puede interpretarse como
                   un intervalo de tiempo*/
            string Fecha;
            DateTime SalidaFecha;
            bool Flag = false;
            do
            {
                Console.WriteLine("Ingrese una fecha (formato: dd/MM/yyyy)");
                Fecha = Console.ReadLine();
                if (!DateTime.TryParse(Fecha, out SalidaFecha))
                {
                    Console.WriteLine("Ustede no ha ingresado una fecha");
                }
                else
                {
                    Flag = true;
                    TimeSpan intervalo = DateTime.Now - SalidaFecha;
                    Console.WriteLine($"La fecha {DateTime.Now} y {SalidaFecha} " +
                        $"hay un intervalo de {intervalo.ToString()} ");
                }
            } while (Flag==false);
            Console.WriteLine("Ingrese una tecla para salir");
            Console.ReadKey();
        }
    }
}
