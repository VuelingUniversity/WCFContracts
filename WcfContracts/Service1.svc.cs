using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfContracts.Models;

namespace WcfContracts
{
    public class Service1 : IService1
    {
        private List<Rebel> _newRebel = new List<Rebel>();
        public void Add(Rebel rebel)
        {
            _newRebel.Add(rebel);
        }
        public void Notify(Message message)
        {
            Console.WriteLine($"{message.Email} to {message.Name}");
            //SendEmail;
        }
    }
}
