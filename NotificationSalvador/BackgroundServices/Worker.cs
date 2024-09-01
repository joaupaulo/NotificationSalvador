using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NotificationSalvador.Core.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NotificationSalvador.BackgroundServices
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IFindAvailablesDateForConsultationsService _findAvailablesDateForConsultationsService;
        public Worker(ILogger<Worker> logger, IFindAvailablesDateForConsultationsService findAvailablesDateForConsultationsService)
        {
            _logger = logger;
            _findAvailablesDateForConsultationsService = findAvailablesDateForConsultationsService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                await _findAvailablesDateForConsultationsService.GetAvailables_Date_For_Consultation();

                await Task.Delay(TimeSpan.FromHours(12), stoppingToken);

            }
        }
    }

}
