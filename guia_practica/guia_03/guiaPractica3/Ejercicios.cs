using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaPractica3
{
    internal class Ejercicios
    {
        public void Ejercicio4()
        {
            int numeroValidado = SolicitarNumeroYValidarConFuncionBooleana();
            Console.WriteLine($"Su número es: {numeroValidado}");
        }

        private int SolicitarNumeroYValidar()
        {
            string numeroInput;
            int numeroValidado;
            bool flag = false;

            do
            {
                Console.Write("Ingrese un número entre 1 y 10: ");
                numeroInput = Console.ReadLine();

                if (!int.TryParse(numeroInput, out numeroValidado))
                {
                    Console.WriteLine("El número debe ser un entero.");
                }
                else if (numeroValidado < 1 || numeroValidado > 10)
                {
                    Console.WriteLine("El número debe ser mayor a 0 y menor a 10.");
                }
                else
                {
                    flag = true;
                }

            } while (!flag);

            return numeroValidado;
        }

        private int SolicitarNumeroYValidarConFuncionBooleana()
        {
            string numeroInput;
            int numeroOutput;
            bool flag = false;

            do
            {
                Console.Write("Ingrese su número: ");
                numeroInput = Console.ReadLine();
                flag = ValidarNumero(numeroInput, out numeroOutput);

            } while (!flag);

            return numeroOutput;
        }

        private bool ValidarNumero(string numeroInput, out int numeroOutput)
        {
            bool flag = false;

            if (!int.TryParse(numeroInput, out numeroOutput))
            {
                Console.WriteLine("El número debe ser un entero.");
            }
            else if (numeroOutput < 1 || numeroOutput > 10)
            {
                Console.WriteLine("El número debe ser mayor a 0 y menor a 10.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
