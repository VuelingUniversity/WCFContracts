using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de Rebel
/// </summary>
[DataContract]
public class Rebel
{
    Squad squad;
    GeoLocalitation geoLocalitation;
    string name;
    DateTime joiningDate = DateTime.Now;
    [DataMember]
    public Squad Squad
    {
        get { return squad; }
        set { squad = value; }
    }
    [DataMember]
    public GeoLocalitation GeoLocalitation
    {
        get { return geoLocalitation; }
        set { geoLocalitation = value; }
    }
    [DataMember]
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    [DataMember(Name ="datetime")]
    public DateTime JoiningDate
    {
        get { return joiningDate; }
        set { joiningDate = value; }
    }
}