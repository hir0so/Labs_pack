using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
       // float x = float.Parse(Console.ReadLine());
       // float a = float.Parse(Console.ReadLine());
        float x = 0.85f;  
        float a = 2.34f;
        double power1 = -2 * Math.PI * a * Math.Sqrt(Math.Pow(x,2) + 1.2);
        float power2 = 3 / 2;
        float power3 = 1 / a;
        double F = Math.Pow(Math.E, power1) + 13 * Math.Pow(x,power2) + Math.Pow(x*a,power3) + Math.Log(Math.Abs(Math.Tan(x/2)));
        int power = 0;
        while (F > 10)
        { 
            F = F / 10;
            power = power + 1;
        }
        Console.WriteLine($"{F}*10^{power}");
        //Console.WriteLine($"{F}");
    }
}