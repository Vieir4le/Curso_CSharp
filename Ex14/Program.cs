namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite o valor da tabuada");
            num = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(" {0} x {1} = {2}", num, i, num * 1);
            }
        }
    }
}
