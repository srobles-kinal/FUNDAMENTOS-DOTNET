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
                order.EntityData = new Applicant("Robles","Sergio","8","mail@mail.com","1","2","3");

            
                Order order2 = new Order();

                order2.EntityType = EntityType.CANDIDATE;
                order2.OperationType = OperationType.CREATE;
                order2.Status = OrderStatus.PROCESSED;

                order2.EntityData = new Student();

                order2.EntityData.LastName = "Robles";
                order2.EntityData.FirstName = "Nicole";

                ((Student)order2.EntityData).StudentId = Guid.NewGuid().ToString();
                              
                logger.LogInformation("Worker running Order: {0}",JsonSerializer.Serialize(order));
                logger.LogInformation("Applicant: {0}",JsonSerializer.Serialize((Applicant)order.EntityData));
           
                              
                logger.LogInformation("Worker running Order: {0}",JsonSerializer.Serialize(order2));
                logger.LogInformation("Applicant: {0}",JsonSerializer.Serialize((Student)order2.EntityData));
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
}
