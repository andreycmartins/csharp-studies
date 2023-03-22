using System.Runtime.Serialization;

Console.Clear();
Console.WriteLine("Qual tipo de conta deseja fazer?");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
int tipoDeConta = int.Parse(Console.ReadLine());
Console.WriteLine(tipoDeConta);

switch (tipoDeConta)
{
    case 1: Soma(); break;
    case 2: Subtracao(); break;
    case 3: Multiplicacao(); break;
    case 4: Divisao(); break;
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("O resultado da soma é: " + (v1+v2));
}
static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("O resultado da subtração é: " + (v1 - v2));
}
static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("O resultado da multiplicação é: " + (v1 * v2));
}
static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("O resultado da Divisão é: " + (v1 / v2));
}