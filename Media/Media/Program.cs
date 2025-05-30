namespace Media;

public class Media()
{
    public static void Main(string[] args)
    {
        int[] num = { 0, 0 };
        float media = 0;
        bool isOk = false;

        Console.Write("Escreva dois números inteiros: ");
        while (!isOk)
        {
            try
            {
                num[0] = int.Parse(Console.ReadLine());
                num[1] = int.Parse(Console.ReadLine());
                isOk = true;
            }
            catch
            {
                Console.Write("O número deve ser um inteiro. Tente novamente: ");
            }
        }

        media = (float) (num[0] + num[1]) / 2;
        Console.WriteLine($"A média dos números {num[0]} e {num[1]} é: {media}");
    }
}