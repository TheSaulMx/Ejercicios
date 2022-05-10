using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor: Saúl Contreras
/// Fecha: 06/05/22
/// Ejercicio: En un equipo de basquet bol vas anotar la cantidad de puntos que anoto cada jugador y depues los vas  a ordenar de mayor a menor (5 jugadores)
/// </summary>

namespace Arrays
{
    public class EP3
    {
        public EP3()
        {
            Console.WriteLine("En un equipo de basquetbol vas anotar la cantidad de puntos que anoto cada jugador y depues los vas  a ordenar de mayor a menor (5 jugadores)");
            Console.WriteLine();
        }
        public string[,] ObtenerDatos()
        {

            string[,] jugadores = new string[5, 2];

            //jugadores[0, 0] = "M. Jordan";
            //jugadores[1, 0] = "L. James";
            //jugadores[2, 0] = "K. Durant";
            //jugadores[3, 0] = "K. Love";
            //jugadores[4, 0] = "K. Bryant";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"¿Nombre del jugador {jugadores[i, 0]}? ");
                jugadores[i, 0] = Console.ReadLine();
                Console.WriteLine($"¿Cuantos puntos anotó {jugadores[i, 0]}? ");
                jugadores[i, 1] = Console.ReadLine();
                //jugadores[i, 1] = puntos;
                //Console.WriteLine();
            }

            return jugadores;
        }

        public void MarcadorFinal(string[,] puntajes)
        {
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{puntajes[i, 0]} anoto: ");
                Console.WriteLine($"{puntajes[i, 1]} puntos");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("La tabla de posiciones es: ");
            Console.WriteLine();

            //int[] tablero = new int[5];

            //puntajes[0, 1] = puntajes[0, 1];
            //puntajes[1, 1] = puntajes[1, 1];
            //tablero[2] = Convert.ToInt16(puntajes[2, 1]);
            //tablero[3] = Convert.ToInt16(puntajes[3, 1]);
            //tablero[4] = Convert.ToInt16(puntajes[4, 1]);

            //Array.Reverse(tablero);

            //for (int i = 0; i < tablero.Length; i++)
            //{
            //    Console.WriteLine(tablero[i]);
            //    Console.WriteLine();
            //}
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(String.Format("El jugador {0} anto {1}",puntajes[i,0], puntajes[i, 1]));
            }
            Console.ReadKey();


        }
        ///Escribir un array x cantidad de numeros y ordenarlos de mayor a menor
        public void CreaMarcadores(string[,] puntajes)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                int valorAnterior;
                string jugadorAnterior;
                var lista = puntajes as List<string>;
                lista.OrderBy()
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 4; i++) //michael jordan 
                    {
                        int nombreActual = Convert.ToInt32(puntajes[i, 0]);
                        int puntajeActual = Convert.ToInt32(puntajes[i, 1]);
                        int puntajeCompetencia = Convert.ToInt32(puntajes[i + 1, 1]);
                        //int puntajeCompetenciaNombre =Convert.ToInt32(puntajes[i+1, 0]);
                        if (puntajeActual < puntajeCompetencia)
                        {

                            puntajes[i, 0] = puntajes[i + 1, 0];
                            puntajes[i, 1] = puntajes[i + 1, 1];

                            //escribimos el dato actual a la posicion j
                            puntajes[i + 1, 0] = nombreActual.ToString();
                            puntajes[i + 1, 1] = puntajeActual.ToString();
                        }
                    }
                }


                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(String.Format("El jugador {0} anto {1}", puntajes[i, 0], puntajes[i, 1]));
                }
                timer.Stop();
                Console.WriteLine(timer.Elapsed);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
