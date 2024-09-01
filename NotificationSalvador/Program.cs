using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NotificationSalvador.BackgroundServices;
using NotificationSalvador.Core;
using NotificationSalvador.Core.Interface;

var host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
{
    services.AddHealthChecks();
    services.AddHostedService<Worker>();
    services.AddHttpClient();
    services.AddLogging();
    services.AddSingleton<IFindAvailablesDateForConsultationsService, FindAvailablesDateForConsultationsService>();
}).
ConfigureWebHostDefaults(webBuilder => webBuilder.Configure(webBuilder =>

webBuilder.UsePathBase("/notification-salvador").
 UseRouting().
 UseEndpoints(endpoints =>
{
    endpoints.MapHealthChecks("/health");
})

)).Build();


await host.RunAsync();
