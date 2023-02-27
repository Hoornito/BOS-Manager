using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using Domain.Models;
using System.Configuration;

namespace SL.Tools
{
    public class MessageService
    {
        //pasar esto al app.config
        string accountSid = ConfigurationManager.AppSettings["accountSid"];
        string authToken = ConfigurationManager.AppSettings["authToken"];

        public void SendMessage(string telefono, PedidoModel Pedido)
        {

            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+14155238886"), body: $"Tu pedido #{Pedido.Id_Pedido} a nombre de {Pedido.Cliente.Nombre} esta en camino!", to: new PhoneNumber("whatsapp:+5491141639082"));
            //var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+13514449343"), body: $"Tu pedido {Id_Pedido} esta en camino!", to: new PhoneNumber("whatsapp:+549{telefono}"));
            Console.WriteLine(message.Sid);
        }

        public void SendMessageRetiro(string telefono, PedidoModel Pedido)
        {
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+14155238886"), body: $"Tu pedido #{Pedido.Id_Pedido} a nombre de {Pedido.Cliente.Nombre} esta listo para retirar!", to: new PhoneNumber("whatsapp:+5491141639082"));
            //var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+13514449343"), body: $"Tu pedido {Id_Pedido} esta en camino!", to: new PhoneNumber("whatsapp:+549{telefono}"));
            Console.WriteLine(message.Sid);
        }
    }
}
