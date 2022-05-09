
using Arrays;

namespace Selector
{
     class SelectorEjercicos
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Qué ejercicio desea consultar?");
            int respuesta = Convert.ToInt16(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    EP1 alumnos = new EP1();

                    alumnos.PedirNombre();
                    alumnos.ImprimirLista();
                    break;

                case 2:
                    EP2 arreglo = new EP2();

                    var setInfo = arreglo.SetInfo();
                    arreglo.GetInfo(setInfo);
                    break;

                case 3:
                    EP3 marcador = new EP3();

                    var marcadorFinal = marcador.ObtenerDatos();
                    marcador.MarcadorFinal(marcadorFinal);
                    break;

                case 4:
                    EP4 lista = new EP4();

                    List<string> listaPeliculas = lista.ListaPeliculas();
                    lista.Agregar(listaPeliculas);
                    break;

                default:
                    Console.WriteLine("Bye!");
                    break;
            }

        }

    }

}


////1 En un arreglo de 10 alumnos vas a pedir los nombre de cada uno de ellos usando un metodo recursivo y al final los vas mostrar
//EP1 alumnos = new EP1();
////alumnos.PedirNombre();
////alumnos.ImprimirLista();

////2 En un metodo bidimensional vas a pedir nombre y edades de cada uno de los alumnos y los vas a mostrar (5 alumnos)

//EP2 arreglo = new EP2();

////var setInfo = arreglo.SetInfo();
////arreglo.GetInfo(setInfo);

////3 En un equipo de basquet bol vas anotar la cantidad de puntos que anoto cada jugador y depues los vas  aordenar de mayor a menor (5 jugadores)

//EP3 marcador = new EP3();

////var marcadorFinal = marcador.ObtenerDatos();
////marcador.MarcadorFinal(marcadorFinal);


////4 En una lista guardar un catalogo de peliculas despues de 5 peliculas tendras que agregar dos mas y mostrar la primera y la ultima pelicula 

//EP4 lista = new EP4();

////List<string> listaPeliculas = lista.ListaPeliculas();
////lista.Agregar(listaPeliculas);

