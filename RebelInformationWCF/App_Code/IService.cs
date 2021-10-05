using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService {
    [OperationContract(IsOneWay = true, Name = "SendNotification")]
    void Notify(Message message);

    [OperationContract(Name = "AddRebel")]
    string Add(Rebel rebel);
}

[DataContract]
public class Rebel {
    [DataMember]
    public Squad Squad { get; set; }

    [DataMember]
    public Localization Direction { get; set; }

    [DataMember(Name = "dateTime")]
    public DateTime JoiningDate { get; set; }

    [DataMember(Name = "RebeldName")]
    public string Name { get; set; }
}
[DataContract]
public class Squad {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public DateTime CreationDate { get; set; }// En C#6 o superior se podria hecer = DateTime.Now();
}
[DataContract]
public class Localization {
    [DataMember]
    public int PointX { get; set; }

    [DataMember]
    public int PointY { get; set; }
}
[DataContract]
public class Message {
    [DataMember(Order = 1)]
    public string Name { get; set; }

    [DataMember(Order = 0)]
    public string Email { get; set; }
}