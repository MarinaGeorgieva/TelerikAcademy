﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DaysOfWeekClient.DayServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DayServiceReference.IDayService")]
    public interface IDayService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayService/GetDay", ReplyAction="http://tempuri.org/IDayService/GetDayResponse")]
        string GetDay(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayService/GetDay", ReplyAction="http://tempuri.org/IDayService/GetDayResponse")]
        System.Threading.Tasks.Task<string> GetDayAsync(System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDayServiceChannel : DaysOfWeekClient.DayServiceReference.IDayService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DayServiceClient : System.ServiceModel.ClientBase<DaysOfWeekClient.DayServiceReference.IDayService>, DaysOfWeekClient.DayServiceReference.IDayService {
        
        public DayServiceClient() {
        }
        
        public DayServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DayServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DayServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DayServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDay(System.DateTime date) {
            return base.Channel.GetDay(date);
        }
        
        public System.Threading.Tasks.Task<string> GetDayAsync(System.DateTime date) {
            return base.Channel.GetDayAsync(date);
        }
    }
}
