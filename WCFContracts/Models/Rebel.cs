using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFContracts.Models
{
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
}