using EjercicioAbstraccion;

string? n1, n2;

Resultado operacion1 = new Resultado();

Console.WriteLine("Ingresa el primer numero:");
 n1 = Console.ReadLine();
Console.WriteLine("Ingresa el segundo numero:");
n2 = Console.ReadLine();

operacion1.N1 = double.Parse(n1);
operacion1.N2 = double.Parse(n2);

operacion1.Imprimir();




