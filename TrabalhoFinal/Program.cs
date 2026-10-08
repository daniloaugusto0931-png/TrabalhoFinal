// See https://aka.ms/new-console-template for more information
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;
avaliacaoService.Listar();

Console.WriteLine("Digite o nome do hamburguer que deseja: ");
string nome = Console.ReadLine();
ProdutosService.Adicionar(nome);
ProdutosService.Listar();int notas = Console.ReadLine();
string comentario = Console.ReadLine();
avaliacaoService.Adicionar(nome, estrelas, nota , comentario);
avaliacaoService.Listar();