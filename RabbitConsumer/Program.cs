using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RabbitConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri(@"amqps://qomplsaj:O4cvZm1wTw0hGOI5cTN-J1LPHmcSj3BK@sparrow.rmq.cloudamqp.com/qomplsaj");

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "mesajkuyrugu",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);

                /*
                BasicConsume” metodunun parametrelerini incelersek eğer;
                queue : Mesajların alınacağı kuyruk adı.
                autoAck : Kuruktan alınan mesajın silinip silinmemesini sağlıyor. Bazen kuyruktan 
                          alınan mesaj işlenirken beklenmeyen hatalarla karşılaşılabiliyor. 
                          O yüzden mesajı başarılı bir şekilde işlemeksizin kuyruktan silinmesini 
                          pek önermeyiz.
                consumer :Tüketici.                                  
                 */
                // Yukarıda açıklamada bulunan sıra
                channel.BasicConsume(queue: "mesajkuyrugu", false, consumer);

                consumer.Received += (sender, e) =>
                {
                    Console.WriteLine(Encoding.UTF8.GetString(e.Body.ToArray()));
                };

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }

        }
    }
}