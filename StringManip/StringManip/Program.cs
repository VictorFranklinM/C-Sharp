namespace StringManip;

public class StringManip
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um nome completo: ");
        string nome = Console.ReadLine();

        nome = nome.Replace(" ", "");
        nome = nome.Replace("\n", "");
        Console.WriteLine(nome);
        
        nome = nome.ToLower();
        Console.WriteLine(nome);
        
        nome = nome.ToUpper();
        Console.WriteLine(nome);

        nome = nome.Insert(nome.Length,"Silva");
        Console.WriteLine(nome);
        
        Console.WriteLine($"Contém \"Silva\"? {nome.Contains("Silva")}");

        nome = nome.Replace("Silva", "");
        Console.WriteLine(nome);
        
        Console.WriteLine($"Tamanho do nome: {nome.Length}");
    }
}