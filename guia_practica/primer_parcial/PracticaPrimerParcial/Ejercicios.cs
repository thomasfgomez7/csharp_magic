using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPrimerParcial
{
    internal class Ejercicios
    {

        string[,] salidas = new string[100, 5];
        string[,] exportadores = new string[19, 2];

        // A 
        private string VerificarExportador(string nroCuit)
        {
            int fila;
            int ultimaFila = exportadores.GetLength(0);            
            string razonSocial = "";

            for (fila=0; fila < ultimaFila; fila++)
            {
                if (exportadores[fila,0] == nroCuit)
                {
                    razonSocial = exportadores[fila, 1];
                    break;
                }                
            }

            return razonSocial;                        
        }

        // Si el ejercicio hubiese pedido devolver la ubicacion
        private int BuscarExportador(string nroCuit)
        {
            int fila;
            int ultimaFila = exportadores.GetLength(0);
            int pos = -1;

            for (fila=0; fila < ultimaFila; fila++)
            {
                if (exportadores[fila, 0] == nroCuit)
                {
                    pos = fila;
                    break;
                }
            }
            
            return pos;
        }

        // Si el ejercicio hubiera pedido devolver un booleano si existe o no
        private bool ExisteExportador(string nroCuit)
        {
            int fila;
            int ultimaFila = exportadores.GetLength(0);
            bool flag = false;

            for (fila=0; fila < ultimaFila; fila++)
            {
                if (exportadores[fila, 0] == nroCuit)
                {
                    flag = true;
                    break;
                }                
            }

            return flag;
        }

        // B 
        public void AgregarSalidas()
        {
            int fila;
            int ultimaFila = salidas.GetLength(0);
            string nroCuit;
            string razonSocial;
            bool flag = false;
            string codigoContenedor;            
            string mercaderiaVendida;
            string legislacionParticular;


            for (fila=0; fila < ultimaFila; fila++)
            {
                // Valido que exista el CUIT
                do
                {
                    Console.Write("Ingrese el CUIT: ");
                    nroCuit = Console.ReadLine();
                    razonSocial = VerificarExportador(nroCuit);

                    if (String.IsNullOrEmpty(razonSocial))
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }

                } while (!flag);

                // Solicito y valido el código del contenedor 
                do
                {
                    Console.Write("Ingrese el código del contenedor: ");
                    codigoContenedor = Console.ReadLine();
                    
                    flag = ValidarVacio(codigoContenedor);

                } while (!flag);

                // Solicito y valido la mercadería vendida
                do
                {
                    Console.Write("Ingrese la mercadería vendida: ");
                    mercaderiaVendida = Console.ReadLine();

                    flag = ValidarVacio(mercaderiaVendida);

                } while (!flag);

                // Completar legislación particular
                do
                {
                    Console.Write("Requiere legislación particular (SI/NO): ");
                    legislacionParticular = Console.ReadLine();

                    flag = ValidarLegislacion(legislacionParticular);

                } while (!flag);

                // Asigno los valores a la matriz
                salidas[fila, 0] = codigoContenedor;
                salidas[fila, 1] = razonSocial;
                salidas[fila, 2] = DateTime.Now.ToString("dd/mm/yyyy");
                salidas[fila, 3] = mercaderiaVendida;
                salidas[fila, 4] = legislacionParticular;
            }          
        }

        private bool ValidarVacio(string input)
        {
            bool flag = false;

            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("El valor no puede ser vacío.");
                flag = false;
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private bool ValidarLegislacion(string legislacion)
        {
            bool flag = false; 

            if (legislacion != "SI" && legislacion != "NO")
            {
                Console.WriteLine("El campo legislación solamente acepta los valores SI/NO.");               
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        // C
        public void Legales()
        {
            int fila;
            int ultimaFila = exportadores.GetLength(0);

            string listaExportadores = "";
            
            for (fila=0; fila < ultimaFila; fila++)
            {
                if (exportadores[fila, 4] == "SI")
                {                    
                    listaExportadores += $"{exportadores[fila, 1]} - {exportadores[fila, 3]} {Environment.NewLine}";
                }
            }

            if (String.IsNullOrEmpty(listaExportadores))
            {
                Console.WriteLine("No hay contenedores que requieran legislación especial.");
            }
            else
            {
                Console.WriteLine("La lista de exportadores y mercaderías que deben reportarse al departamento de legales es: " + listaExportadores);
            }

                
        }


        // D
        public void CantidadContenedores()
        {
            int fila;
            int ultimaFila = salidas.GetLength(0);
            string nombreExportador;
            int contenedoresRegistrados = 0;
            // string listaContenedores = "";

            Console.Write("Ingrese el nombre del exportador");
            nombreExportador = Console.ReadLine();

            for (fila=0; fila < ultimaFila; fila++)
            {
                if (salidas[fila, 1] == nombreExportador)
                {
                    contenedoresRegistrados++;
                    // listaContenedores += salidas[fila, 0] + Environment.NewLine;
                }
            }

            Console.WriteLine("La cantidad de contenedores registrados es: " + contenedoresRegistrados + " contenedores.");
        }

        // E
        public void ListarAFIP()
        {
            // Filas de la matriz exportadores
            int filaE;
            int ultimaFilaE = exportadores.GetLength(0);
            
            // Fila de la matriz salidas
            int filaS;
            int ultimaFilaS = salidas.GetLength(0);

            // Variables generales
            string razonSocial;
            string legislacionEspecial;
            int contador;
            string listaExportadores = "";

            // Itera en exportadores
            for (filaE=0; filaE < ultimaFilaE; filaE++)
            {                
                contador = 0; // Resetear el contador para cada exportador
                razonSocial = exportadores[filaE, 1];

                // Itera en salidas
                for (filaS=0; filaS < ultimaFilaS; filaS++)
                {
                    if (salidas[filaS, 1] == razonSocial && salidas[filaS, 4] == "SI")
                    {
                        contador++;
                    }
                }

                if (contador > 3)
                {
                    listaExportadores += razonSocial + Environment.NewLine;
                }
            }

            if (String.IsNullOrEmpty(listaExportadores))
            {
                Console.WriteLine("No existen exportadores que cumplan esa condición");
            }
            else
            {
                Console.WriteLine("La lista de exportadores es: " + Environment.NewLine + listaExportadores);
            }
        }
    }
}
