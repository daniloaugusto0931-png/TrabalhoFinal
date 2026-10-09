
using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class IngredienteService
    {
        public static List<Ingredientes> Lista { get; set; }
            = new List<Ingredientes>()
            {
                new Ingredientes(){ Id=1, Nome="Pão de Hambúrguer", Quantidade=15.000, Validade=new DateTime(2027, 2, 12),   Fabrica="Bread Maker" },
                new Ingredientes(){ Id=2, Nome="Carne Bovina",      Quantidade=15.000, Validade=new DateTime(2027, 4, 13),   Fabrica="Casa de Carnes Silva / Fábrica de Hambúrguer" },
                new Ingredientes(){ Id=3, Nome="Queijo Cheddar",    Quantidade=20.000, Validade=new DateTime(2026, 12, 20),  Fabrica="Laticínios Esmeraldas" },
                new Ingredientes(){ Id=4, Nome="Alface",            Quantidade=20.000, Validade=new DateTime(2026, 11, 30),  Fabrica="NL Frutas e Legumes" },
                new Ingredientes(){ Id=5, Nome="Tomate",            Quantidade=20.000, Validade=new DateTime(2026, 12, 26),  Fabrica="NL Frutas e Legumes" },
                new Ingredientes(){ Id=6, Nome="Bacon",             Quantidade=20.000, Validade=new DateTime(2027, 2, 28),   Fabrica="Bacon BS" },
                new Ingredientes(){ Id=7, Nome="Cebola",            Quantidade=20.000, Validade=new DateTime(2026, 12, 23),  Fabrica="NL Frutas e Legumes" },
                new Ingredientes(){ Id=8, Nome="Molho Especial",    Quantidade=20.000, Validade=new DateTime(2026, 10, 10),  Fabrica="Quintal Torres" },
                new Ingredientes(){ Id=9, Nome="Presunto",          Quantidade=20.000, Validade=new DateTime(2027, 1, 19),   Fabrica="Grana pre" },
                new Ingredientes(){ Id=10, Nome="Ovo",              Quantidade=20.000, Validade=new DateTime(2026, 12, 30),  Fabrica="Rei do Ovo" }
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
            ingrediente.Fabrica = fabrica;

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
            foreach (Ingredientes item in Lista)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Quantidade: {item.Quantidade}");
                Console.WriteLine($"Validade: {item.Validade:dd/MM/yyyy}");
                Console.WriteLine($"Fábrica: {item.Fabrica}");
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
