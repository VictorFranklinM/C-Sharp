namespace ParImpar;

public class ParImpar
{   
    public static void Main(string[] args)
    {
        int num = 0;
        bool isOk = false;
        
        Console.Write("Digite um número inteiro: ");
        while (!isOk)
        {
            try
            {
                num = int.Parse(Console.ReadLine());
                isOk = true;
            }
            catch
            {
                Console.Write("O caractere deve ser um inteiro. Digite novamente: ");
            }
        }
        
        if (num % 2 == 0)
        {
            Console.WriteLine($"O número {num} é par.");
        }
        else
        {
            Console.WriteLine($"O número {num} é ímpar.");
        }
    }
}
