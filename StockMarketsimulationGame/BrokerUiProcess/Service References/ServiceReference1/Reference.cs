﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrokerUiProcess.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBrokerService")]
    public interface IBrokerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBrokerService/checkwork", ReplyAction="http://tempuri.org/IBrokerService/checkworkResponse")]
        string checkwork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBrokerService/checkwork", ReplyAction="http://tempuri.org/IBrokerService/checkworkResponse")]
        System.Threading.Tasks.Task<string> checkworkAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBrokerServiceChannel : BrokerUiProcess.ServiceReference1.IBrokerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BrokerServiceClient : System.ServiceModel.ClientBase<BrokerUiProcess.ServiceReference1.IBrokerService>, BrokerUiProcess.ServiceReference1.IBrokerService {
        
        public BrokerServiceClient() {
        }
        
        public BrokerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BrokerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string checkwork() {
            return base.Channel.checkwork();
        }
        
        public System.Threading.Tasks.Task<string> checkworkAsync() {
            return base.Channel.checkworkAsync();
        }
    }
}