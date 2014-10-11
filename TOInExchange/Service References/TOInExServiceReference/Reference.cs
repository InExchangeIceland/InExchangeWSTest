﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TOInExchange.TOInExServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reply", Namespace="http://schemas.datacontract.org/2004/07/InExchange.InvoiceService")]
    [System.SerializableAttribute()]
    public partial class Reply : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReturnCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReturnStringField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReturnCode {
            get {
                return this.ReturnCodeField;
            }
            set {
                if ((this.ReturnCodeField.Equals(value) != true)) {
                    this.ReturnCodeField = value;
                    this.RaisePropertyChanged("ReturnCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnString {
            get {
                return this.ReturnStringField;
            }
            set {
                if ((object.ReferenceEquals(this.ReturnStringField, value) != true)) {
                    this.ReturnStringField = value;
                    this.RaisePropertyChanged("ReturnString");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PartyIdentifierTypes", Namespace="http://schemas.datacontract.org/2004/07/InExchange.InvoiceService")]
    public enum PartyIdentifierTypes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IS_KT = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GLN = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://inexchange.com", ConfigurationName="TOInExServiceReference.IInvoiceService")]
    public interface IInvoiceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://inexchange.com/IInvoiceService/InvoiceToInExchange", ReplyAction="http://inexchange.com/IInvoiceService/InvoiceToInExchangeResponse")]
        TOInExchange.TOInExServiceReference.Reply InvoiceToInExchange(string Username, string Password, string Subaccount, string Filename, byte[] Invoice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://inexchange.com/IInvoiceService/InvoiceToInExchange", ReplyAction="http://inexchange.com/IInvoiceService/InvoiceToInExchangeResponse")]
        System.Threading.Tasks.Task<TOInExchange.TOInExServiceReference.Reply> InvoiceToInExchangeAsync(string Username, string Password, string Subaccount, string Filename, byte[] Invoice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://inexchange.com/IInvoiceService/HelloWorld", ReplyAction="http://inexchange.com/IInvoiceService/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://inexchange.com/IInvoiceService/HelloWorld", ReplyAction="http://inexchange.com/IInvoiceService/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://inexchange.com/IInvoiceService/IsRecipient", ReplyAction="http://inexchange.com/IInvoiceService/IsRecipientResponse")]
        bool IsRecipient(string Username, string Password, string ReceiverPartyIdentifier, TOInExchange.TOInExServiceReference.PartyIdentifierTypes ReceiverPartyIdentifierType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://inexchange.com/IInvoiceService/IsRecipient", ReplyAction="http://inexchange.com/IInvoiceService/IsRecipientResponse")]
        System.Threading.Tasks.Task<bool> IsRecipientAsync(string Username, string Password, string ReceiverPartyIdentifier, TOInExchange.TOInExServiceReference.PartyIdentifierTypes ReceiverPartyIdentifierType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInvoiceServiceChannel : TOInExchange.TOInExServiceReference.IInvoiceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InvoiceServiceClient : System.ServiceModel.ClientBase<TOInExchange.TOInExServiceReference.IInvoiceService>, TOInExchange.TOInExServiceReference.IInvoiceService {
        
        public InvoiceServiceClient() {
        }
        
        public InvoiceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InvoiceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InvoiceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InvoiceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TOInExchange.TOInExServiceReference.Reply InvoiceToInExchange(string Username, string Password, string Subaccount, string Filename, byte[] Invoice) {
            return base.Channel.InvoiceToInExchange(Username, Password, Subaccount, Filename, Invoice);
        }
        
        public System.Threading.Tasks.Task<TOInExchange.TOInExServiceReference.Reply> InvoiceToInExchangeAsync(string Username, string Password, string Subaccount, string Filename, byte[] Invoice) {
            return base.Channel.InvoiceToInExchangeAsync(Username, Password, Subaccount, Filename, Invoice);
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public bool IsRecipient(string Username, string Password, string ReceiverPartyIdentifier, TOInExchange.TOInExServiceReference.PartyIdentifierTypes ReceiverPartyIdentifierType) {
            return base.Channel.IsRecipient(Username, Password, ReceiverPartyIdentifier, ReceiverPartyIdentifierType);
        }
        
        public System.Threading.Tasks.Task<bool> IsRecipientAsync(string Username, string Password, string ReceiverPartyIdentifier, TOInExchange.TOInExServiceReference.PartyIdentifierTypes ReceiverPartyIdentifierType) {
            return base.Channel.IsRecipientAsync(Username, Password, ReceiverPartyIdentifier, ReceiverPartyIdentifierType);
        }
    }
}
