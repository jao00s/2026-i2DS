internal class Program
{
    private static void Main(string[] args)
    {
        double celsius;
        double fahrenheit;

        Console.Write("Digite a Temperatua em celsius: ");
        celsius = double.Parse(Console.ReadLine());

        fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("graus celsius equivalem a " + fahrenheit + " graus a fahrenheit");
    } 
}