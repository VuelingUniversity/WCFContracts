using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService {
    public string Add(Rebel rebel) {
        return rebel.ToString();
    }

    public void Notify(Message message) {
        // Aqui se gestionaria el envio de un message
    }
}
