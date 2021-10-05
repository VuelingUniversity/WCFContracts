using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContracts.Models
{
    [DataContract]
    public class Message
    {
        [DataMember(Order = 1)]
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember(Order = 0)]
        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}