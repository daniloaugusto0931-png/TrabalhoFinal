using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.Dominio
{
    public class avaliacao
    {
        public int id { get; set; }
        public string nome { get; set; }
        public char estrelas { get; set; }
        public int nota { get; set; }
        public string comentario { get; set; }

    }
}
