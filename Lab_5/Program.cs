class Program
{
    static void Main(string[] args)
    { 
        int a = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double F = 0;
        int decision = 0;
        if (c > 5) { decision = 1; } else {if (c < 0) { decision = 2; }}
        switch (decision) { 
            case 1:
                F = -a * Math.Pow(x,2);
            break;

            case 2:
                F = (a - x) / (c * x);
            break;

            default:
                F = x / c;
            break;
        };
        Console.WriteLine($"{F}"); // ВТОРОЙ КЕЙС НЕ РАБОТАЕТ
    } 
}