﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUIWeb.ServiceReferenceUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((this.IdUsuarioField.Equals(value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NombreUsuario {
            get {
                return this.NombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreUsuarioField, value) != true)) {
                    this.NombreUsuarioField = value;
                    this.RaisePropertyChanged("NombreUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Contrasena {
            get {
                return this.ContrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContrasenaField, value) != true)) {
                    this.ContrasenaField = value;
                    this.RaisePropertyChanged("Contrasena");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUsuario.WebServiceUsuarioSoap")]
    public interface WebServiceUsuarioSoap {
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrarUsuario", ReplyAction="*")]
        CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponse RegistrarUsuario(CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponse> RegistrarUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequestBody Body;
        
        public RegistrarUsuarioRequest() {
        }
        
        public RegistrarUsuarioRequest(CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario;
        
        public RegistrarUsuarioRequestBody() {
        }
        
        public RegistrarUsuarioRequestBody(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponseBody Body;
        
        public RegistrarUsuarioResponse() {
        }
        
        public RegistrarUsuarioResponse(CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class RegistrarUsuarioResponseBody {
        
        public RegistrarUsuarioResponseBody() {
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponse CapaGUIWeb.ServiceReferenceUsuario.WebServiceUsuarioSoap.RegistrarUsuario(CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest request) {
            return base.Channel.RegistrarUsuario(request);
        }
        
        public void RegistrarUsuario(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest inValue = new CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest();
            inValue.Body = new CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequestBody();
            inValue.Body.usuario = usuario;
            CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponse retVal = ((CapaGUIWeb.ServiceReferenceUsuario.WebServiceUsuarioSoap)(this)).RegistrarUsuario(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponse> CapaGUIWeb.ServiceReferenceUsuario.WebServiceUsuarioSoap.RegistrarUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest request) {
            return base.Channel.RegistrarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioResponse> RegistrarUsuarioAsync(CapaGUIWeb.ServiceReferenceUsuario.Usuario usuario) {
            CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest inValue = new CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequest();
            inValue.Body = new CapaGUIWeb.ServiceReferenceUsuario.RegistrarUsuarioRequestBody();
            inValue.Body.usuario = usuario;
            return ((CapaGUIWeb.ServiceReferenceUsuario.WebServiceUsuarioSoap)(this)).RegistrarUsuarioAsync(inValue);
        }
    }
}
