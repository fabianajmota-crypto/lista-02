

public class Menu
{
   public static void ExibirMenuPrincipal()
    {
        int opcao = -1;

        while (opcao != 0)
        {
            Console.Clear();
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Verificação de idade para entrada em evento");
            Console.WriteLine("2 - Situação final do estudante");
            Console.WriteLine("3 -Classificação de temperatura ambiente");
            Console.WriteLine("4 - Cálculo de compra com desconto");
            Console.WriteLine("5 - Verificação de meta de produtividade");
            Console.WriteLine("6 - Classificação por faixa etária");
            Console.WriteLine("7 - Maior valor entre dois números");
            Console.WriteLine("8 - Maior valor entre três números");
            Console.WriteLine("9 - Identificação de número par ou ímpar");
            Console.WriteLine("10 - Cálculo de passagem por idade");
            Console.WriteLine("11 - Contagem progressiva");
            Console.WriteLine("12 - Contagem regressiva");
            Console.WriteLine("13 - Tabuada de um número");
            Console.WriteLine("14 - Soma e média de cinco valoreso");
            Console.WriteLine("15 - Relatório de números positivos, negativos e zero");
            Console.WriteLine("16 - Controle de acesso por senha numérica");
            Console.WriteLine("17 - Validação de nota");
            Console.WriteLine("18 - Tempo total de atendimento");
            Console.WriteLine("19 - Simulação de movimentação de caixa"); 
            Console.WriteLine("20 - Controle simples de estoque");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine()!);
            Console.Clear();
             if (opcao == 1)
            {
                AtividadesCondicionais.Atividade01();
            } 
            else if (opcao == 2)
            {
                 AtividadesCondicionais.Atividade02();
            } else if (opcao == 3)
            {
                 AtividadesCondicionais.Atividade03();
            } else if (opcao == 4)
            {
                AtividadesCondicionais.Atividade04();
            } else if (opcao ==5)
            {
                AtividadesCondicionais.Atividade05();
            } else if (opcao ==6)
            { 
                AtividadesCondicionais.Atividade06();
            } else if (opcao ==7) 
            { 
                AtividadesCondicionais.Atividade07();
            }  else if (opcao ==8)
            {
                AtividadesCondicionais.Atividade08();
            } else if (opcao ==9)
            {
                AtividadesCondicionais.Atividade09();
            } else if (opcao ==10)
            {
            
              AtividadesCondicionais.Atividade10();
            } else if (opcao ==11)
            {
                AtividadesRepeticao.Atividade11();
            } 
             Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        Console.Clear();

        }

    }

}

