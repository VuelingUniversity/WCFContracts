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
    [ServiceContract]
    public interface IService1
    {
        [OperationContract(Name = "AddRebel")]
        void Add(Rebel rebel);

        [OperationContract(Name = "SendNotification", IsOneWay = true)]
        void Notify(Message message);
    } 
}
