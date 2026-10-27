
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Infraestrutura;

namespace TrabalhoFinal.Servicos
{
    public static class IngredienteService
    {
        private static string fabricante;

        public static List<Ingredientes> Lista { get; set; }
            = new List<Ingredientes>()
            {
                new Ingredientes(){ Id=1, Nome="Pão de Hambúrguer", Quantidade=15.000, Validade=new DateTime(2027, 02, 12),  Fabricante="Bread Maker" },
                new Ingredientes(){ Id=2, Nome="Carne Bovina",      Quantidade=15.000, Validade=new DateTime(2027, 04, 13),  Fabricante="Casa de Carnes Silva / Fábrica de Hambúrguer" },
                new Ingredientes(){ Id=3, Nome="Queijo Cheddar",    Quantidade=20.000, Validade=new DateTime(2026, 12, 20),  Fabricante="Laticínios Esmeraldas" },
                new Ingredientes(){ Id=4, Nome="Alface",            Quantidade=20.000, Validade=new DateTime(2026, 11, 30),  Fabricante="NL Frutas e Legumes" },
                new Ingredientes(){ Id=5, Nome="Tomate",            Quantidade=20.000, Validade=new DateTime(2026, 12, 26),  Fabricante="NL Frutas e Legumes" },
                new Ingredientes(){ Id=6, Nome="Bacon",             Quantidade=20.000, Validade=new DateTime(2027, 02, 28),  Fabricante="Bacon BS" },
                new Ingredientes(){ Id=7, Nome="Cebola",            Quantidade=20.000, Validade=new DateTime(2026, 12, 23),  Fabricante="NL Frutas e Legumes" },
                new Ingredientes(){ Id=8, Nome="Molho Especial",    Quantidade=20.000, Validade=new DateTime(2026, 10, 10),  Fabricante="Quintal Torres" },
                new Ingredientes(){ Id=9, Nome="Presunto",          Quantidade=20.000, Validade=new DateTime(2027, 01, 19),  Fabricante="Grana pre" },
                new Ingredientes(){ Id=10, Nome="Ovo",              Quantidade=20.000, Validade=new DateTime(2026, 12, 30),  Fabricante="Rei do Ovo" }
            };

        private static int Id()
        {
            return Lista.Count > 0 ? Lista.Max(i => i.Id) + 1 : 1;
        }

        public static void Adicionar(string nome, double quantidade, DateTime validade, string fabrica)
        {
            Ingredientes ingrediente = new Ingredientes();

            ingrediente.Id = Id();
            ingrediente.Nome = nome;
            ingrediente.Quantidade = quantidade;
            ingrediente.Validade = validade;
            ingrediente.Fabricante = fabricante;

            Lista.Add(ingrediente);

            Console.WriteLine("Ingrediente adicionado com sucesso!");
        }

        public static void Remover(int id)
        {
            Ingredientes ingrediente = Lista.Find(i => i.Id == id);

            if (ingrediente != null)
            {
                Lista.Remove(ingrediente);
                Console.WriteLine("Ingrediente removido com sucesso!");
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o ingrediente");
            }
        }

        public static void Listar()
        {
            foreach (Ingredientes item in IngredienteRepository.Listar())
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Quantidade: {item.Quantidade}");
                Console.WriteLine($"Validade: {item.Validade:dd/MM/yyyy}");
                Console.WriteLine($"Fabricante: {item.Fabricante}");
                Console.WriteLine("---------------------");
            }
        }

        public static void Editar(int id, string novoNome, double novaQuantidade, DateTime novaValidade)
        {
            Ingredientes ingrediente = Lista.Find(i => i.Id == id);

            if (ingrediente != null)
            {
                ingrediente.Nome = novoNome;
                ingrediente.Quantidade = novaQuantidade;
                ingrediente.Validade = novaValidade;

                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o ingrediente");
            }
        }

        public static Ingredientes BuscarPorId(int id)
        {
            return Lista.Find(i => i.Id == id);
        }
    }
}
