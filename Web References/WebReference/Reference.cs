﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace IpPbxCtiTest.WebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetRecordFileInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertBlacklistOperationCompleted;
        
        private System.Threading.SendOrPostCallback SelectBlackListOperationCompleted;
        
        private System.Threading.SendOrPostCallback RecordCountOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::IpPbxCtiTest.Properties.Settings.Default.IpPbxCtiTest_WebReference_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetRecordFileInfoCompletedEventHandler GetRecordFileInfoCompleted;
        
        /// <remarks/>
        public event InsertBlacklistCompletedEventHandler InsertBlacklistCompleted;
        
        /// <remarks/>
        public event SelectBlackListCompletedEventHandler SelectBlackListCompleted;
        
        /// <remarks/>
        public event RecordCountCompletedEventHandler RecordCountCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRecordFileInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRecordFileInfo(string callID) {
            object[] results = this.Invoke("GetRecordFileInfo", new object[] {
                        callID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetRecordFileInfoAsync(string callID) {
            this.GetRecordFileInfoAsync(callID, null);
        }
        
        /// <remarks/>
        public void GetRecordFileInfoAsync(string callID, object userState) {
            if ((this.GetRecordFileInfoOperationCompleted == null)) {
                this.GetRecordFileInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRecordFileInfoOperationCompleted);
            }
            this.InvokeAsync("GetRecordFileInfo", new object[] {
                        callID}, this.GetRecordFileInfoOperationCompleted, userState);
        }
        
        private void OnGetRecordFileInfoOperationCompleted(object arg) {
            if ((this.GetRecordFileInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRecordFileInfoCompleted(this, new GetRecordFileInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertBlacklist", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool InsertBlacklist(string number, string beginTime, string endTime, string cause, string agentID) {
            object[] results = this.Invoke("InsertBlacklist", new object[] {
                        number,
                        beginTime,
                        endTime,
                        cause,
                        agentID});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void InsertBlacklistAsync(string number, string beginTime, string endTime, string cause, string agentID) {
            this.InsertBlacklistAsync(number, beginTime, endTime, cause, agentID, null);
        }
        
        /// <remarks/>
        public void InsertBlacklistAsync(string number, string beginTime, string endTime, string cause, string agentID, object userState) {
            if ((this.InsertBlacklistOperationCompleted == null)) {
                this.InsertBlacklistOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertBlacklistOperationCompleted);
            }
            this.InvokeAsync("InsertBlacklist", new object[] {
                        number,
                        beginTime,
                        endTime,
                        cause,
                        agentID}, this.InsertBlacklistOperationCompleted, userState);
        }
        
        private void OnInsertBlacklistOperationCompleted(object arg) {
            if ((this.InsertBlacklistCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertBlacklistCompleted(this, new InsertBlacklistCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectBlackList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SelectBlackList(int index, int pageSize, string condition) {
            object[] results = this.Invoke("SelectBlackList", new object[] {
                        index,
                        pageSize,
                        condition});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SelectBlackListAsync(int index, int pageSize, string condition) {
            this.SelectBlackListAsync(index, pageSize, condition, null);
        }
        
        /// <remarks/>
        public void SelectBlackListAsync(int index, int pageSize, string condition, object userState) {
            if ((this.SelectBlackListOperationCompleted == null)) {
                this.SelectBlackListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectBlackListOperationCompleted);
            }
            this.InvokeAsync("SelectBlackList", new object[] {
                        index,
                        pageSize,
                        condition}, this.SelectBlackListOperationCompleted, userState);
        }
        
        private void OnSelectBlackListOperationCompleted(object arg) {
            if ((this.SelectBlackListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectBlackListCompleted(this, new SelectBlackListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecordCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int RecordCount(string condition) {
            object[] results = this.Invoke("RecordCount", new object[] {
                        condition});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void RecordCountAsync(string condition) {
            this.RecordCountAsync(condition, null);
        }
        
        /// <remarks/>
        public void RecordCountAsync(string condition, object userState) {
            if ((this.RecordCountOperationCompleted == null)) {
                this.RecordCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecordCountOperationCompleted);
            }
            this.InvokeAsync("RecordCount", new object[] {
                        condition}, this.RecordCountOperationCompleted, userState);
        }
        
        private void OnRecordCountOperationCompleted(object arg) {
            if ((this.RecordCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecordCountCompleted(this, new RecordCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRecordFileInfoCompletedEventHandler(object sender, GetRecordFileInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRecordFileInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRecordFileInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void InsertBlacklistCompletedEventHandler(object sender, InsertBlacklistCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertBlacklistCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertBlacklistCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SelectBlackListCompletedEventHandler(object sender, SelectBlackListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectBlackListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectBlackListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RecordCountCompletedEventHandler(object sender, RecordCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RecordCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RecordCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591