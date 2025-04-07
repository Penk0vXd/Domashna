namespace ConsoleApp4
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

            int x = int.Parse(Console.ReadLine());
            
            bool namereno = false;
            int pos = -1;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == x)
                {
                    namereno = true;
                    pos = i;
                    break;
                }
            }

            if (namereno)
            {
                Console.WriteLine($"Намерен на {pos}");
            }
            else
            {
                Console.WriteLine("Не е намерен");
            }
        }
    }
}
