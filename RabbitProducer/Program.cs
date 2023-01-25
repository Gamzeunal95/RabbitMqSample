using RabbitMQ.Client;
using System.Text;

namespace RabbitProducer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //amqps://qomplsaj:O4cvZm1wTw0hGOI5cTN-J1LPHmcSj3BK@sparrow.rmq.cloudamqp.com/qomplsaj
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri(@"amqps://qomplsaj:O4cvZm1wTw0hGOI5cTN-J1LPHmcSj3BK@sparrow.rmq.cloudamqp.com/qomplsaj");

            using (IConnection connection = factory.CreateConnection())
            {
                /* QueueDeclare parametreleri
                queue : Oluşturulacak kuyruğun adını belirliyoruz.
                durable : Normal şartlarda kuyruktaki mesajların hepsi bellek üzerinde dizilirler.
                       Hal böyleyken RabbitMQ sunucuları bir sebepten dolayı restart atarlarsa 
                       tüm veriler kaybolabilir. durable parametresine true değerini verirsek 
                       eğer verilerimiz güvenli bir şekilde sağlamlaştırılacak yani fiziksel  yani fiziksel 
                       hale getirilecektir.
                exclusive : Oluşturulacak bu kuyruğa birden fazla kanalın bağlanıp, 
                            bağlanmayacağını belirtir.
                autoDelete : True değerine karşılık tüm mesajlar bitince kuyruğu otomatik imha eder.
                */
                string str = "";
                while (str != "bye")
                {
                    Console.WriteLine("Mesaj Giriniz:");
                    str = Console.ReadLine();

                    IModel channel = connection.CreateModel();

                    //yeni bir kuyruk oluşturmaya yarar.
                    channel.QueueDeclare("mesajkuyrugu", false, false, false);
                    // Gelen mesajı byte[] dizisine çevirmek gerekiyor.
                    byte[] byteMessage = Encoding.UTF8.GetBytes(str);
                    // Oluşturulan byte mesajı ilgili kuyruğa gönderiyor.
                    channel.BasicPublish("", "mesajkuyrugu", false, null, byteMessage);


                }
            }
        }
    }
}