using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTLYA
{
    internal class Ejercicios
    {
        public void DeclararVariables()
        {
            // Declaracion de variable
            string nombrePersona;
            string apellidoPersona;
            byte edadPersona;

            // Se asignan los valores a las variables
            nombrePersona = "Thomas";
            apellidoPersona = "Gomez";
            edadPersona = 25;

            // Imprimo las variables por consola
            Console.WriteLine("La persona se llama " + nombrePersona + " su apellido es " + apellidoPersona + ". Su edad es " + edadPersona + ".");
        }    

        public void DeclararConstantes()
        {
            const int numero1 = 5000;
            const string nombre1 = "José";

            Console.WriteLine("Existen las siguientes constantes: " + numero1 + " " + nombre1);
        }

        public void PedirDatosDinamicos()
        {
            // Declaro variables
            string nombreUsuario; 
            string apellidoUsuario;
            byte edadUsuario;

            // Imprimo por consola
            Console.Write("Por favor ingrese su nombre: ");
            nombreUsuario = Console.ReadLine();

            Console.Write("Por favor ingrese su apellido: ");
            apellidoUsuario = Console.ReadLine();

            Console.Write("Por favor ingrese su edad: ");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Su nombre es " + nombreUsuario + ", su apellido " + "Gomez, y su edad " + edadUsuario + ".");
        }

        public void SumarDatos()
        {
            float dato1;
            float dato2;
            float suma;

            // Asigno valores a las variables
            Console.Write("Por favor ingrese un valor para el dato 1: ");
            dato1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese un valor para el dato 2: ");
            dato2 = Convert.ToSingle(Console.ReadLine());

            suma = dato1 + dato2;

            Console.WriteLine("El resultado de la suma de dato1 y dato2 es: " + suma);
        }
    }
}
