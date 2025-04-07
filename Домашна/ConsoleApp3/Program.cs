namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Array.Reverse(num);

            foreach (int item in num)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
    }
}