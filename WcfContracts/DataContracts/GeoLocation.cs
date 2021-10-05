using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContracts.DataContracts
{
    [DataContract]
    public class GeoLocation
    {
        private int _CoordX;
        private int _CoordY;
        [DataMember]
        public int CoordX
        {
            get { return _CoordX; }
            set { _CoordX = value; }
        }
        [DataMember]
        public int CoordY
        {
            get { return _CoordY; }
            set { _CoordY = value; }
        }
    }
}