using Cocona;

public class CalcCommands
{
    [Command("add")]
    public void Add(int a, int b)
    {
        Console.WriteLine($"Result: {a + b}");
    }
    [Command("subtc")]
    public void Subtract(int a, int b)
    {
        Console.WriteLine($"Result: {a - b}");
    }
    [Command("mult")]
    public void Multiply(int a, int b)
    {
        Console.WriteLine($"Result: {a * b}");
    }
    [Command("div")]
    public void Division(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("You can't divide by zero bro.");
        }
        else
        {
            Console.WriteLine($"Result: {a / b}");
        }
    }
    [Command("rdiv")]
    public void LeftDivision(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("You can't divide by zero bro.");
        }
        else
        {
            Console.WriteLine($"Result: {a % b}");
        }
    }
}
