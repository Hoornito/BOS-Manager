using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace SL.Tools
{
    public class MessageService
    {
        //pasar esto al app.config
        const string accountSid = "AC1fd65a4267bbf74e58671023ef390e4a";
        const string authToken = "fb46526c023402dd087768562c41e96e";

        public void SendMessage(string telefono, int Id_Pedido)
        {           
            
            //TwilioClient.Init(accountSid, authToken);
            //var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+14155238886"), body: $"Tu pedido {Id_Pedido} esta en camino!", to: new PhoneNumber("whatsapp:+5491141639082"));
            ////var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+13514449343"), body: $"Tu pedido {Id_Pedido} esta en camino!", to: new PhoneNumber("whatsapp:+549{telefono}"));
            //Console.WriteLine(message.Sid);
        }

        public void SendMessageRetiro(string telefono, int Id_Pedido)
        {
            //TwilioClient.Init(accountSid, authToken);
            //var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+14155238886"), body: $"Tu pedido {Id_Pedido} esta en listo para retirar!", to: new PhoneNumber("whatsapp:+5491141639082"));
            ////var message = MessageResource.Create(from: new PhoneNumber("whatsapp:+13514449343"), body: $"Tu pedido {Id_Pedido} esta en camino!", to: new PhoneNumber("whatsapp:+549{telefono}"));
            //Console.WriteLine(message.Sid);
        }
    }
}
