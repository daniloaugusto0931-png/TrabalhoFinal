
using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class IngredienteService
    {
        public static List<Ingredientes> Ingredientes { get; set; }
            = new List<Ingredientes>()
            {
                new Ingredientes(){ Id=1, Nome="Pão de Hambúrguer", Quantidade=15.000, Validade=12/02/2027, Fabrica="Bread Maker"},
                new Ingredientes(){ Id=2, Nome="Carne Bovina", Quantidade= 15.000, Validade=13/04/2027,Fabrica="Casa de Carnes Silva / Fábrica de Hambúrguer" },
                new Ingredientes(){ Id=3, Nome="Queijo Cheddar", Quantidade= 20.000, Validade=20/12/2026, Fabrica="Laticínios Esmeraldas",},
                new Ingredientes(){ Id=4, Nome="Alface", Quantidade=20.000, Validade=30/11/2026, Fabrica = "NL Frutas e Legumes" },
                new Ingredientes(){ Id=5, Nome="Tomate", Quantidade=20.000, Validade=26/12/2026, Fabrica = "NL Frutas e Legumes" },
                new Ingredientes(){ Id=6, Nome="Bacon", Quantidade=20.000, Validade=31/02/2027, Fabrica = "Bacon BS"},
                new Ingredientes(){ Id=7, Nome="Cebola", Quantidade=20.000, Validade=23/12/2026, Fabrica = "NL Frutas e Legumes"},
                new Ingredientes(){ Id=8, Nome="Molho Especial", Quantidade=20.00, Validade=10/10/2026, Fabrica ="Quintal Torres" },
                new Ingredientes(){ Id=9, Nome="Presunto", Quantidade=20.000, Validade=19/01/2027, Fabrica ="Grana pre" },
                new Ingredientes(){ Id=10, Nome="Ovo", Quantidade=20.000, Validade=30/12/2026,  Fabrica ="Rei do Ovo"}
            };

        public static void Adicionar(string nome)
        {
            Ingredientes ingrediente = new Ingredientes();

            ingrediente.Id = Ingredientes.Count > 0
                ? Ingredientes.Max(p => p.Id) + 1
                : 1;

            ingrediente.Nome = nome;

            Ingredientes.Add(ingrediente);
        }

        public static void Listar()
        {
            foreach (Ingredientes item in Ingredientes)
            {
                Console.WriteLine(item.Nome);
            }
        }
        public static void Editar(int id)
        {
            Ingredientes p = Ingredientes.Find(pessoa => pessoa.Id == id);

        }

    }
}

