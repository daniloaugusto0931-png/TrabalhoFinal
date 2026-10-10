

using System.Globalization;
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;


namespace TrabalhoFinal.Views
{
    public static class IngredientesView
    {
        public static void Adicionar()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("     CADASTRO DE INGREDIENTES");
            Console.WriteLine("==================================");

            string nome;

            do
            {
                Console.Write("Digite o nome do ingrediente: ");
                nome = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("O nome não pode ficar vazio!");
                }

            } while (string.IsNullOrWhiteSpace(nome));

            double quantidade;

            while (true)
            {
                Console.Write("Digite a quantidade: ");
                string entrada = Console.ReadLine() ?? "";

             
                entrada = entrada.Replace(',', '.');

                if (double.TryParse(
                    entrada,
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out quantidade) && quantidade > 0)
                {
                    break;
                }

                Console.WriteLine(
                    "Quantidade inválida! Digite um número maior que zero.");
            }

            DateTime validade;

            while (true)
            {
                Console.Write("Digite a validade (dd/MM/yyyy): ");
                string entrada = Console.ReadLine() ?? "";

                if (DateTime.TryParseExact(
                    entrada,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out validade))
                {
                    break;
                }

                Console.WriteLine(
                    "Data inválida! Use o formato dd/MM/yyyy.");
            }

            string fabrica;

            do
            {
                Console.Write("Digite o nome da fábrica: ");
                fabrica = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(fabrica))
                {
                    Console.WriteLine(
                        "O nome da fábrica não pode ficar vazio!");
                }

            } while (string.IsNullOrWhiteSpace(fabrica));

            IngredienteService.Adicionar(
                nome,
                quantidade,
                validade,
                fabrica
            );

            Console.WriteLine();
            Console.WriteLine("Ingrediente cadastrado com sucesso!");
        }

        public static void Listar()
        {
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("       LISTAGEM DE INGREDIENTES");
            Console.WriteLine("==================================");

            if (IngredienteService.Lista.Count == 0)
            {
                Console.WriteLine("Nenhum ingrediente cadastrado.");
                return;
            }

            foreach (Ingredientes item in IngredienteService.Lista)
            {
                ImprimirIngrediente(
                    item.Id,
                    item.Nome,
                    item.Quantidade,
                    item.Validade,
                    item.Fabrica
                );
            }
        }

        public static void ImprimirIngrediente(
            int id,
            string nome,
            double quantidade,
            DateTime validade,
            string fabrica)
        {
            int largura = 45;

            Console.WriteLine(new string('-', largura + 2));

            Console.WriteLine(
                "|" + AjustarTexto($" ID         : {id}", largura) + "|");

            Console.WriteLine(
                "|" + AjustarTexto($" Nome       : {nome}", largura) + "|");

            Console.WriteLine(
                "|" + AjustarTexto(
                    $" Quantidade : {quantidade:0.###}",
                    largura) + "|");

            Console.WriteLine(
                "|" + AjustarTexto(
                    $" Validade   : {validade:dd/MM/yyyy}",
                    largura) + "|");

            Console.WriteLine(
                "|" + AjustarTexto($" Fábrica    : {fabrica}", largura) + "|");

            Console.WriteLine(new string('-', largura + 2));
        }

        private static string AjustarTexto(string texto, int largura)
        {
            if (texto.Length > largura)
            {
                texto = texto.Substring(0, largura - 3) + "...";
            }

            return texto.PadRight(largura);
        }
    }
}
