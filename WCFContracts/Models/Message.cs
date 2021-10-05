using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFContracts.Models
{
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