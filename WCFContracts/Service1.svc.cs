using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFContracts
{
public class Service1 : IService1
    {
        private List<Rebel> newRebel = new List<Rebel>();
        public void Add(Rebel rebel)
        {
            newRebel.Add(rebel);
        }

        public void SendNotification(string name, string email)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("clafuente@gteam.com", "Teruel09"),
                    EnableSsl = true,
                };
            string body = $"Hola {name} este es tu email";
            smtpClient.Send("clafuente@gteam.com", email, "subject", body);
        }
    }
}
