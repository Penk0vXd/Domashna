namespace Домашна
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
