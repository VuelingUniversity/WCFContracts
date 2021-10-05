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
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}
    public Rebel GetRebelInformation(Rebel rebel)
    {	
		return new Rebel() { Name = rebel.Name, GeoLocalitation=rebel.GeoLocalitation,Squad=rebel.Squad };
	}
    public string GetRebelName(Rebel rebel)
    {
		return rebel.Name;
    }
}
