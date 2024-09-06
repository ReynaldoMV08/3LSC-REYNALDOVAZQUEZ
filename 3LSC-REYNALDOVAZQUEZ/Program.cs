// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        const int capacidad = 10;
        List<int> elementos = new List<int>(new int[capacidad]);
        int cima = -1;
        Console.WriteLine("Tecla elemento de la pila (termina con -1)");

        int x = 0;
        const int CLAVE = -1;

        while (x != CLAVE)
        {
            string entrada = Console.ReadLine();
            try
            {
                x = int.Parse(entrada); // Convertimos de cadena a entero
                if (cima < capacidad - 1)
                {
                    cima++;
                    if (cima >= elementos.Count)
                    {
                        elementos.Add(x);
                    }
                    else
                    {
                        elementos[cima] = x;
                    }
                }
                else
                {
                    Console.WriteLine("Pila llena");
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida");
            }
        }

        if (cima >= 0)
        {
            Console.WriteLine("Elementos de la pila");
            while (cima >= 0)
            {
                x = elementos[cima];
                cima--;
                Console.Write(x + " ");
            }
        }
        else
        {
            Console.WriteLine("Pila vacía");
        }
    }
}