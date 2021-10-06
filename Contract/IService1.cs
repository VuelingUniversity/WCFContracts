using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract(Name = "AddRebel")]
        void Add(Rebel rebel);

        [OperationContract(IsOneWay = true)]
        void SendNotification(string name, string email);
    }
    [DataContract]
    public class Rebel
    {
        public Squad _squad;
        public GeoLocation _location;
        public string _name;
        public DateTime _datetime = DateTime.Now;

        [DataMember]
        public Squad Squad
        {
            get { return _squad; }
            set { _squad = value; }
        }

        [DataMember]
        public GeoLocation GeoLocation
        {
            get { return _location; }
            set { _location = value; }
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
            get { return _datetime; }
            set { _datetime = value; }
        }
    }
    [DataContract]
    public class Squad
    {
        public string _nameSquad;
        public string _location;
        public DateTime _datetime = DateTime.Now;
        [DataMember]
        public string Name
        {
            get { return _nameSquad; }
            set { _nameSquad = value; }
        }
        [DataMember]
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        [DataMember]
        public DateTime Date
        {
            get { return _datetime; }
            set { _datetime = value; }
        }
    }
    [DataContract]
    public class GeoLocation
    {
        public int _x;
        public int _y;
        [DataMember]
        public int CoordX
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int CoordY
        {
            get { return _y; }
            set { _y = value; }
        }
    }
    [DataContract(Name = "SendNotification")]
    public class Notify
    {
        public string _name;
        public string _email;
        [DataMember(Order = 1)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DataMember(Order = 0)]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
