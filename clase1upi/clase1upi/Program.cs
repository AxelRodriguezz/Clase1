using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1upi
{
    internal class Program
    {
        static void Main(string[] args)  // metodo 
        {
            int num1 = 0;
            int num2 = 0;

            float flotante = 56.23f;
            double doble = 25.36d;
            Boolean boleana = true;
            string cadena = "esto es una cadena";
            char caracter = 'a';
            string[] estudiantes = new string[] { "Axel", "Carlos", "Allan", "Jose" };
            //                                    0         1         2         3
            int[] notas = new int[3];  // vector arreglo unidimensional
            notas[0] = 100;
            notas[1] = 100;
            notas[2] = 90;
            Console.WriteLine(estudiantes.Length);

            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(estudiantes[i]);
            }

            float sumatoria = 0;
            int mayor = notas[0];
            int indice = 0;
            for (int i = 0; i < notas.Length; i++)
            {

                sumatoria += notas[i];
            }
            sumatoria /= 3;
            int contador = 0;
            while (indice < notas.Length)  // true
            {
                if (notas[indice] > sumatoria)
                {
                    contador++;
                }
                indice++;
            }


            Console.WriteLine("Promedio: " + sumatoria);
            Console.WriteLine("estudiantes con nota superior al promedio: " + contador);
            int opcion = 0;
            do
            {
              
                Console.WriteLine("1- opcion 1");
                Console.WriteLine("2- opcion 2");
                Console.WriteLine("3- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Console.WriteLine("Opcion 1 marcada"); 
                        break;
                    case 2:  Console.WriteLine("Opcion 2 marcada");
                        break;
                    case 3: break;
                    default: Console.WriteLine("*** opcion incorrecta *** ");
                        break;
                }

            } while (opcion != 3);


            Console.Read();
        }
    }
}
