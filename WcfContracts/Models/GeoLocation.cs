using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContracts.Models
{
    [DataContract]
    public class GeoLocation
    {
        [DataMember]
        public int CoordX
        {
            get { return CoordX; }
            set { CoordX = value; }
        }
        [DataMember]
        public int CoordY
        {
            get { return CoordY; }
            set { CoordY = value; }
        }
    }
}