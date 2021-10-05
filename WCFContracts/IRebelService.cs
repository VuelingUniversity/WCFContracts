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
    [ServiceContract]
    public interface IRebelService
    {
        [OperationContract(Name = "AddRebel")]
        string Add(Rebel rebel);

        [OperationContract(IsOneWay = true, Name = "SendNotification")]
        void Notify(Message message);
    }
}