using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_practica2
{
    internal class ejercicioRepeticion
    {
        public void ejemploDo()
        {
            // EJEMPLO DE CICLO DO

            int nota;
            string situacion;
            string condicionSalida;

            do
            {
                Console.Write("Por favor ingrese una nota: ");
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota < 4)
                {
                    situacion = "Aplazado";
                }
                else if (nota < 7)
                {
                    situacion = "Regularizado";
                }
                else
                {
                    situacion = "Promocionado";
                }

                Console.WriteLine("La condición del alumno es: " + situacion);

                Console.Write("¿Desea ingresar otra nota? (S/N): ");
                condicionSalida = Console.ReadLine();
            } while (condicionSalida == "S");

            Console.WriteLine("¡Hasta luego!");
        }

        public void ejemploContador()
        {
            int nota;
            int contador = 0;

            do
            {
                Console.Write("Por favor ingrese la nota: ");
                nota = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Su nota es: " + nota);

                contador += 1;
                Console.WriteLine("El contador está en: " + contador);
            }
            while (contador < 5);
        }

        public void ejemploAcumulador()
        {
            float montoArticulo;
            float totalFactura = 0;
            string condicionSalida;

            do
            {
                Console.WriteLine("Ingrese el monto del artículo: ");
                montoArticulo = Convert.ToSingle(Console.ReadLine());

                totalFactura += montoArticulo;

                Console.Write("Desea agregar otro artículo (S/N): ");
                condicionSalida = Console.ReadLine();
            } while (condicionSalida == "S" || condicionSalida == "s");

            Console.WriteLine("El monto de la factura es $" + totalFactura);
        }

        public void ejemploFor()
        {
            int contador = 0;
            float montoArticulo;
            float totalFactura_ = 0;            

            // ciclo for (inicialización; condición; iteración)
            // ejemplo for (i=0, i<5; i++)

            for (contador = 0; contador < 5; contador += 1)
            {
                Console.Write("Ingrese el monto del artículo " + (contador + 1) + " de su factura: ");
                montoArticulo = Convert.ToSingle(Console.ReadLine());
                totalFactura_ += montoArticulo;
            }

            Console.WriteLine("El monto de la factura es $" + totalFactura_);
        }
    }
}
