namespace MaiorMenor;

public class MaiorMenor
{
    public static void Main(string[] args)
    {
        int[] num = {0, 0, 0};
        int maior = 0;
        bool isOk = false;

        Console.Write("Digite 3 números inteiros: ");
        while (!isOk)
        {
            try
            {
                num[0] = int.Parse(Console.ReadLine());
                num[1] = int.Parse(Console.ReadLine());
                num[2] = int.Parse(Console.ReadLine());
                isOk = true;
            }
            catch
            {
                Console.Write("Todos os números devem ser inteiros. Tente novamente: ");
            }
        }

        for (int i = 0; i < num.Length; i++)
        {
            if (i == 0)
            {
                maior = num[0];
            }

            if (maior < num[i])
            {
                maior = num[i];
            }
        }

        Console.WriteLine($"Maior número: {maior}.");
    }
}