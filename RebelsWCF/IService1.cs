using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RebelsStuff_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract(Name = "AddRebel")]
        string Add(Rebel rebel);

        [OperationContract(Name = "SendNotification", IsOneWay = true)]
        void Notify(Message message);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Rebel
    {
        [DataMember(Name = "RebelName", IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "JoiningDate", IsRequired = true)]
        public DateTime DateTime
        { get; set; }

        [DataMember]
        public Squad Squad { get; set; }

        [DataMember]
        public Localization Localization { get; set; }
    }

    [DataContract]
    public class Squad
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string GalacticArea { get; set; }

        [DataMember]
        public DateTime AttackTime { get; set; }
    }

    [DataContract]
    public class Localization
    {
        [DataMember]
        public string PointX { get; set; }

        [DataMember]
        public string PointY { get; set; }
    }

    [DataContract]
    public class Message
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Order = 0, IsRequired = false, EmitDefaultValue = false)]
        public string Email { get; set; }
    }
}