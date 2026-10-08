using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class AvaliacaoService
    {
        public static List<avaliacao> avaliacao { get; set; }
                = new List<avaliacao>()
                {
                new avaliacao(){ Id=1,Nome="Paulo",estrelas='*****', nota= 5, comentario="blablabxcvbvssfla"},
                new avaliacao(){ Id=2,Nome="duda",estrelas='***', nota= 3, comentario="blaxcbmnbblabla"},
                new avaliacao(){ Id=3,Nome="joao",estrelas='****', nota= 4, comentario="blabvbv"},
                new avaliacao(){ Id=4,Nome="pedro",estrelas='*****', nota= 5, comentario="blabhkjhla"},
                new avaliacao(){ Id=5,Nome="julia",estrelas='****', nota= 4, comentario="oiuttiorhla"},
                new avaliacao(){ Id=6,Nome="maria",estrelas='*****', nota= 5, comentario="bopa"},

                }
 };
    public static void Adicionar(string nome
    , char Estrelas
    ,  int nota,
        string comentario)
    {
        Avaliacao Avaliacao = new Avaliacao();
        Avaliacao.Id = Avaliacao.Count > 0 ?
             Avaliacao.Count + 1 : 1;
        Avaliacao.Nome = nome;
        Avaliacao.Estrelas = estrelas;
        Avaliacao.Nota = nota;
        Avaliacao.Comentario = comentario;
        Avaliacao.Add(Avaliacao);
    }
    public static void Listar()
    {
        foreach (Avaliacao item in Avaliacao)
        {
            Console.WriteLine(item.Nome);
        }
}