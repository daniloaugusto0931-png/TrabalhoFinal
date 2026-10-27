using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class CardapioService
    {
        public static List<Cardapio> Cardapio { get; set; }
                = new List<Cardapio>()
                {
                new Cardapio(){ Id=1,Nome="Paulo",estrelas='*', nota= 5, comentario="blablabxcvbvssfla"},
                new Cardapio(){ Id=2,Nome="duda",estrelas='*', nota= 3, comentario="blaxcbmnbblabla"},
                new Cardapio(){ Id=3,Nome="joao",estrelas='*', nota= 4, comentario="blabvbv"},
                new Cardapio(){ Id=4,Nome="pedro",estrelas='*', nota= 5, comentario="blabhkjhla"},
                new Cardapio(){ Id=5,Nome="julia",estrelas='*', nota= 4, comentario="oiuttiorhla"},
                new Cardapio(){ Id=6,Nome="maria",estrelas='*****', nota= 5, comentario="bopa"},

                }
 };

    public static void Remover(int id)
    {
        Cardapio p = Cardapio.Find(Cardapio => Cardapio.Id == id);
        if (p != null)
        {
            Cardapio.Remove(p);
            Listar();
        }
        else
        {
            Console.WriteLine("Sistema não conseguiu encontrar o usuario");
        }
    }
    public static void Editar(int id, string novoNome, string novoEmail, DateTime novaDataNascimento)
    {
        Cardapio p = Cardapio.Find(Cardapio => Cardapio.Id == id);
        if (p != null)
        {
            p.Nome = novoNome;
            p.estrelas = estrelas;
            p.nota = nota;
            p.comentario = comentario;
            Listar();
        }
        else
        {
            Console.WriteLine("Sistema não conseguiu encontrar o usuario");
        }
    }
    public static void Adicionar(string nome
      , char estrelas
        , int nota
        , string comentario)
    {
        Cardapio avaliacao = new avaliacao();
        Cardapio.Id = avaliacao.Count > 0 ?
        Cardapio.Count + 1 : 1;
        Cardapio.Nome = nome;
        Cardapio.Estrelas = estrelas;
        Cardapio.Nota = nota;
        Cardapio.Comentario = comentario;
        Cardapio.Add(Avaliacao);
    }
    public static void Listar()
    {
        foreach (Cardapio item in Cardapio)
        {
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Nome);
            Console.WriteLine("---------------------");
        }
    }
    public static void BuscarPorId(int id)
    {

    }
}