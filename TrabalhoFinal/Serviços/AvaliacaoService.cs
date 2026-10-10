using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class AvaliacaoService
    {
        public static List<avaliacao> Lista { get; set; }
                = new List<avaliacao>()
                {
                   new avaliacao(){ id=1,nome="Paulo",estrelas='*****', nota= 5, comentario="blablabxcvbvssfla"},
                   new avaliacao(){ id=2,nome="duda",estrelas='***', nota= 3, comentario="blaxcbmnbblabla"},
                   new avaliacao(){ id=3,nome="joao",estrelas='****', nota= 4, comentario="blabvbv"},
                   new avaliacao(){ id=4,nome="pedro",estrelas='*****', nota= 5, comentario="blabhkjhla"},
                   new avaliacao(){ id=5,nome="julia",estrelas='****', nota= 4, comentario="oiuttiorhla"},
                   new avaliacao(){ id=6,nome="maria",estrelas='*****', nota= 5, comentario="bopa"},

                
    };

    private static int id()
    {
        return Lista.Count > 0 ? Lista.Max(i => i.id) + 1 : 1;
    }

    public static void Adicionar(string nome, char estrelas, int nota, string comentario)
    {
        Ingredientes ingrediente = new Ingredientes();

        ingrediente.Id = id();
        ingrediente.Nome = nome;
        ingrediente.Estrelas = estrelas;
        ingrediente.Nota = nota;
        ingrediente.Comentario = comentario;

        Lista.Add(avaliacao);

        Console.WriteLine("Comentario aberto com sucesso");
    }

    public static void Remover(int id)
    {
        avaliacao avaliacao = Lista.Find(i => i.id == id);

        if (avaliacao != null)
        {
            Lista.Remove(avaliacao);
            Console.WriteLine("comentario fechado com sucesso!");
            Listar();
        }
        else
        {
            Console.WriteLine("Sistema não conseguiu encontrar a pessoa");
        }
    }

    public static void Listar()
    {
        foreach (avaliacao item in Lista)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Id: {item:Id}");
            Console.WriteLine($"Nome: {item:Nome}");
            Console.WriteLine($"Estrelas: {item:estrelas}");
            Console.WriteLine($"Notas: {item:nota}");
            Console.WriteLine($"Comentario: {item:comentario}");
            Console.WriteLine("---------------------");
        }
    }

    public static void Editar(int id, string novoNome, char novaEstrelas, int novaNota, string Comentario)
    {
       avaliacao avaliacao = Lista.Find(i => i.id == id);

        if (avaliacao != null)
        {
            avaliacao.nome = novoNome;
            avaliacao.estrelas = novaEstrelas;
            avaliacao.nota = novaNota;

            Listar();
        }
        else
        {
            Console.WriteLine("Sistema não conseguiu encontrar o ingrediente");
        }
    }

    public static avaliacao BuscarPorId(int id)
    {
        return Lista.Find(i => i.id == id);
    }
}
}