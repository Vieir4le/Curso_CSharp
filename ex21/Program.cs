namespace ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Melão", "Abacaxi", "Graviola", "Pessêgo", "Morango", "Uva", "Caju", "Maça", "Banana", "Maracúja" };
            double[] reais = { 10.00, 8.00, 12.00, 11.00, 5.00, 10.00, 20.00, 9.00, 4.00, 12, 00 };

            for (int i = 0; i < frutas.Length; i++)
                Console.WriteLine("O valor da Fruta " + frutas[i] + " R$" + reais[i]);

            double reais_maior = reais.Max();
            double reais_menor = reais.Min();

            Console.WriteLine(" O maior valor da fruta é: " + reais_maior);
            Console.WriteLine(" O menor valor da fruta é: " + reais_menor);

            string fruta_primeiro = frutas.Max();
            string fruta_último = frutas.Min();

            Console.WriteLine("A Primeira fruta  em ordem alfabética é: " + fruta_último);
            Console.WriteLine("A última fruta  em ordem alfabética é: " + fruta_primeiro);
            Console.WriteLine();

            


        }
    }
}
