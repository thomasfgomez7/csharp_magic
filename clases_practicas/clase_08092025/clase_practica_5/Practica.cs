using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_practica_5
{
    public class funcionesProcedimientos
    {

        // Una funcion siempre debe devolver un tipo de dato específico. Toda función debería tener un test unitario. Debe mantener sus propios datos y variables, sin tener acceso a información que no le compete, la cual está en la rutina principal.

        // Un procedimiento ejecuta determinadas tareas, sin un return específico.

        // Nivel de acceso de las variables, funciones y procedimientos:
        // public: las variables serán visibles por todas las clases del programa
        // private: las variables serán privadas, solamente podrá verlas la función/procedimiento.

        public int FuncionSumar()
        {
            int primerNumero;
            int segundoNumero;
            int resultado;

            Console.WriteLine("Ingrese el primer numero: ");
            primerNumero = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            segundoNumero = Convert.ToByte(Console.ReadLine());

            resultado = primerNumero + segundoNumero;

            return resultado;
        }

        public string SolicitarYDevolverNombre()
        {
            string nombre;

            Console.Write("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine($"Su nombre es: {nombre}");

            return nombre;
        }

        public int SumaDosNumeros(int numero1, int numero2)
        {
            int resultado;

            Console.WriteLine($"La suma a realizar es: {numero1} + {numero2}");

            resultado = numero1 + numero2;
            Console.WriteLine($"El resultado es: {resultado}");

            return resultado;
        }

        public int ValorRef(int valor)
        {
            int resultado;

            Console.WriteLine("EL valor es:" + valor);

            valor = 1;

            resultado = valor - 1;

            Console.WriteLine($"Luego de pisar el valor es: {resultado}");

            return resultado;
        }

        public string ValorPorOut(out string nombre)
        {
            Console.Write("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            nombre = "Edinson";

            Console.WriteLine($"Su nombre es: {nombre}");

            return nombre;
        }
    }
}