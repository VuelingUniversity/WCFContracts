using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    private List<Rebel> RebelList = new List<Rebel>();
    public string Add(Rebel rebel)
    {
            RebelList.Add(rebel);
            return rebel.Name+ " "+rebel.JoiningDate;
      
       
    }
    public string Notification(Messages message)
    {
        return message.Name +" "+ message.Email;
    }
}
