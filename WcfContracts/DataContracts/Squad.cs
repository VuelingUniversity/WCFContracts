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
        private string _Name;
        private string _Location;
        private string _GalacticArea;
        private DateTime _DeployDate;

        [DataMember]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        [DataMember]
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        [DataMember]
        public string GalacticArea
        {
            get { return _GalacticArea; }
            set { _GalacticArea = value; }
        }
        [DataMember]
        public DateTime DeployDate
        {
            get { return _DeployDate; }
            set { _DeployDate = value; }
        }
    }
}