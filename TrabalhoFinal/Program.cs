
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;
ProdutosService.Listar();

Console.WriteLine("Digite o nome do hamburguer que deseja: ");
string nome = Console.ReadLine();
ProdutosService.Adicionar(nome);
ProdutosService.Listar();