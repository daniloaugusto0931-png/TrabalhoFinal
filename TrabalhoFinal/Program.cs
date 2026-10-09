

using System;
using TrabalhoFinal.Servicos;
using TrabalhoFinal.Dominio;

Console.WriteLine("Deseja comer algum hambúrguer? (Sim/Não)");
string resposta = Console.ReadLine() ?? "";

if (resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("\nEscolha seu hambúrguer:");

    ProdutosService.Listar();

    string nome = Console.ReadLine() ?? "";

    ProdutosService.Adicionar(nome);

    Console.WriteLine("\nPedido realizado com sucesso!");
    Console.WriteLine("Hambúrguer escolhido: " + nome);
}
else
{
    Console.WriteLine("Obrigado pela visita!");
}
