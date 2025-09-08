namespace Lab1_HW_Zorin_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Введите первое число: ");
            int x = int.Parse(Console.ReadLine()); //a = int(input()) 
            Console.WriteLine("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            double res = x / y;
            Console.WriteLine($"{x} * {y} = {res}");
        }
    }
}
