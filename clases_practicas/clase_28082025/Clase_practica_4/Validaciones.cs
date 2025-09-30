using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_practica_4
{
    public class Validaciones
    {
        public void validacionInt()
        {
            string edadInput;
            int edadOutput;
            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese la edad: ");
                edadInput = Console.ReadLine();                

                if (!int.TryParse(edadInput, out edadOutput))
                {
                    Console.WriteLine("El dato debe ser numerico.");
                }
                else if (edadOutput <= 0 || edadOutput > 110)
                {
                    Console.WriteLine("La edad debe ser entre 1 y 110.");
                }
                else
                {
                    flag = true;
                } 
            } while (!flag);

            Console.WriteLine("Gracias por ingresar su edad! ");
        }        
        public void validacionString()
        {
            string apellido;
            bool flag = false;

            do
            {
                Console.Write("Ingrese su apellido: ");
                apellido = Console.ReadLine();

                // Valido que no sea nulo o vacío 
                if (string.IsNullOrEmpty(apellido)) // apellido == ""
                {
                    Console.WriteLine("El apellido no debe ser nulo o vacío.");
                }
                else if (apellido.Length > 30)
                {
                    Console.WriteLine("El apellido debe ser menor a 30 caracteres.");
                }
                else
                {
                    flag = true;
                }
            } while (!flag);
        }
        
        public void validacionFecha()
        {
            string fecha;
            DateTime fechaOutput;
            bool flag = false;

            do
            {
                Console.Write("Ingrese la fecha: ");
                fecha = Console.ReadLine();

                if (!DateTime.TryParse(fecha, out fechaOutput))
                {
                    Console.WriteLine("La fecha debe ser de tipo DateTime.");
                }
                else if (fechaOutput > DateTime.Now) // DateTime.Today.AddDays(-10))
                {
                    Console.WriteLine("La fecha no debe ser una fecha futura.");
                }
                else
                {
                    flag = true;
                }
            } while (!flag);

        }
    }
}
