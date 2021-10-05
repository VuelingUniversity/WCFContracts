using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContracts.Models
{
    [DataContract]
    public class Rebel
    {
        [DataMember(EmitDefaultValue = false)]
        public Squad Squad
        {
            get { return Squad; }
            set { Squad = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public GeoLocation GeoLocation
        {
            get { return GeoLocation; }
            set { GeoLocation = value; }
        }

        [DataMember(Name = "RebeldName", IsRequired = true)]
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        [DataMember(Name = "JoiningDate", IsRequired = true)]
        public DateTime dateTime
        {
            get { return DateTime.Now; }
            set { dateTime = value; }
        }
    }
}