using System;

namespace TrabalhoFinal.Dominio
{
    public class Ingredientes
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Quantidade { get; set; }

        public DateTime Validade { get; set; }

        public string Fabrica { get; set; }
    }
}