using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = await factory.CreateConnectionAsync();
using var channel = await connection.CreateChannelAsync();

await channel.QueueDeclareAsync(queue: "hello", durable: false, exclusive: false, autoDelete: false,
    arguments: null);
while (true)
{
    Console.WriteLine("Press [enter] to send a message or type 'exit' to quit.");
    var input = Console.ReadLine();
    if (input?.ToLower() == "exit")
    {
        break;
    }

    var body = Encoding.UTF8.GetBytes(input);
    await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "hello", body: body);
    Console.WriteLine($" [x] Sent {input}");
    Console.ReadLine();
}


 



