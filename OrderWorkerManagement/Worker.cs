using System.Text.Json;
using OrderWorkerManagement.Domain.Entities;
using OrderWorkerManagement.Domain.Enums;

namespace OrderWorkerManagement;

public class Worker(ILogger<Worker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (logger.IsEnabled(LogLevel.Information))
            {

                Order order = new Order();

                order.EntityType = EntityType.CANDIDATE;
                order.OperationType = OperationType.CREATE;
                order.Status = OrderStatus.PROCESSED;

                Applicant applicant = new Applicant();

                applicant.Email = "mail@mail.com";
                
               
                logger.LogInformation("Worker running Order: {0}",JsonSerializer.Serialize(order));
                logger.LogInformation("Worker running Order: {0}",JsonSerializer.Serialize(applicant));
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
}
