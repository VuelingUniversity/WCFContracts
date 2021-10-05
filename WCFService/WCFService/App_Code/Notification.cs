using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract(Name ="SendNotification")]
public class Notification
{
	string name;
	string email;

	[DataMember(Name = "orden 1")]
	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	[DataMember(Name = "orden 0")]
	public string Email
	{
		get { return email; }
		set { email = value; }
	}
}