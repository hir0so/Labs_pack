class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите температуру в градусах по Цельсию: ");
        int celsius = int.Parse(Console.ReadLine());
        int kelvins = celsius + 273;
        Console.WriteLine($"{celsius} градусов по Цельсию = {kelvins} градусов по Кельвину");
    }

};