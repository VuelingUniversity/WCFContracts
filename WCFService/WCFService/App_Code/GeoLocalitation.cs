using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


[DataContract]
public class GeoLocalitation
{
	public int x;
	public int y;
	[DataMember]
	public int X
	{
		get { return x; }
		set { x = value; }
	}
	[DataMember]
	public int Y
	{
		get { return y; }
		set { y = value; }
	}
}