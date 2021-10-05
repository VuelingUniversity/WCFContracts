using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContracts.DataContracts
{
    [DataContract]
    public class Rebel
    {
        private Squad _Squad;
        private GeoLocation _GeoLocation;
        private string _Name;
        private DateTime _dateTime;

        [DataMember(EmitDefaultValue = false)]
        public Squad Squad
        {
            get { return _Squad; }
            set { _Squad = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public GeoLocation GeoLocation
        {
            get { return _GeoLocation; }
            set { _GeoLocation = value; }
        }

        [DataMember(Name = "RebeldName", IsRequired = true)]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember(Name = "JoiningDate", IsRequired = true)]
        public DateTime dateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
    }
}