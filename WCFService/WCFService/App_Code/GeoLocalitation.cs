using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


[DataContract]
public class GeoLocalitation
{
	public int x = 2;
	public int y=3;
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