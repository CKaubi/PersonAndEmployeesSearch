﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationServicePerson.Employee {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Employee.IDataProvaider")]
    public interface IDataProvaider {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataProvaider/FindEmployByChar", ReplyAction="http://tempuri.org/IDataProvaider/FindEmployByCharResponse")]
        System.Data.DataSet FindEmployByChar(char simbol, int request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataProvaider/FindEmployByChar", ReplyAction="http://tempuri.org/IDataProvaider/FindEmployByCharResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FindEmployByCharAsync(char simbol, int request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataProvaiderChannel : WebApplicationServicePerson.Employee.IDataProvaider, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataProvaiderClient : System.ServiceModel.ClientBase<WebApplicationServicePerson.Employee.IDataProvaider>, WebApplicationServicePerson.Employee.IDataProvaider {
        
        public DataProvaiderClient() {
        }
        
        public DataProvaiderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataProvaiderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataProvaiderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataProvaiderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FindEmployByChar(char simbol, int request) {
            return base.Channel.FindEmployByChar(simbol, request);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FindEmployByCharAsync(char simbol, int request) {
            return base.Channel.FindEmployByCharAsync(simbol, request);
        }
    }
}
