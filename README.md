# WCFContracts

Rebeldes WCF Contracts

Tienes que crear un servicio WCF para que pueda ser utilizado en las naves.

Dicho servicio tendrá dos utilidades, añadir rebelde (Add) y enviar mensaje (Notify).

**Add** que  
* aparecera en el wsdl como AddRebel
* Se pasará un rebelde y devolverá un string en el que pongan los datos del susodicho rebelde. (edited)
* la clase Rebel
	* Contendrá o no un Squad 
		* Tendrá un nombre
		* Tendrá una dirección
		* Tendra una area galáctica (string simple)
		* una fecha de despliegue.
	* Contendrá o no una Localización 
		* Localización tiene 2 propiedades 
			1 int PointX
			2 int PointY		
	* Tendrá una propiedad Name (que en el contrato ha de aparecer como RebeldName), esta es requerida sí o sí
	* Tendrá una fecha de registro dateTime (que en el contrato se denominará  JoiningDate), esta es requerida sí o sí

**Notify** que
* aparecerá en el wsdl como SendNotification
* ha de ser OneWay
* recibe una clase Message
	* Tendrá requerido un nombre (orden 1)
	* Tendrá opcional un email (orden 0)



#### Una vez creado y puesto en marcha el servicio usa el svcutil en una carpeta para ver que crea en local
