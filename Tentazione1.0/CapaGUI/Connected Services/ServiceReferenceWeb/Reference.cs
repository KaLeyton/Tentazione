﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceReferenceWeb {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceWeb.WebServiceUsuarioWebSoap")]
    public interface WebServiceUsuarioWebSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceValidaLogIn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ServiceValidaLogIn(string nombre, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceValidaLogIn", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ServiceValidaLogInAsync(string nombre, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceListaProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable ServiceListaProducto(string filtro, bool sentido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceListaProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> ServiceListaProductoAsync(string filtro, bool sentido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceBuscaProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable ServiceBuscaProducto(string filtro, string valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceBuscaProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> ServiceBuscaProductoAsync(string filtro, string valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceRegistrarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ServiceRegistrarUsuario(string nombre, string contra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceRegistrarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ServiceRegistrarUsuarioAsync(string nombre, string contra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSesion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ServiceSesion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceSesion", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ServiceSesionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceUsuarioWebSoapChannel : CapaGUI.ServiceReferenceWeb.WebServiceUsuarioWebSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceUsuarioWebSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceReferenceWeb.WebServiceUsuarioWebSoap>, CapaGUI.ServiceReferenceWeb.WebServiceUsuarioWebSoap {
        
        public WebServiceUsuarioWebSoapClient() {
        }
        
        public WebServiceUsuarioWebSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceUsuarioWebSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceUsuarioWebSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceUsuarioWebSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ServiceValidaLogIn(string nombre, string contrasena) {
            return base.Channel.ServiceValidaLogIn(nombre, contrasena);
        }
        
        public System.Threading.Tasks.Task<string> ServiceValidaLogInAsync(string nombre, string contrasena) {
            return base.Channel.ServiceValidaLogInAsync(nombre, contrasena);
        }
        
        public System.Data.DataTable ServiceListaProducto(string filtro, bool sentido) {
            return base.Channel.ServiceListaProducto(filtro, sentido);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ServiceListaProductoAsync(string filtro, bool sentido) {
            return base.Channel.ServiceListaProductoAsync(filtro, sentido);
        }
        
        public System.Data.DataTable ServiceBuscaProducto(string filtro, string valor) {
            return base.Channel.ServiceBuscaProducto(filtro, valor);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ServiceBuscaProductoAsync(string filtro, string valor) {
            return base.Channel.ServiceBuscaProductoAsync(filtro, valor);
        }
        
        public bool ServiceRegistrarUsuario(string nombre, string contra) {
            return base.Channel.ServiceRegistrarUsuario(nombre, contra);
        }
        
        public System.Threading.Tasks.Task<bool> ServiceRegistrarUsuarioAsync(string nombre, string contra) {
            return base.Channel.ServiceRegistrarUsuarioAsync(nombre, contra);
        }
        
        public string ServiceSesion() {
            return base.Channel.ServiceSesion();
        }
        
        public System.Threading.Tasks.Task<string> ServiceSesionAsync() {
            return base.Channel.ServiceSesionAsync();
        }
    }
}
