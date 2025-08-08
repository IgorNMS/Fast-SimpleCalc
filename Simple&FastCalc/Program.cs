Console.WriteLine("Calculadora Simples e rapida.");
Console.WriteLine("Digite o primeiro numero");
var primeiroNumero = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
var segundoNumero = int.Parse(Console.ReadLine());
Console.WriteLine("Qual e a operação? ");
Console.WriteLine("Adição: A");
Console.WriteLine("Subtração: B");
Console.WriteLine("Multiplicação: C");
Console.WriteLine("Divisão: D");
Console.WriteLine("Resto da Divisão: E");
var opt = Console.ReadLine();

switch (opt)
{
    case "A":
        Console.WriteLine($"Resultado: {primeiroNumero + segundoNumero}");
        break;
    case "B":
        Console.WriteLine($"Resultado: {primeiroNumero - segundoNumero}");
        break;
    case "C":
        Console.WriteLine($"Resultado: {primeiroNumero * segundoNumero}");
        break;
    case "D":
        if (segundoNumero == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida."); Console.WriteLine("Tente novamente com outro número.");
        }
        else
        {
            Console.WriteLine($"Resultado: {primeiroNumero / segundoNumero}");
        }
        break;
    case "E":
        if (segundoNumero == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida."); Console.WriteLine("Tente novamente com outro número.");
        }
        else
        {
            Console.WriteLine($"Resultado: {primeiroNumero % segundoNumero}");
        }
        break;
    default:
        Console.WriteLine("Operação inválida. Por favor, escolha A, B, C, D ou E.");
        break;
}
Console.ReadKey();
