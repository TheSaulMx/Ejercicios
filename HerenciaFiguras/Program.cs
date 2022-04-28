using HerenciaFiguras;

Cuadrado cuadro = new Cuadrado();
cuadro.Camina();
cuadro.nombreFigura("Cuadrado");
cuadro.numeroLados(4);
cuadro.Area(8,8);
cuadro.Perimetro(8,8);

Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine();

Triangulo triangulo = new Triangulo();
triangulo.Corre();
triangulo.nombreFigura("Triángulo");
triangulo.numeroLados(3);
triangulo.Area(10,5);
triangulo.Perimetro(10,5);

Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine();

Rectangulo rectangulo = new Rectangulo();
rectangulo.Vuela();
rectangulo.nombreFigura("Rectángulo");
rectangulo.numeroLados(4);
rectangulo.Area(10, 5);
rectangulo.Perimetro(10, 5);