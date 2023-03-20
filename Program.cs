using CalculadoraPOO;


Console.WriteLine("Digite o primeiro valor");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor");
double n2 = double.Parse(Console.ReadLine());

Calcular calcular = new Calcular();

Console.WriteLine("Soma: " + calcular.Somar (n1, n2));
Console.WriteLine("Subtração: " + calcular.Subtrair(n1, n2));
Console.WriteLine("Multiplicar: " + calcular.Mult(n1, n2));
Console.WriteLine("Dividir: " + calcular.Divid(n1, n2));

Console.ReadLine();



