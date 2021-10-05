using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class Messages
{
	string name;
	string email;

	[DataMember(Order =1]
	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	[DataMember(Order =0)]
	public string Email
	{
		get { return email; }
		set { email = value; }
	}
}