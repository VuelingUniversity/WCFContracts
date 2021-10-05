using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RebelWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {



        [OperationContract(Name = "addRebel")]
        string Add(Rebel rebel);

        [OperationContract(Name = "SendNotification", IsOneWay = true)]
        void Notify(Message message);

        // TODO: agregue aquí sus operaciones de servicio
    }

    //CLASE MESSAGE
    [DataContract]
    public class Message
    {

        private string _name;
        private string _email;
        [DataMember]

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.


    //CLASE REBEL
    [DataContract]
    public class Rebel
    {

        private string _name;

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    //CLASE SQUAD
    [DataContract]
    public class Squad
    {
        private string _name;
        private string _address;
        private string _galacticArea;
        private DateTime _date;
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        [DataMember]
        public string galacticArea
        {
            get { return _galacticArea; }
            set { _galacticArea = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


        //CLASE LOCATION
        [DataContract]
        public class Location
        {

            private int _x;
            private int _y;

            [DataMember]
            public int x
            {
                get { return _x; }
                set { _x = value; }
            }

            [DataMember]
            public int y
            {
                get { return _y; }
                set { _y = value; }
            }
        }
    }
}

