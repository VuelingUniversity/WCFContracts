using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfContracts.DataContracts;

namespace WcfContracts
{
    public class Service1 : IService1
    {
        private List<Rebel> newRebel = new List<Rebel>();
        public void Add(Rebel rebel)
        {
            newRebel.Add(rebel);
        }
        public void Notify(Message message)
        {
            Console.WriteLine($"{message.Email} to {message.Name}");
            //SendEmail;
        }
    }
}
