// See https://aka.ms/new-console-template for more information
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;
AvaliacaoService.Listar();

Console.WriteLine("Digite o nome da pessoa que deseja cadsatrar?");
string nome = Console.ReadLine();
Console.WriteLine("Digite o nome da pessoa que deseja cadsatrar?");
char estrelas = Console.ReadLine();
int notas = Console.ReadLine();
string comentario = Console.ReadLine();
AvaliacaoService.Adicionar(nome, estrelas, nota , comentario);
AvaliacaoService.Listar();