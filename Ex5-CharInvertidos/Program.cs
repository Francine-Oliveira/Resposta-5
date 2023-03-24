namespace Ex5_CharInvertidos;
class Program
{
    static void Main(string[] args)
    {
        string invertida = string.Empty;
        int i;

        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        for (i = palavra.Length - 1; i >= 0; i--)
        {
            invertida += palavra[i];
        }

        Console.WriteLine("{0} ao contrário é {1}. ", palavra, invertida);

        Console.ReadKey();
    }
}

