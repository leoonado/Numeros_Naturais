using System;

class Program{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int numero = Int32.Parse(Console.ReadLine());
        int valorToal= 0;
        for (int i=0;i<=numero;i++)
        {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    valorToal = valorToal + i;
                }
        }
        Console.WriteLine("A soma dos números naturais múltiplos de 3 e 5 é igual a " + valorToal);   
    }
    
}



