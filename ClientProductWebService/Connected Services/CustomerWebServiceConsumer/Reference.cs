﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProductWebService.CustomerWebServiceConsumer
{


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MusteriSonuc", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MusteriSonuc : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MusteriIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MusteriAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SirketAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonNoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MusteriID {
            get {
                return this.MusteriIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MusteriIDField, value) != true)) {
                    this.MusteriIDField = value;
                    this.RaisePropertyChanged("MusteriID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string MusteriAdi {
            get {
                return this.MusteriAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.MusteriAdiField, value) != true)) {
                    this.MusteriAdiField = value;
                    this.RaisePropertyChanged("MusteriAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string SirketAdi {
            get {
                return this.SirketAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.SirketAdiField, value) != true)) {
                    this.SirketAdiField = value;
                    this.RaisePropertyChanged("SirketAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TelefonNo {
            get {
                return this.TelefonNoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonNoField, value) != true)) {
                    this.TelefonNoField = value;
                    this.RaisePropertyChanged("TelefonNo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerWebServiceConsumer.CustomerWebServiceSoap")]
    public interface CustomerWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name MusteriGetirResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MusteriGetir", ReplyAction="*")]
        ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponse MusteriGetir(ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MusteriGetir", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponse> MusteriGetirAsync(ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MusteriGetirRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MusteriGetir", Namespace="http://tempuri.org/", Order=0)]
        public ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequestBody Body;
        
        public MusteriGetirRequest() {
        }
        
        public MusteriGetirRequest(ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MusteriGetirRequestBody {
        
        public MusteriGetirRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MusteriGetirResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MusteriGetirResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponseBody Body;
        
        public MusteriGetirResponse() {
        }
        
        public MusteriGetirResponse(ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MusteriGetirResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientProductWebService.CustomerWebServiceConsumer.MusteriSonuc[] MusteriGetirResult;
        
        public MusteriGetirResponseBody() {
        }
        
        public MusteriGetirResponseBody(ClientProductWebService.CustomerWebServiceConsumer.MusteriSonuc[] MusteriGetirResult) {
            this.MusteriGetirResult = MusteriGetirResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustomerWebServiceSoapChannel : ClientProductWebService.CustomerWebServiceConsumer.CustomerWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerWebServiceSoapClient : System.ServiceModel.ClientBase<ClientProductWebService.CustomerWebServiceConsumer.CustomerWebServiceSoap>, ClientProductWebService.CustomerWebServiceConsumer.CustomerWebServiceSoap {
        
        public CustomerWebServiceSoapClient() {
        }
        
        public CustomerWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponse ClientProductWebService.CustomerWebServiceConsumer.CustomerWebServiceSoap.MusteriGetir(ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest request) {
            return base.Channel.MusteriGetir(request);
        }
        
        public ClientProductWebService.CustomerWebServiceConsumer.MusteriSonuc[] MusteriGetir() {
            ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest inValue = new ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest();
            inValue.Body = new ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequestBody();
            ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponse retVal = ((ClientProductWebService.CustomerWebServiceConsumer.CustomerWebServiceSoap)(this)).MusteriGetir(inValue);
            return retVal.Body.MusteriGetirResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponse> ClientProductWebService.CustomerWebServiceConsumer.CustomerWebServiceSoap.MusteriGetirAsync(ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest request) {
            return base.Channel.MusteriGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirResponse> MusteriGetirAsync() {
            ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest inValue = new ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequest();
            inValue.Body = new ClientProductWebService.CustomerWebServiceConsumer.MusteriGetirRequestBody();
            return ((ClientProductWebService.CustomerWebServiceConsumer.CustomerWebServiceSoap)(this)).MusteriGetirAsync(inValue);
        }
    }
}