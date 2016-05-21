// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ibrahimapp.locatservice {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    using System.Data;
    
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServicetestingSoap", Namespace="http://tempuri.org/")]
    public partial class WebServicetesting : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertnewuserOperationCompleted;
        
        private System.Threading.SendOrPostCallback updatenewuserOperationCompleted;
        
        private System.Threading.SendOrPostCallback allusersOperationCompleted;
        
        /// CodeRemarks
        public WebServicetesting() {
            this.Url = "http://192.168.0.46/webtesting/WebServicetesting.asmx";
        }
        
        public WebServicetesting(string url) {
            this.Url = url;
        }
        
        /// CodeRemarks
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// CodeRemarks
        public event insertnewuserCompletedEventHandler insertnewuserCompleted;
        
        /// CodeRemarks
        public event updatenewuserCompletedEventHandler updatenewuserCompleted;
        
        /// CodeRemarks
        public event allusersCompletedEventHandler allusersCompleted;
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// CodeRemarks
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// CodeRemarks
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/insertnewuser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string insertnewuser(string username) {
            object[] results = this.Invoke("insertnewuser", new object[] {
                        username});
            return ((string)(results[0]));
        }
        
        /// CodeRemarks
        public void insertnewuserAsync(string username) {
            this.insertnewuserAsync(username, null);
        }
        
        /// CodeRemarks
        public void insertnewuserAsync(string username, object userState) {
            if ((this.insertnewuserOperationCompleted == null)) {
                this.insertnewuserOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertnewuserOperationCompleted);
            }
            this.InvokeAsync("insertnewuser", new object[] {
                        username}, this.insertnewuserOperationCompleted, userState);
        }
        
        private void OninsertnewuserOperationCompleted(object arg) {
            if ((this.insertnewuserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertnewuserCompleted(this, new insertnewuserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updatenewuser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string updatenewuser(string username, int numid) {
            object[] results = this.Invoke("updatenewuser", new object[] {
                        username,
                        numid});
            return ((string)(results[0]));
        }
        
        /// CodeRemarks
        public void updatenewuserAsync(string username, int numid) {
            this.updatenewuserAsync(username, numid, null);
        }
        
        /// CodeRemarks
        public void updatenewuserAsync(string username, int numid, object userState) {
            if ((this.updatenewuserOperationCompleted == null)) {
                this.updatenewuserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdatenewuserOperationCompleted);
            }
            this.InvokeAsync("updatenewuser", new object[] {
                        username,
                        numid}, this.updatenewuserOperationCompleted, userState);
        }
        
        private void OnupdatenewuserOperationCompleted(object arg) {
            if ((this.updatenewuserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updatenewuserCompleted(this, new updatenewuserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/allusers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable allusers() {
            object[] results = this.Invoke("allusers", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// CodeRemarks
        public void allusersAsync() {
            this.allusersAsync(null);
        }
        
        /// CodeRemarks
        public void allusersAsync(object userState) {
            if ((this.allusersOperationCompleted == null)) {
                this.allusersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnallusersOperationCompleted);
            }
            this.InvokeAsync("allusers", new object[0], this.allusersOperationCompleted, userState);
        }
        
        private void OnallusersOperationCompleted(object arg) {
            if ((this.allusersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.allusersCompleted(this, new allusersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// CodeRemarks
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// CodeRemarks
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    public delegate void insertnewuserCompletedEventHandler(object sender, insertnewuserCompletedEventArgs e);
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertnewuserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertnewuserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// CodeRemarks
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    public delegate void updatenewuserCompletedEventHandler(object sender, updatenewuserCompletedEventArgs e);
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updatenewuserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updatenewuserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// CodeRemarks
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    public delegate void allusersCompletedEventHandler(object sender, allusersCompletedEventArgs e);
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class allusersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal allusersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// CodeRemarks
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}
