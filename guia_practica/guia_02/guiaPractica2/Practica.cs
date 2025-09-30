using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaPractica2
{
    public class Class1
    {
        public void ejercicio1()
        {
            float total_ventas = 0;
            float monto_venta;

            int contador = 0;
            string respuesta_usuario;

            do
            {
                Console.Write("Ingrese el monto de la venta: ");

                monto_venta = Convert.ToInt64(Console.ReadLine());

                total_ventas += monto_venta;
                contador += 1;

                Console.WriteLine("Desea cargar otra venta?: (S/N)");
                respuesta_usuario = Console.ReadLine();

            }
            while (respuesta_usuario == "S" || respuesta_usuario == "s");

            Console.Write("El total de sus ventas es: " + total_ventas);
        }

        public void ejercicio4()
        {
            int colectivo_duracion = 30;
            int subte_duracion = 15;
            int bicicleta_duracion = 45;

            int opcion_usuario;

            //String[] medios_transporte = new string[3];
            //medios_transporte[0] = "Colectivo";
            //medios_transporte[1] = "Subte";
            //medios_transporte[1] = "Bicicleta";

            string[] medios_transporte = { "1.Colectivo", "2.Subte", "3.Bicicleta" };

            Console.WriteLine("Hola Usuario!");
            Console.WriteLine(medios_transporte[0]);
            Console.WriteLine(medios_transporte[1]);
            Console.WriteLine(medios_transporte[2]);
            Console.Write("Elige un medio de transporte para tu viaje a la universidad: ");

            opcion_usuario = Convert.ToByte(Console.ReadLine());

            if (opcion_usuario == 1 || opcion_usuario == 2 || opcion_usuario == 3)
            {
                opcion_usuario = opcion_usuario - 1;
                if (opcion_usuario == 0)
                {
                    Console.Write("Usted ha seleccionado " + medios_transporte[opcion_usuario] + " como medio de transporte. La duración de su viaje a la universidad será de " + colectivo_duracion + " minutos");
                }
                if (opcion_usuario == 1)
                {
                    Console.Write("Usted ha seleccionado " + medios_transporte[opcion_usuario] + " como medio de transporte. La duración de su viaje a la universidad será de " + subte_duracion + " minutos");
                }
                if (opcion_usuario == 2)
                {
                    Console.Write("Usted ha seleccionado " + medios_transporte[opcion_usuario] + " como medio de transporte. La duración de su viaje a la universidad será de " + bicicleta_duracion + " minutos");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar una opción de transporte válida. (1, 2 o 3)");
            }

        }

        public void ejercicio5()
        {
            string[] condiciones = { "1 - Altas ", "2 - Bajas ", "3 - Modificaciones ", "4 - Salir " };

            int opcion_usuario;

            Console.WriteLine("Meú con características: ");
            Array.ForEach(condiciones, n => Console.WriteLine(n));

            Console.Write("Seleccione una opción: ");

            opcion_usuario = Convert.ToByte(Console.ReadLine());

            if (opcion_usuario == 1 || opcion_usuario == 2 || opcion_usuario == 3 || opcion_usuario == 4)
            {
                opcion_usuario = opcion_usuario - 1;

                if (opcion_usuario == 0)
                {
                    Console.WriteLine("Usted eligio la opción " + condiciones[opcion_usuario]);
                }
                if (opcion_usuario == 1)
                {
                    Console.WriteLine("Usted eligio la opción " + condiciones[opcion_usuario]);
                }
                if (opcion_usuario == 2)
                {
                    Console.WriteLine("Usted eligio la opción " + condiciones[opcion_usuario]);
                }
                if (opcion_usuario == 3)
                {
                    Console.WriteLine("Usted eligio la opción " + condiciones[opcion_usuario]);
                }
            }
            else
            {
                Console.WriteLine("La opción ingresada no es correcta");
            }
        }

        public void ejercicio8()
        {
            int numero;
            int contador = 0;
            int acumulador = 0;
            float promedio_total;
            int max_num;
            int min_num;

            List<int> numeros = new List<int>();

            Console.WriteLine("Ingrese números enteros. Escriba 0 para finalizar");

            while (true)
            {
                Console.Write("Ingrese un número: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero");
                    continue;
                }

                if (numero == 0)
                {
                    break;
                }

                numeros.Add(numero);

                contador++;
                acumulador += numero;
            }

            if (contador == 0)
            {
                Console.WriteLine("No se ingresaron números (excepto el 0 centinela).");
                return;
            }

            promedio_total = acumulador / contador;
            min_num = numeros.Min();
            max_num = numeros.Max();

            Console.WriteLine("Cantidad de números ingresados: " + contador);
            Console.WriteLine("Sumatoria de los números ingresados: " + acumulador);
            Console.WriteLine("Promedio de los números ingresados: " + promedio_total);
            Console.WriteLine("Valor mínimo ingresado: " + min_num);
            Console.WriteLine("Valor máximo ingresado: " + max_num);
        }

        public void ejercicio9B()
        {
            int acumulador = 0;
            int i;

            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Por favor ingrese un número para acumular: ");
                acumulador += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El valor total acumulado es " + acumulador + ".");
        }

        public void ejercicio9C()
        {
            string lista = "";
            int i;

            for (i = 0; i < 4; i++)
            {
                Console.Write("Ingrese un nombre para acumular: ");
                lista += Console.ReadLine() + Environment.NewLine;
            }

            Console.WriteLine("La lista de nombres es: " + Environment.NewLine + lista);
        }

        public void ejercicio10()
        {

        }

        public void ejercicio11()
        {

        }

        public void ejercicio12()
        {
            float monto;
            float acumulador = 0;
            int contador = 0;
            string condicionSalida;

            do
            {
                Console.Write("Ingrese el monto de la venta " + (contador + 1) + ": ");
                monto = Convert.ToSingle(Console.ReadLine());

                acumulador += monto;

                Console.Write("¿Desea seguir ingresando ventas? (S/N): ");
                condicionSalida = Console.ReadLine();

                contador++;

            } while (condicionSalida == "S" || condicionSalida == "s");

            Console.WriteLine("El total de sus ventas es $" + acumulador + ". Usted realizó " + contador + " ventas.");
        }
    }   
}

    


