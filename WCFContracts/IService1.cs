using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFContracts
{
    public interface IService1
    {

        [OperationContract(Name = "AddRebel")]
        void Add(Rebel rebel);

        [OperationContract(IsOneWay = true)]
        void SendNotification(string name,string email);
    }
    [DataContract]
    public class Rebel
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public Squad Squad
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public GeoLocation GeoLocation
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

        [DataMember(Name = "Name")]
        public string RebelName
        {
            get;
            set;
        }

        [DataMember(Name = "dateTime")]
        public DateTime JoinningDate
        {
            get { return DateTime.Now; }
            set { DateTime = value; }
        }
    }
    [DataContract]
    public class Squad
    {
        [DataMember]
        public string Name
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        [DataMember]
        public string Location
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        [DataMember]
        public DateTime Date
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract]
    public class GeoLocation
    {
        [DataMember]
        public int CoordX
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        [DataMember]
        public int CoordY
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract(Name = "SendNotification")]
    public class Notify
    {
        [DataMember(Order =1)]
        public string Name
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        [DataMember(Order = 0)]
        public string Email
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
