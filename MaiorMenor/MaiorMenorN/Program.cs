namespace MaiorMenorN;

public class MaiorMenorN
{
    public static void Main(string[] args)
    {
        int n = 0;
        int maior = 0;
        bool[] isOk = {false, false};

        Console.Write("Digite a quantidade de números a serem lidos: ");
        while (!isOk[0])
        {
            try
            {
                n = int.Parse(Console.ReadLine().Replace("\n", ""));
                if (n <= 0)
                {
                    throw new FormatException();
                }
                isOk[0] = true;
            }
            catch (Exception e)
            {
                Console.Write("Valor inválido. Tente novamente: ");
            }
        }

        int[] num = new int[n];
        
        Console.Write($"Digite {n} números: ");
        while (!isOk[1])
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    num[i] = int.Parse(Console.ReadLine().Replace("\n", ""));
                }

                isOk[1] = true;
            }
            catch
            {
                Console.Write("Os números devem ser inteiros. Tente novamente: ");
            }
        }

        for (int i = 0; i < n; i++)
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