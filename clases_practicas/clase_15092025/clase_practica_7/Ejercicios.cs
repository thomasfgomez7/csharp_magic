using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_practica_7
{
    internal class Ejercicios
    {
        public void Ejercicio1()
        {
            string[] alumnos = new string[5];
            string nombre;
            int fila;
            int ultimaFila = alumnos.Length; // ultimaFila = 5;
            string acumulador = "";
            bool flag = false;

            for (fila=0; fila<ultimaFila; fila++)
            {
                do
                {
                    Console.Write($"Ingrese el nombre del alumno {fila + 1}: ");
                    nombre = Console.ReadLine();

                    flag = ValidarVacio(nombre);

                } while (!flag);

                alumnos[fila] = nombre;
                acumulador += nombre + Environment.NewLine;                
            }

            Console.WriteLine($"La lista de alumnos es:{Environment.NewLine} {acumulador}");
        }

        private bool ValidarVacio(string valor)
        {
            bool flag = false;

            if (String.IsNullOrEmpty(valor))
            {
                Console.WriteLine($"El valor no puede ser vacío.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public void Ejercicio2()
        {
            float[] sueldos = new float[8];
            string sueldo;
            float sueldoFloat;
            float sueldoTotal = 0;
            int fila;
            int ultimaFila = sueldos.Length;
            string acumulador = "";
            bool flag = false; 

            for (fila=0; fila < 8; fila++)
            {
                do
                {
                    Console.Write("Ingrese el sueldo: ");
                    sueldo = Console.ReadLine();

                    flag = ValidarFloat(sueldo, out sueldoFloat);

                } while (!flag);

                Console.WriteLine("Sueldo ingresado correctamente!");

                sueldos[fila] = sueldoFloat;
                acumulador += sueldoFloat + Environment.NewLine;
                sueldoTotal += sueldoFloat;

            }

            Console.WriteLine("La lista de sueldos es la siguiente: " + Environment.NewLine + acumulador);
            Console.WriteLine($"{Environment.NewLine} El sueldo total es ${sueldoTotal}");
        }

        private bool ValidarFloat(string valorInput, out float sueldoFloat)
        {            
            bool flag = false;

            if (!float.TryParse(valorInput, out sueldoFloat))
            {
                Console.WriteLine("El valor debe ser un float.");
            }
            else if (sueldoFloat < 1)
            {
                Console.WriteLine("El valor debe ser positivo.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public void Ejercicio3()
        {
            string[,] alumnosCurso = new string[5, 2];
            string nroRegistro;
            string nombre;
            int nroRegistroValidado;
            int fila;
            int ultimaFila = alumnosCurso.GetLength(0);            
            string acumulador = "";
            bool flag = false;

            for (fila=0; fila<ultimaFila; fila++)
            {
                // Valido nroRegistro
                do
                {
                    Console.Write("Ingrese el numero de registro: ");
                    nroRegistro = Console.ReadLine();

                    flag = ValidarInt(nroRegistro, out nroRegistroValidado);                    

                } while (!flag);                            

                // Valido nombre
                do
                {
                    Console.Write("Ingrese su nombre: ");
                    nombre = Console.ReadLine();

                    flag = ValidarVacio(nombre);

                } while (!flag);

                // Asigno los valores
                alumnosCurso[fila, 0] = nroRegistro;
                alumnosCurso[fila, 1] = nombre;

                acumulador += nroRegistro + " - " + nombre + Environment.NewLine;
            }

            Console.WriteLine("Los datos de la matriz son: " + Environment.NewLine + acumulador);

        }

        private bool ValidarInt(string valor, out int valorOutput)
        {
            bool flag = false;

            if (!int.TryParse(valor, out valorOutput))
            {
                Console.WriteLine("El valor debe ser un entero.");
            }
            else if (valorOutput < 1)
            {
                Console.WriteLine("El valor debe ser positivo");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
