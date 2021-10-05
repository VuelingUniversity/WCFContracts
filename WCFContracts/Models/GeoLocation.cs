using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFContracts.Models
{
    [DataContract]
    public class GeoLocation
    {
        private int _coordX;
        private int _coordY;

        [DataMember]
        public int CoordX
        {
            get { return _coordX; }
            set { _coordX = value; }
        }

        [DataMember]
        public int CoordY
        {
            get { return _coordY; }
            set { _coordY = value; }
        }
    }
}