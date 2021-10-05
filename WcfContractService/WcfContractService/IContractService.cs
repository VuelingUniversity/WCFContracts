using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfContractService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContractService
    {
        [OperationContract(Name = "AddRebel")]
        string Add(Rebel newRebel);

        [OperationContract(IsOneWay = true, Name = "SendNotification")]
        void Notify(Message message);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Rebel
    {
        private Squad _soldierSquad;
        private Location _currentLocation;
        private string _name;
        private DateTime _recruitDate;

        [DataMember(IsRequired = false)]
        public Squad SoldierSquad { get => _soldierSquad; set => _soldierSquad = value; }

        [DataMember(IsRequired = false)]
        public Location CurrentLocation { get => _currentLocation; set => _currentLocation = value; }

        [DataMember(Name = "RebeldName", IsRequired = true)]
        public string Name { get => _name; set => _name = value; }

        [DataMember(Name = "JoiningDate", IsRequired = true)]
        public DateTime RecruitDate { get => _recruitDate; set => _recruitDate = value; }
    }

    [DataContract]
    public class Squad
    {
        private string _squadName;
        private string _address;
        private string _galacticArea;
        private DateTime _deployDate;

        [DataMember]
        public string SquadName { get => _squadName; set => _squadName = value; }

        [DataMember]
        public string Address { get => _address; set => _address = value; }

        [DataMember]
        public string GalacticArea { get => _galacticArea; set => _galacticArea = value; }

        [DataMember]
        public DateTime DeployDate { get => _deployDate; set => _deployDate = value; }
    }

    [DataContract]
    public class Location
    {
        private int _pointX;
        private int _pointY;

        [DataMember]
        public int PointX { get => _pointX; set => _pointX = value; }

        [DataMember]
        public int PointY { get => _pointY; set => _pointY = value; }
    }

    [DataContract]
    public class Message
    {
        private string _name;
        private string _email;

        [DataMember(Name = "order1", IsRequired = true)]
        public string Name { get => _name; set => _name = value; }

        [DataMember(Name = "order0", IsRequired = false)]
        public string Email { get => _email; set => _email = value; }
    }
}