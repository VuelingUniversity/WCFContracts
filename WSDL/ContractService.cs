﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfContractService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Rebel", Namespace="http://schemas.datacontract.org/2004/07/WcfContractService")]
    public partial class Rebel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private WcfContractService.Location CurrentLocationField;
        
        private System.DateTime JoiningDateField;
        
        private string RebeldNameField;
        
        private WcfContractService.Squad SoldierSquadField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfContractService.Location CurrentLocation
        {
            get
            {
                return this.CurrentLocationField;
            }
            set
            {
                this.CurrentLocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime JoiningDate
        {
            get
            {
                return this.JoiningDateField;
            }
            set
            {
                this.JoiningDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string RebeldName
        {
            get
            {
                return this.RebeldNameField;
            }
            set
            {
                this.RebeldNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfContractService.Squad SoldierSquad
        {
            get
            {
                return this.SoldierSquadField;
            }
            set
            {
                this.SoldierSquadField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/WcfContractService")]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int PointXField;
        
        private int PointYField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PointX
        {
            get
            {
                return this.PointXField;
            }
            set
            {
                this.PointXField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PointY
        {
            get
            {
                return this.PointYField;
            }
            set
            {
                this.PointYField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Squad", Namespace="http://schemas.datacontract.org/2004/07/WcfContractService")]
    public partial class Squad : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private System.DateTime DeployDateField;
        
        private string GalacticAreaField;
        
        private string SquadNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DeployDate
        {
            get
            {
                return this.DeployDateField;
            }
            set
            {
                this.DeployDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GalacticArea
        {
            get
            {
                return this.GalacticAreaField;
            }
            set
            {
                this.GalacticAreaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SquadName
        {
            get
            {
                return this.SquadNameField;
            }
            set
            {
                this.SquadNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/WcfContractService")]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string order0Field;
        
        private string order1Field;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string order0
        {
            get
            {
                return this.order0Field;
            }
            set
            {
                this.order0Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string order1
        {
            get
            {
                return this.order1Field;
            }
            set
            {
                this.order1Field = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IContractService")]
public interface IContractService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContractService/AddRebel", ReplyAction="http://tempuri.org/IContractService/AddRebelResponse")]
    string AddRebel(WcfContractService.Rebel newRebel);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContractService/AddRebel", ReplyAction="http://tempuri.org/IContractService/AddRebelResponse")]
    System.Threading.Tasks.Task<string> AddRebelAsync(WcfContractService.Rebel newRebel);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IContractService/SendNotification")]
    void SendNotification(WcfContractService.Message message);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IContractService/SendNotification")]
    System.Threading.Tasks.Task SendNotificationAsync(WcfContractService.Message message);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IContractServiceChannel : IContractService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ContractServiceClient : System.ServiceModel.ClientBase<IContractService>, IContractService
{
    
    public ContractServiceClient()
    {
    }
    
    public ContractServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ContractServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ContractServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ContractServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string AddRebel(WcfContractService.Rebel newRebel)
    {
        return base.Channel.AddRebel(newRebel);
    }
    
    public System.Threading.Tasks.Task<string> AddRebelAsync(WcfContractService.Rebel newRebel)
    {
        return base.Channel.AddRebelAsync(newRebel);
    }
    
    public void SendNotification(WcfContractService.Message message)
    {
        base.Channel.SendNotification(message);
    }
    
    public System.Threading.Tasks.Task SendNotificationAsync(WcfContractService.Message message)
    {
        return base.Channel.SendNotificationAsync(message);
    }
}
