﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1026
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sincronizador_CadeteEnLinea.Cadetes_Web_Local {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:CadeteControllerwsdl", ConfigurationName="Cadetes_Web_Local.CadeteControllerPortType")]
    public interface CadeteControllerPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:CadeteControllerwsdl#save", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string save(string cadetesJson);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CadeteControllerPortTypeChannel : Sincronizador_CadeteEnLinea.Cadetes_Web_Local.CadeteControllerPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CadeteControllerPortTypeClient : System.ServiceModel.ClientBase<Sincronizador_CadeteEnLinea.Cadetes_Web_Local.CadeteControllerPortType>, Sincronizador_CadeteEnLinea.Cadetes_Web_Local.CadeteControllerPortType {
        
        public CadeteControllerPortTypeClient() {
        }
        
        public CadeteControllerPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CadeteControllerPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CadeteControllerPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CadeteControllerPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string save(string cadetesJson) {
            return base.Channel.save(cadetesJson);
        }
    }
}
