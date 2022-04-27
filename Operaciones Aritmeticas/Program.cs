
using OperacionesAritmeticas;


Operaciones operaciones =new Operaciones();
operaciones.OperacionDiv();
operaciones.OperacionSuma();
operaciones.OperacionResta();
operaciones.OperacionMultiplicacion();

OperacionesConParametros parametros = new OperacionesConParametros();
Console.WriteLine("Escriba un numero");
var uno=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
var dos =Convert.ToDecimal(Console.ReadLine());

parametros.OperacionDiv(uno,dos);
parametros.OperacionSuma(3,4);
parametros.OperacionResta(8, 2);
parametros.OperacionMultiplicacion(6, 2);