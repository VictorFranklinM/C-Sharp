using System.Data;

namespace MediaN;

public class MediaN()
{
    public static void Main(string[] args)
    {
        int n = 0;
        int[] num;
        float media = 0;
        bool[] isOk = {false, false};

        Console.Write("Digite a quantidade de números: ");
        while (!isOk[0])
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    throw new FormatException();
                }
                isOk[0] = true;
            }
            catch
            {
                Console.Write("O número deve ser um inteiro maior que zero. Tente novamente: ");
            }
        }

        num = new int[n];
        Console.Write($"Digite {n} números: ");
        while (!isOk[1])
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                    media += num[i];
                }

                isOk[1] = true;
                media /= n;
            }
            catch
            {
                Console.Write("O número deve ser um inteiro. Tente novamente: ");
            }
        }
        
        Console.WriteLine($"A média dos números é: {media}");
    }
}