namespace Task2
{
    internal class Program
    {
        public delegate int CalcDelegate(int x, int y);

        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiple(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if (y != 0)
                return x / y;
            return -1;
        }

        static void Main(string[] args)
        {
            int num1;
            do
            {
                Console.Write("Enter First Number: ");
            } while (!int.TryParse(Console.ReadLine(), out num1));

            int num2;
            do
            {
                Console.Write("Enter Second Number: ");
            } while (!int.TryParse(Console.ReadLine(), out num2));

            char[] ops = ['+', '-', '*', '/'];
            char op;
            do
            {
                Console.Write("Enter Operation Type(+,-,*,/): ");
            } while (!char.TryParse(Console.ReadLine(), out op) || !ops.Contains(op));

            CalcDelegate calcDelegate = op switch
            {
                '+' => Sum,
                '-' => Subtract,
                '*' => Multiple,
                '/' => Divide,
            };

            Console.WriteLine($"Result = {calcDelegate(num1, num2)}");
        }
    }
}
