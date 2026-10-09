
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Servicos
{
    public class ProdutosService
    {


        public static List<Produto> Produto { get; set; } = new List<Produto>()
        {
            new Produto() { Id = 1, Nome = "X-Duplo-cheddar" },
            new Produto() { Id = 2, Nome = "X-Básico" },
            new Produto() { Id = 3, Nome = "X-Bacon" },
            new Produto() { Id = 4, Nome = "X-Salada" },
            new Produto() { Id = 5, Nome = "X-tradicional" },
            new Produto() { Id = 6, Nome = "Triplo-Cheddar" },
            new Produto() { Id = 7, Nome = "X-Duplo-Bacon" },
            new Produto() { Id = 8, Nome = "X-Cheddar" },
            new Produto() { Id = 9, Nome = "X-kids" },
            new Produto() { Id = 10, Nome = "Hamburguer-de-Siri" }
        };
        public static void Remover(int id)
        {
            Produto p = Produto.Find(produto => produto.Id == id);
            if (p != null)
            {
                Produto.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o hamburguer");
            }
        }
        public static void Editar(int id, string novoNome, string novoEmail, DateTime novaDataNascimento)
        {
            Produto p = Produto.Find(produto => produto.Id == id);
            if (p != null)
            {
                p.Nome = novoNome;
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o hamburguer.");
            }
        }
        public static void Adicionar(string nome)
            
        {
            Produto produto = new Produto();
            produto.Id = Produto.Count > 0 ?
                Produto.Count + 1 : 1;
            produto.Nome = nome;
            
           
            Produto.Add(produto);
        }
        public static void Listar()
        {
            foreach (Produto item in Produto)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}

