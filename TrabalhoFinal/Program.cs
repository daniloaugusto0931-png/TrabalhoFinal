
using System;
using System.Linq;
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Models;
using TrabalhoFinal.Servicos;

Console.WriteLine("Deseja comer algum hambúrguer? (Sim/Não)");
string resposta = Console.ReadLine() ?? "";

if (resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("\nEscolha seu hambúrguer:");
    ProdutosService.Listar();

    Console.Write("\nDigite o nome do hambúrguer desejado: ");
    string nome = Console.ReadLine() ?? "";

    Produto? hamburguer = ProdutosService.Produto
        .FirstOrDefault(p => p.Nome.Equals(
            nome,
            StringComparison.OrdinalIgnoreCase));

    if (hamburguer != null)
    {
        Console.WriteLine("\nPedido realizado com sucesso!");
        Console.WriteLine("Hambúrguer escolhido: " + hamburguer.Nome);
        Console.WriteLine("Obrigado pela preferência!");
    }
    else
    {
        Console.WriteLine("\nHambúrguer não encontrado!");
        Console.WriteLine("Por favor, escolha um hambúrguer que esteja no cardápio.");
    }
}
else if (resposta.Equals("Não", StringComparison.OrdinalIgnoreCase) ||
         resposta.Equals("Nao", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Tudo bem! Obrigado pela visita.");
}
else
{
    Console.WriteLine("Resposta inválida! Digite Sim ou Não.");
}