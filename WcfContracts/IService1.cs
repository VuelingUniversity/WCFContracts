using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfContracts
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract(Name = "AddRebel")]
        void Add(Rebel rebel);

        [OperationContract(Name = "SendNotification", IsOneWay = true)]
        void Notify(Message message);

        // TODO: agregue aquí sus operaciones de servicio
    }
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Rebel
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember(EmitDefaultValue = false)]
        public Squad Squad
        {
            get { return Squad; }
            set { Squad = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public GeoLocation GeoLocation
        {
            get { return GeoLocation; }
            set { GeoLocation = value; }
        }

        [DataMember(Name = "RebeldName", IsRequired = true)]
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        [DataMember(Name = "JoiningDate", IsRequired = true))]
        public DateTime dateTime
        {
            get { return DateTime.Now; }
            set { dateTime = value; }
        }
    }
    [DataContract]
    public class Squad
    {
        [DataMember]
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember]
        public string Location
        {
            get { return Location; }
            set { Location = value; }
        }
        [DataMember]
        public string GalacticArea
        {
            get { return GalacticArea; }
            set { GalacticArea = value; }
        }
        [DataMember]
        public DateTime DeployDate
        {
            get { return DeployDate; }
            set { DeployDate = value; }
        }
    }
    [DataContract]
    public class GeoLocation
    {
        [DataMember]
        public int CoordX
        {
            get { return CoordX; }
            set { CoordX = value; }
        }
        [DataMember]
        public int CoordY
        {
            get { return CoordY; }
            set { CoordY = value; }
        }
    }
    [DataContract(Name = "SendNotification")]
    public class Message
    {
        [DataMember(Order = 1)]
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember(Order = 0)]
        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
