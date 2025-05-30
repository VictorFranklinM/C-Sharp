namespace Calculadora;

public class Calculadora
{
    public static void Main(string[] args)
    {
        string op = "";
        int[]? num = { 0, 0 };
        bool[] isOk = {false, false};
        
        Console.Write("1: Soma\n2: Divisão\n3: Multiplicação\n4: Subtração\nDigite qual operação deseja realizar: ");
        while (!isOk[0])
        {
            
            try
            { 
                int opCode = int.Parse(Console.ReadLine());
                switch (opCode)
                {
                    case 1:
                        op = "soma";
                        break;
                    case 2:
                        op = "divisão";
                        break;
                    case 3:
                        op = "multiplicação";
                        break;
                    case 4:
                        op = "subtração";
                        break;
                    default:
                        throw new FormatException();
                }
                isOk[0] = true;
            }
            catch
            {
                Console.Write("A operação deve ser 1, 2, 3 ou 4. Digite novamente: ");
            }
        }

        Console.WriteLine($"Escreva os dois números para realizarem a operação de {op}:");
        while (!isOk[1])
        {
            try
            {
                Console.Write("Número 1: ");
                num[0] = int.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                num[1] = int.Parse(Console.ReadLine());
                isOk[1] = true;
            }
            catch
            {
                Console.WriteLine("Os números devem ser dois inteiros. Digite novamente:");
            }
        }

        switch (op)
        {
            case "soma":
                Console.WriteLine($"Soma de {num[0]} e {num[1]} = {num[0] + num[1]}");
                break;
            
            case "divisão":
                Console.WriteLine($"Divisão de {num[0]} e {num[1]} = {(float) num[0] / num[1]}");
                break;
            
            case "multiplicação":
                Console.WriteLine($"Multiplicação de {num[0]} e {num[1]} = {num[0] * num[1]}");
                break;
            
            case "subtração":
                Console.WriteLine($"Subtração de {num[0]} e {num[1]} = {num[0] - num[1]}");
                break;
            
            default:
                isOk[0] = false;
                break;
        }
    }
}