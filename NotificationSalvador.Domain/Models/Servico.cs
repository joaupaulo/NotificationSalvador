using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSalvador.Domain.Models
{
    public class Servico
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Agendamento { get; set; }
        public string NomeOrgao { get; set; }
        public bool Favorito { get; set; }
        public string CodigoCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string PalavrasChave { get; set; }
        public string Icone { get; set; }
        public string Cor { get; set; }
        public List<string> Plataformas { get; set; }
        public int NivelAcesso { get; set; }
        public string Digitizado { get; set; }
        public string OndeDigitizado { get; set; }
        public string SlugServico { get; set; }
        public string SlugOrgao { get; set; }
    }

}
