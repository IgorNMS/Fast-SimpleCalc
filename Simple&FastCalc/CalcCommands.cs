using Cocona;

public class CalcCommands
{
    [Command("add")]
    public void Add(decimal a, decimal b)
    {
        Console.WriteLine($"Result: {a + b}");
    }
    [Command("subtc")]
    public void Subtract(decimal a, decimal b)
    {
        Console.WriteLine($"Result: {a - b}");
    }
    [Command("mult")]
    public void Multiply(decimal a, decimal b)
    {
        Console.WriteLine($"Result: {a * b}");
    }
    [Command("div")]
    public void Division(decimal a, decimal b)
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
    public void LeftDivision(decimal a, decimal b)
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
