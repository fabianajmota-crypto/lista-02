public class AtividadesCondicionais
{
   public static void Atividade01()

     {
    Console.Write("Informe a idade do visitante: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 16)
    {
        Console.WriteLine("Entrada liberada.");
    }
    else
    {
        Console.WriteLine("Entrada permitida somente com responsável.");
    }
}
        public static void Atividade02()
{
    Console.Write("Informe a nota final: ");
    double nota = Convert.ToDouble(Console.ReadLine());

    if (nota >= 7)
    {
        Console.WriteLine("Estudante aprovado.");
    }
    else if (nota >= 5)
    {
        Console.WriteLine("Estudante em recuperação.");
    }
    else
    {
        Console.WriteLine("Estudante reprovado.");
    }
}
   
        public static void Atividade03()
{
    Console.Write("Informe a temperatura ambiente: ");
    double temperatura = Convert.ToDouble(Console.ReadLine());

    if (temperatura < 15)
    {
        Console.WriteLine("Ambiente frio.");
    }
    else if (temperatura <= 25)
    {
        Console.WriteLine("Ambiente agradável.");
    }
    else
    {
        Console.WriteLine("Ambiente quente.");
    }
}
        public static void Atividade04()
{
    Console.Write("Informe o valor total da compra: ");
    double valorOriginal = Convert.ToDouble(Console.ReadLine());

    double desconto = 0;

    if (valorOriginal >= 200)
    {
        desconto = valorOriginal * 0.10;
    }

    double valorFinal = valorOriginal - desconto;

    Console.WriteLine($"Valor original: R$ {valorOriginal:F2}");
    Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}

   
   
     public static void Atividade05()
{
    Console.Write("Informe a quantidade de tarefas concluídas: ");
    int tarefas = Convert.ToInt32(Console.ReadLine());

    if (tarefas >= 50)
    {
        Console.WriteLine("Meta atingida.");
        Console.WriteLine($"Tarefas concluídas: {tarefas}");
    }
    else
    {
        int faltaram = 50 - tarefas;

        Console.WriteLine("Meta não atingida.");
        Console.WriteLine($"Faltaram {faltaram} tarefas.");
    }
}
     
        public static void Atividade06()
{
    Console.Write("Informe a idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade <= 11)
    {
        Console.WriteLine("Faixa etária: criança.");
    }
    else if (idade <= 17)
    {
        Console.WriteLine("Faixa etária: adolescente.");
    }
    else if (idade <= 59)
    {
        Console.WriteLine("Faixa etária: adulto.");
    }
    else
    {
        Console.WriteLine("Faixa etária: idoso.");
    }
}
        public static void Atividade07()
{
    Console.Write("Informe o primeiro número: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o segundo número: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero1 > numero2)
    {
        Console.WriteLine("O primeiro número é maior.");
    }
    else if (numero2 > numero1)
    {
        Console.WriteLine("O segundo número é maior.");
    }
    else
    {
        Console.WriteLine("Os números são iguais.");
    }
}
public static void Atividade08()
{
    Console.Write("Informe a primeira pontuação: ");
    int pontuacao1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe a segunda pontuação: ");
    int pontuacao2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe a terceira pontuação: ");
    int pontuacao3 = Convert.ToInt32(Console.ReadLine());

    if (pontuacao1 == pontuacao2 && pontuacao2 == pontuacao3)
    {
        Console.WriteLine("As três pontuações são iguais.");
    }
    else
    {
        int maior = pontuacao1;

        if (pontuacao2 > maior)
        {
            maior = pontuacao2;
        }

        if (pontuacao3 > maior)
        {
            maior = pontuacao3;
        }

        Console.WriteLine($"Maior pontuação: {maior}");
   }
}
 
     public static void Atividade09()
{
    Console.Write("Informe um número inteiro: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("O número informado é par.");
    }
    else
    {
        Console.WriteLine("O número informado é ímpar.");
    }
}

    public static void Atividade10()
    {
        Console.Write("Informe a idade do passageiro: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor normal da passagem: ");
        double valorNormal = double.Parse(Console.ReadLine());

        double valorAPagar;

        if (idade <= 5)
        {
            valorAPagar = 0;
        }
        else if (idade >= 60)
        {
            valorAPagar = valorNormal / 2;
        }
        else
        {
            valorAPagar = valorNormal;
        }

        Console.WriteLine($"Valor normal da passagem: R$ {valorNormal:F2}");
        Console.WriteLine($"Valor a pagar: R$ {valorAPagar:F2}");
    }

    public static void Main(string[] args)
    {
        Atividade10();
    }
} 