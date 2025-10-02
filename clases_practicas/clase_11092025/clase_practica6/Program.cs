using System;

// BUBBLE SORT

string[] nombres = { "José", "Daniel", "Ana" };

int pasadas = 0;
int posicion = 0;
string adicional;

do
{
    posicion = 0;

    do
    {
        if (String.Compare(nombres[posicion], nombres[posicion +1]) > 0)
        {
            adicional = nombres[posicion];
            nombres[posicion] = nombres[posicion + 1];
            nombres[posicion + 1] = adicional;
        }
        posicion++;
    } while (posicion < nombres.Length - 1);

} while (true);