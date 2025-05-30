namespace Media;

public class MediaPonderada()
{
    public static void Main(string[] args)
    {
        int[] num = { 0, 0 };
        int[] peso = { 0, 0 };
        float media = 0;
        bool isOk = false;

        Console.WriteLine("Escreva dois números inteiros e seus pesos: ");
        while (!isOk)
        {
            try
            {
                Console.Write("Primeiro número: ");
                num[0] = int.Parse(Console.ReadLine());
                    
                Console.Write($"Escreva o peso do {num[0]}: ");
                peso[0] = int.Parse(Console.ReadLine());
                
                Console.Write("Escreva o segundo número: ");    
                num[1] = int.Parse(Console.ReadLine());
                
                Console.Write($"Escreva o peso do {num[1]}: ");
                peso[1] = int.Parse(Console.ReadLine());
                    
                isOk = true;
            }
            catch 
            {
                Console.WriteLine("O número deve ser um inteiro. Tente novamente: ");
            }
        }

        media = (float) (num[0]*peso[0] + num[1]*peso[1]) / (peso[0] + peso[1]);
        Console.WriteLine($"A média dos números {num[0]}, com peso {peso[0]}, e {num[1]}, com peso {peso[1]}, é: {media}");
    }
}