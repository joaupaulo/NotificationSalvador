using NotificationSalvador.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSalvador.Core.Interface
{
    public interface IFindAvailablesDateForConsultationsService
    {
        Task GetAvailables_Date_For_Consultation();
    }
}
