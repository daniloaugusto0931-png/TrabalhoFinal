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
    , string email
    , DateTime data_nascimento)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Id = Pessoas.Count > 0 ?
            Pessoas.Count + 1 : 1;
        pessoa.Nome = nome;
        pessoa.Email = email;
        pessoa.Data_Nascimento = data_nascimento;
        Pessoas.Add(pessoa);
    }
    public static void Listar()
    {
        foreach (Pessoa item in Pessoas)
        {
            Console.WriteLine(item.Nome);
        }
}