﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class Squad
{
    string name = "Patatera";
    string localitation = "Pluton";
    DateTime arrival= DateTime.Now;
    [DataMember]
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    [DataMember]
    public string Localitation
    {
        get { return localitation; }
        set { localitation = value; }
    }
    [DataMember]
    public DateTime Arrival
    {
        get { return arrival; }
        set { arrival = value; }
    }
}