﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceLogin {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLogin.WebServiceLoginSoap")]
    public interface WebServiceLoginSoap {
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SValidaLogIn", ReplyAction="*")]
        CapaGUI.ServiceLogin.SValidaLogInResponse SValidaLogIn(CapaGUI.ServiceLogin.SValidaLogInRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SValidaLogIn", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceLogin.SValidaLogInResponse> SValidaLogInAsync(CapaGUI.ServiceLogin.SValidaLogInRequest request);
        
        // CODEGEN: Generating message contract since element name SBuscaSesionResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SBuscaSesion", ReplyAction="*")]
        CapaGUI.ServiceLogin.SBuscaSesionResponse SBuscaSesion(CapaGUI.ServiceLogin.SBuscaSesionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SBuscaSesion", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceLogin.SBuscaSesionResponse> SBuscaSesionAsync(CapaGUI.ServiceLogin.SBuscaSesionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SValidaLogInRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SValidaLogIn", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceLogin.SValidaLogInRequestBody Body;
        
        public SValidaLogInRequest() {
        }
        
        public SValidaLogInRequest(CapaGUI.ServiceLogin.SValidaLogInRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SValidaLogInRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string contrasena;
        
        public SValidaLogInRequestBody() {
        }
        
        public SValidaLogInRequestBody(string nombre, string contrasena) {
            this.nombre = nombre;
            this.contrasena = contrasena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SValidaLogInResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SValidaLogInResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceLogin.SValidaLogInResponseBody Body;
        
        public SValidaLogInResponse() {
        }
        
        public SValidaLogInResponse(CapaGUI.ServiceLogin.SValidaLogInResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SValidaLogInResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SValidaLogInResult;
        
        public SValidaLogInResponseBody() {
        }
        
        public SValidaLogInResponseBody(string SValidaLogInResult) {
            this.SValidaLogInResult = SValidaLogInResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SBuscaSesionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SBuscaSesion", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceLogin.SBuscaSesionRequestBody Body;
        
        public SBuscaSesionRequest() {
        }
        
        public SBuscaSesionRequest(CapaGUI.ServiceLogin.SBuscaSesionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SBuscaSesionRequestBody {
        
        public SBuscaSesionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SBuscaSesionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SBuscaSesionResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceLogin.SBuscaSesionResponseBody Body;
        
        public SBuscaSesionResponse() {
        }
        
        public SBuscaSesionResponse(CapaGUI.ServiceLogin.SBuscaSesionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SBuscaSesionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SBuscaSesionResult;
        
        public SBuscaSesionResponseBody() {
        }
        
        public SBuscaSesionResponseBody(string SBuscaSesionResult) {
            this.SBuscaSesionResult = SBuscaSesionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceLoginSoapChannel : CapaGUI.ServiceLogin.WebServiceLoginSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceLoginSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceLogin.WebServiceLoginSoap>, CapaGUI.ServiceLogin.WebServiceLoginSoap {
        
        public WebServiceLoginSoapClient() {
        }
        
        public WebServiceLoginSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceLoginSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLoginSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLoginSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceLogin.SValidaLogInResponse CapaGUI.ServiceLogin.WebServiceLoginSoap.SValidaLogIn(CapaGUI.ServiceLogin.SValidaLogInRequest request) {
            return base.Channel.SValidaLogIn(request);
        }
        
        public string SValidaLogIn(string nombre, string contrasena) {
            CapaGUI.ServiceLogin.SValidaLogInRequest inValue = new CapaGUI.ServiceLogin.SValidaLogInRequest();
            inValue.Body = new CapaGUI.ServiceLogin.SValidaLogInRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.contrasena = contrasena;
            CapaGUI.ServiceLogin.SValidaLogInResponse retVal = ((CapaGUI.ServiceLogin.WebServiceLoginSoap)(this)).SValidaLogIn(inValue);
            return retVal.Body.SValidaLogInResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceLogin.SValidaLogInResponse> CapaGUI.ServiceLogin.WebServiceLoginSoap.SValidaLogInAsync(CapaGUI.ServiceLogin.SValidaLogInRequest request) {
            return base.Channel.SValidaLogInAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceLogin.SValidaLogInResponse> SValidaLogInAsync(string nombre, string contrasena) {
            CapaGUI.ServiceLogin.SValidaLogInRequest inValue = new CapaGUI.ServiceLogin.SValidaLogInRequest();
            inValue.Body = new CapaGUI.ServiceLogin.SValidaLogInRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.contrasena = contrasena;
            return ((CapaGUI.ServiceLogin.WebServiceLoginSoap)(this)).SValidaLogInAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceLogin.SBuscaSesionResponse CapaGUI.ServiceLogin.WebServiceLoginSoap.SBuscaSesion(CapaGUI.ServiceLogin.SBuscaSesionRequest request) {
            return base.Channel.SBuscaSesion(request);
        }
        
        public string SBuscaSesion() {
            CapaGUI.ServiceLogin.SBuscaSesionRequest inValue = new CapaGUI.ServiceLogin.SBuscaSesionRequest();
            inValue.Body = new CapaGUI.ServiceLogin.SBuscaSesionRequestBody();
            CapaGUI.ServiceLogin.SBuscaSesionResponse retVal = ((CapaGUI.ServiceLogin.WebServiceLoginSoap)(this)).SBuscaSesion(inValue);
            return retVal.Body.SBuscaSesionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceLogin.SBuscaSesionResponse> CapaGUI.ServiceLogin.WebServiceLoginSoap.SBuscaSesionAsync(CapaGUI.ServiceLogin.SBuscaSesionRequest request) {
            return base.Channel.SBuscaSesionAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceLogin.SBuscaSesionResponse> SBuscaSesionAsync() {
            CapaGUI.ServiceLogin.SBuscaSesionRequest inValue = new CapaGUI.ServiceLogin.SBuscaSesionRequest();
            inValue.Body = new CapaGUI.ServiceLogin.SBuscaSesionRequestBody();
            return ((CapaGUI.ServiceLogin.WebServiceLoginSoap)(this)).SBuscaSesionAsync(inValue);
        }
    }
}
