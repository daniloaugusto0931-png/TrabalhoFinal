// See https://aka.ms/new-console-template for more information
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;
avaliacaoService.Listar();

Console.WriteLine("Digite o nome da pessoa que comentou");
string nome = Console.ReadLine();
Console.WriteLine("Digite o nome da pessoa que comentou");
char estrelas = Console.ReadLine();
int notas = Console.ReadLine();
string comentario = Console.ReadLine();
avaliacaoService.Adicionar(nome, estrelas, nota , comentario);
avaliacaoService.Listar();