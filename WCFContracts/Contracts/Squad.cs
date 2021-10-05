using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFContracts.Models
{
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
}