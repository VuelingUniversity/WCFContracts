using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContracts.DataContracts
{
    [DataContract]
    public class Squad
    {
        [DataMember]
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember]
        public string Location
        {
            get { return Location; }
            set { Location = value; }
        }
        [DataMember]
        public string GalacticArea
        {
            get { return GalacticArea; }
            set { GalacticArea = value; }
        }
        [DataMember]
        public DateTime DeployDate
        {
            get { return DeployDate; }
            set { DeployDate = value; }
        }
    }
}