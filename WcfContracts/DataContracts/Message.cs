using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContracts.DataContracts
{
    [DataContract]
    public class Message
    {
        private string _Name;
        private string _Email;
        [DataMember(Order = 1)]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        [DataMember(Order = 0)]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
    }
}