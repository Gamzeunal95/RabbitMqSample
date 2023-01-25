# RabbitMqSample
RabbitMQ Publisher and Consumer

# RabbitMQ
- Microservice'ler ile ilgili son dönemde 
- İki farklı dillerle yazılımş projeleri nasıl birbiri ile haberleştiririz.Bu ortak bir kaynağa veri atmak ile ilgili
- Redis hafızada çalışıyor RabbitMQ diske de kaydediyor.
- Mesajlaşma protokoli
- **Apache Kafka** rabbitmq'nun alternatifi

- FiFo (First İn First Out)

## Bu siteden GitHub/Gmail ile üye olunabilir
- https://customer.cloudamqp.com/login 

## Konu ile ilgili yazı dizileri
- https://www.gencayyildiz.com/blog/rabbitmq-yazi-dizisi/
- https://medium.com/ltunes/k%C4%B1demli-tav%C5%9Fan-rabbitmq-4c65b03f95c9
- https://feyyazacet.medium.com/rabbitmq-exchange-types-net-core-ile-giri%C5%9F-e1c20ff8d947

# RabbitProducer   (Bu publisher - Mesaj gönderebilinmesi için)
- Aşağıdaki nugget paketler install edildi.
	- RabbitMQ.Client
- Cloudamqp [sitesinden](https://customer.cloudamqp.com/login ) oluşturduğumuz kuyruğun URL'i program.cs'e eklendi. (KuyrukAdı:Gamze)
- Queues kısmından "mesaj kuyruğu" adında olustruduğumuz kısma gelen mesajları görebiliriz..

# RabbitConsumer (Bu consumer- Gelen mesajaları okuyabilmek için)
- Aşağıdaki nugget paketler install edildi.
	- RabbitMQ.Client
- Cloudamqp [sitesinden](https://customer.cloudamqp.com/login ) oluşturduğumuz kuyruğun URL'i program.cs'e eklendi. (KuyrukAdı:Gamze)

