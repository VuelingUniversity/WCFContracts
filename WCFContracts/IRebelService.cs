using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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

    [DataContract]
    public class Rebel
    {
        private Squad _squad;
        private GeoLocation _geoLocation;
        private string _name;
        private DateTime _registerTime;

        [DataMember]
        public Squad Squad
        {
            get { return _squad; }
            set { _squad = value; }
        }

        [DataMember]
        public GeoLocation GeoLocation
        {
            get { return _geoLocation; }
            set { _geoLocation = value; }
        }

        [DataMember(Name = "RebelName", IsRequired = true)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember(Name = "JoinningDate", IsRequired = true)]
        public DateTime RegisterTime
        {
            get { return _registerTime; }
            set { _registerTime = DateTime.Now; }
        }
    }

    [DataContract]
    public class Squad
    {
        private string _name;
        private string _location;
        private string _galacticArea;
        private DateTime _takeOffDate;

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        [DataMember]
        public string GalacticArea
        {
            get { return _galacticArea; }
            set { _galacticArea = value; }
        }

        [DataMember]
        public DateTime Date
        {
            get { return _takeOffDate; }
            set { _takeOffDate = DateTime.Now; }
        }
    }

    [DataContract]
    public class GeoLocation
    {
        private int _coordX;
        private int _coordY;

        [DataMember]
        public int CoordX
        {
            get { return _coordX; }
            set { _coordX = value; }
        }

        [DataMember]
        public int CoordY
        {
            get { return _coordY; }
            set { _coordY = value; }
        }
    }

    [DataContract]
    public class Message
    {
        private string _name;
        private string _email;

        [DataMember(Order = 1, IsRequired = true)]
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