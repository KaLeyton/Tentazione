﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUIWeb.ServiceReferenceUsuario {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUsuario.WebServiceUsuarioSoap")]
    public interface WebServiceUsuarioSoap {
        
<<<<<<< HEAD
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceRegistrarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ServiceRegistrarUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceRegistrarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task ServiceRegistrarUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceListaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ServiceListaUsuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceListaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ServiceListaUsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceBuscaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUIWeb.ServiceReferenceUsuario.Usuario ServiceBuscaUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceBuscaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUIWeb.ServiceReferenceUsuario.Usuario> ServiceBuscaUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceActualizaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ServiceActualizaUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceActualizaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task ServiceActualizaUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceEliminaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ServiceEliminaUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceEliminaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task ServiceEliminaUsuarioAsync(int id);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idUsuarioField;
        
        private string nombreUsuarioField;
        
=======
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RegistrarUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task RegistrarUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListaUsuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListaUsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUIWeb.ServiceReferenceUsuario.Usuario BuscaUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUIWeb.ServiceReferenceUsuario.Usuario> BuscaUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ActualizaUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task ActualizaUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void EliminaUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task EliminaUsuarioAsync(int id);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idUsuarioField;
        
        private string nombreUsuarioField;
        
>>>>>>> 07a584c... agregue pantallas capaGUI, Modifique base de datos y capa DTO, agregue vistas capaGUIWeb
        private string contrasenaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("IdUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string NombreUsuario {
            get {
                return this.nombreUsuarioField;
            }
            set {
                this.nombreUsuarioField = value;
                this.RaisePropertyChanged("NombreUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Contrasena {
            get {
                return this.contrasenaField;
            }
            set {
                this.contrasenaField = value;
                this.RaisePropertyChanged("Contrasena");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceUsuarioSoapChannel : CapaGUIWeb.ServiceReferenceUsuario.WebServiceUsuarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceUsuarioSoapClient : System.ServiceModel.ClientBase<CapaGUIWeb.ServiceReferenceUsuario.WebServiceUsuarioSoap>, CapaGUIWeb.ServiceReferenceUsuario.WebServiceUsuarioSoap {
        
        public WebServiceUsuarioSoapClient() {
        }
        
        public WebServiceUsuarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceUsuarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceUsuarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceUsuarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
<<<<<<< HEAD
        public void ServiceRegistrarUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            base.Channel.ServiceRegistrarUsuario(usuario);
        }
        
        public System.Threading.Tasks.Task ServiceRegistrarUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            return base.Channel.ServiceRegistrarUsuarioAsync(usuario);
        }
        
        public System.Data.DataSet ServiceListaUsuario() {
            return base.Channel.ServiceListaUsuario();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ServiceListaUsuarioAsync() {
            return base.Channel.ServiceListaUsuarioAsync();
        }
        
        public CapaGUIWeb.ServiceReferenceUsuario.Usuario ServiceBuscaUsuario(int id) {
            return base.Channel.ServiceBuscaUsuario(id);
        }
        
        public System.Threading.Tasks.Task<CapaGUIWeb.ServiceReferenceUsuario.Usuario> ServiceBuscaUsuarioAsync(int id) {
            return base.Channel.ServiceBuscaUsuarioAsync(id);
        }
        
        public void ServiceActualizaUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            base.Channel.ServiceActualizaUsuario(usuario);
        }
        
        public System.Threading.Tasks.Task ServiceActualizaUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            return base.Channel.ServiceActualizaUsuarioAsync(usuario);
        }
        
        public void ServiceEliminaUsuario(int id) {
            base.Channel.ServiceEliminaUsuario(id);
        }
        
        public System.Threading.Tasks.Task ServiceEliminaUsuarioAsync(int id) {
            return base.Channel.ServiceEliminaUsuarioAsync(id);
=======
        public void RegistrarUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            base.Channel.RegistrarUsuario(usuario);
        }
        
        public System.Threading.Tasks.Task RegistrarUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            return base.Channel.RegistrarUsuarioAsync(usuario);
        }
        
        public System.Data.DataSet ListaUsuario() {
            return base.Channel.ListaUsuario();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListaUsuarioAsync() {
            return base.Channel.ListaUsuarioAsync();
        }
        
        public CapaGUIWeb.ServiceReferenceUsuario.Usuario BuscaUsuario(int id) {
            return base.Channel.BuscaUsuario(id);
        }
        
        public System.Threading.Tasks.Task<CapaGUIWeb.ServiceReferenceUsuario.Usuario> BuscaUsuarioAsync(int id) {
            return base.Channel.BuscaUsuarioAsync(id);
        }
        
        public void ActualizaUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            base.Channel.ActualizaUsuario(usuario);
        }
        
        public System.Threading.Tasks.Task ActualizaUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            return base.Channel.ActualizaUsuarioAsync(usuario);
        }
        
        public void EliminaUsuario(int id) {
            base.Channel.EliminaUsuario(id);
        }
        
        public System.Threading.Tasks.Task EliminaUsuarioAsync(int id) {
            return base.Channel.EliminaUsuarioAsync(id);
>>>>>>> 07a584c... agregue pantallas capaGUI, Modifique base de datos y capa DTO, agregue vistas capaGUIWeb
        }
    }
}
