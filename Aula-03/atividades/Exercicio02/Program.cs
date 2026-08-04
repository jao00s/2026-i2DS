internal class Program
{
    private static void Main(string[] args)
    {
        double num1;
        double num2;

        Console.Write("Digite o Primeiro Número: ");
        num1 = double.Parse(Console.ReadLine());
        
         Console.Write("Digite o segundo Número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        string operação

        case "1":
        Console.WriteLine(num1 + num2);
            break;

            case "2":
            Console.WriteLine(num1 - num2);
            break;

            case "3":
            Console.WriteLine(num1 * num2);
            break;

            case "4":
            Console.WriteLine(num1 / num2);
            break;
            default:
                Console.WriteLine("Operador informado nao é valido");
                break;



}