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

            //Task 2

            Console.WriteLine("Введите имя пользователя: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите любимый язык программирования: ");
            string? PL = Console.ReadLine();

            Console.WriteLine($"Привет, {name}!\nТебе {age} лет.\nТвой любимый язык программирования: {PL}.");

            //Task 3
            Console.WriteLine("Введите коэффиценты a, b, c: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Выражение f(x) = ax^2 + bx + c с подставленными значениями = {a * Math.Pow(5,2) + b * 5 + c}");

            //Task 4
            Console.Write("Введите имя: ");
            string? name1 = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Введите город: ");
            string? city = Console.ReadLine();
            Console.Write("Введите любимое число: ");
            int FN = int.Parse(Console.ReadLine());
            Console.Write("Введите температуру в градусах Цельсия° за окном: ");
            int cel = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("=== ПЕРСОНАЛЬНЫЙ ПРОФИЛЬ ===");
            Console.WriteLine(" ");

            Console.WriteLine($"Привет, {name1}!\nТебе {age1} лет.\nВ следующем году тебе будет {age1+1}.\n\nТы живешь в городе {city}.\nТвоё любимое число: {FN} (в квадрате: {Math.Pow(FN, 2)})\n\nТемпература за окном:\n- В цельсиях: {cel}°C\n- В Фаренгейтах: {(cel * 9 / 5) + 32}\n");

            Console.WriteLine("=== КОНЕЦ ПРОФИЛЯ ===");



        }
    }
}
