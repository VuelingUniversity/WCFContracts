using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFContracts.Models;

namespace WCFContracts
{
    public class RebelService : IRebelService
    {
        private List<Rebel> _rebelList = new List<Rebel>();

        public string Add(Rebel rebel)
        {
            _rebelList.Add(rebel);
            return $"Rebeld {rebel.Name}, joinned {rebel.RegisterTime}, squad {rebel.Squad.Name}";
        }

        public void Notify(Message message)
        {
            Console.WriteLine(message.Name, message.Email);
        }
    }
}