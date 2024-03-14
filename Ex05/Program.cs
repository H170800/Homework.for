namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập n: ");

            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            if (n < 0 || n >= 100)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / (i * i);
                }
                Console.WriteLine($"{Math.Round(sum, 5)}");
            }
        }
    }
}