using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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

