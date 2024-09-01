using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSalvador.Domain.Models
{
    public class Policlinica
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string nomePoliclinicas { get; set; }
        public int quantidadeVagas { get; set; }
        public List<AvailableDates> availableDates { get; set; }
    }
}
