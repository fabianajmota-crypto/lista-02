using System;

public class AtividadesRepeticao
{
    public static void Atividade11()
    {
        Console.Write("Informe o número final da contagem: ");
        int numeroFinal = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroFinal; i++)
        {
            Console.WriteLine(i);
        }
    }
} 
public class AtividadeRepeticao
{
    public static void Atividade11()
    {
        Console.Write("Informe o número final da contagem: ");
        int numeroFinal = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroFinal; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Atividade12()
    {
        Console.Write("Informe o número inicial da contagem regressiva: ");
        int numeroInicial = int.Parse(Console.ReadLine());

        for (int i = numeroInicial; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");
    }

    

 public static void Atividade13()
    {
        Console.Write("Informe o número da tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
 
 public static void Atividade14()

