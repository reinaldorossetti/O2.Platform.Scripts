//O2Ref:System.Web.Services.dll
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.1432.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://tempuri.org/")]
public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback ExecuteCSharpCodeOperationCompleted;
    
    private System.Threading.SendOrPostCallback CurrentLogFile_PathOperationCompleted;
    
    private System.Threading.SendOrPostCallback CurrentLogFile_ContentsOperationCompleted;
    
    private System.Threading.SendOrPostCallback LogRequestOperationCompleted;
    
    private System.Threading.SendOrPostCallback SaveSnippetOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetO2LogsOperationCompleted;
    
    private System.Threading.SendOrPostCallback EmailSnippetToO2SupportOperationCompleted;
    
    /// <remarks/>
    public WebService() {
        this.Url = "http://localhost/csharprepl/CSharp_REPL.asmx";
    }
    
    /// <remarks/>
    public event ExecuteCSharpCodeCompletedEventHandler ExecuteCSharpCodeCompleted;
    
    /// <remarks/>
    public event CurrentLogFile_PathCompletedEventHandler CurrentLogFile_PathCompleted;
    
    /// <remarks/>
    public event CurrentLogFile_ContentsCompletedEventHandler CurrentLogFile_ContentsCompleted;
    
    /// <remarks/>
    public event LogRequestCompletedEventHandler LogRequestCompleted;
    
    /// <remarks/>
    public event SaveSnippetCompletedEventHandler SaveSnippetCompleted;
    
    /// <remarks/>
    public event GetO2LogsCompletedEventHandler GetO2LogsCompleted;
    
    /// <remarks/>
    public event EmailSnippetToO2SupportCompletedEventHandler EmailSnippetToO2SupportCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteCSharpCode", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string ExecuteCSharpCode(string snippet) {
        object[] results = this.Invoke("ExecuteCSharpCode", new object[] {
                    snippet});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginExecuteCSharpCode(string snippet, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ExecuteCSharpCode", new object[] {
                    snippet}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndExecuteCSharpCode(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void ExecuteCSharpCodeAsync(string snippet) {
        this.ExecuteCSharpCodeAsync(snippet, null);
    }
    
    /// <remarks/>
    public void ExecuteCSharpCodeAsync(string snippet, object userState) {
        if ((this.ExecuteCSharpCodeOperationCompleted == null)) {
            this.ExecuteCSharpCodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteCSharpCodeOperationCompleted);
        }
        this.InvokeAsync("ExecuteCSharpCode", new object[] {
                    snippet}, this.ExecuteCSharpCodeOperationCompleted, userState);
    }
    
    private void OnExecuteCSharpCodeOperationCompleted(object arg) {
        if ((this.ExecuteCSharpCodeCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ExecuteCSharpCodeCompleted(this, new ExecuteCSharpCodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CurrentLogFile_Path", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string CurrentLogFile_Path() {
        object[] results = this.Invoke("CurrentLogFile_Path", new object[0]);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginCurrentLogFile_Path(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CurrentLogFile_Path", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string EndCurrentLogFile_Path(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void CurrentLogFile_PathAsync() {
        this.CurrentLogFile_PathAsync(null);
    }
    
    /// <remarks/>
    public void CurrentLogFile_PathAsync(object userState) {
        if ((this.CurrentLogFile_PathOperationCompleted == null)) {
            this.CurrentLogFile_PathOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCurrentLogFile_PathOperationCompleted);
        }
        this.InvokeAsync("CurrentLogFile_Path", new object[0], this.CurrentLogFile_PathOperationCompleted, userState);
    }
    
    private void OnCurrentLogFile_PathOperationCompleted(object arg) {
        if ((this.CurrentLogFile_PathCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CurrentLogFile_PathCompleted(this, new CurrentLogFile_PathCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CurrentLogFile_Contents", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public LogEntry[] CurrentLogFile_Contents() {
        object[] results = this.Invoke("CurrentLogFile_Contents", new object[0]);
        return ((LogEntry[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginCurrentLogFile_Contents(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CurrentLogFile_Contents", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public LogEntry[] EndCurrentLogFile_Contents(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((LogEntry[])(results[0]));
    }
    
    /// <remarks/>
    public void CurrentLogFile_ContentsAsync() {
        this.CurrentLogFile_ContentsAsync(null);
    }
    
    /// <remarks/>
    public void CurrentLogFile_ContentsAsync(object userState) {
        if ((this.CurrentLogFile_ContentsOperationCompleted == null)) {
            this.CurrentLogFile_ContentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCurrentLogFile_ContentsOperationCompleted);
        }
        this.InvokeAsync("CurrentLogFile_Contents", new object[0], this.CurrentLogFile_ContentsOperationCompleted, userState);
    }
    
    private void OnCurrentLogFile_ContentsOperationCompleted(object arg) {
        if ((this.CurrentLogFile_ContentsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CurrentLogFile_ContentsCompleted(this, new CurrentLogFile_ContentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LogRequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public LogEntry LogRequest(string snippet) {
        object[] results = this.Invoke("LogRequest", new object[] {
                    snippet});
        return ((LogEntry)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginLogRequest(string snippet, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("LogRequest", new object[] {
                    snippet}, callback, asyncState);
    }
    
    /// <remarks/>
    public LogEntry EndLogRequest(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((LogEntry)(results[0]));
    }
    
    /// <remarks/>
    public void LogRequestAsync(string snippet) {
        this.LogRequestAsync(snippet, null);
    }
    
    /// <remarks/>
    public void LogRequestAsync(string snippet, object userState) {
        if ((this.LogRequestOperationCompleted == null)) {
            this.LogRequestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogRequestOperationCompleted);
        }
        this.InvokeAsync("LogRequest", new object[] {
                    snippet}, this.LogRequestOperationCompleted, userState);
    }
    
    private void OnLogRequestOperationCompleted(object arg) {
        if ((this.LogRequestCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.LogRequestCompleted(this, new LogRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveSnippet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int SaveSnippet(string snippet) {
        object[] results = this.Invoke("SaveSnippet", new object[] {
                    snippet});
        return ((int)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSaveSnippet(string snippet, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SaveSnippet", new object[] {
                    snippet}, callback, asyncState);
    }
    
    /// <remarks/>
    public int EndSaveSnippet(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }
    
    /// <remarks/>
    public void SaveSnippetAsync(string snippet) {
        this.SaveSnippetAsync(snippet, null);
    }
    
    /// <remarks/>
    public void SaveSnippetAsync(string snippet, object userState) {
        if ((this.SaveSnippetOperationCompleted == null)) {
            this.SaveSnippetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveSnippetOperationCompleted);
        }
        this.InvokeAsync("SaveSnippet", new object[] {
                    snippet}, this.SaveSnippetOperationCompleted, userState);
    }
    
    private void OnSaveSnippetOperationCompleted(object arg) {
        if ((this.SaveSnippetCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SaveSnippetCompleted(this, new SaveSnippetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetO2Logs", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string GetO2Logs() {
        object[] results = this.Invoke("GetO2Logs", new object[0]);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetO2Logs(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetO2Logs", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string EndGetO2Logs(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void GetO2LogsAsync() {
        this.GetO2LogsAsync(null);
    }
    
    /// <remarks/>
    public void GetO2LogsAsync(object userState) {
        if ((this.GetO2LogsOperationCompleted == null)) {
            this.GetO2LogsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetO2LogsOperationCompleted);
        }
        this.InvokeAsync("GetO2Logs", new object[0], this.GetO2LogsOperationCompleted, userState);
    }
    
    private void OnGetO2LogsOperationCompleted(object arg) {
        if ((this.GetO2LogsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetO2LogsCompleted(this, new GetO2LogsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EmailSnippetToO2Support", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void EmailSnippetToO2Support(string subject, string snippet) {
        this.Invoke("EmailSnippetToO2Support", new object[] {
                    subject,
                    snippet});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginEmailSnippetToO2Support(string subject, string snippet, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("EmailSnippetToO2Support", new object[] {
                    subject,
                    snippet}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndEmailSnippetToO2Support(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    public void EmailSnippetToO2SupportAsync(string subject, string snippet) {
        this.EmailSnippetToO2SupportAsync(subject, snippet, null);
    }
    
    /// <remarks/>
    public void EmailSnippetToO2SupportAsync(string subject, string snippet, object userState) {
        if ((this.EmailSnippetToO2SupportOperationCompleted == null)) {
            this.EmailSnippetToO2SupportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEmailSnippetToO2SupportOperationCompleted);
        }
        this.InvokeAsync("EmailSnippetToO2Support", new object[] {
                    subject,
                    snippet}, this.EmailSnippetToO2SupportOperationCompleted, userState);
    }
    
    private void OnEmailSnippetToO2SupportOperationCompleted(object arg) {
        if ((this.EmailSnippetToO2SupportCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.EmailSnippetToO2SupportCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
public partial class LogEntry {
    
    private string reffererField;
    
    private string snippetField;
    
    private string ipField;
    
    private string userAgentField;
    
    private string hostNameField;
    
    private string requestedAtField;
    
    private string cookiesField;
    
    private string headersField;
    
    /// <remarks/>
    public string Refferer {
        get {
            return this.reffererField;
        }
        set {
            this.reffererField = value;
        }
    }
    
    /// <remarks/>
    public string Snippet {
        get {
            return this.snippetField;
        }
        set {
            this.snippetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IP {
        get {
            return this.ipField;
        }
        set {
            this.ipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserAgent {
        get {
            return this.userAgentField;
        }
        set {
            this.userAgentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string HostName {
        get {
            return this.hostNameField;
        }
        set {
            this.hostNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RequestedAt {
        get {
            return this.requestedAtField;
        }
        set {
            this.requestedAtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Cookies {
        get {
            return this.cookiesField;
        }
        set {
            this.cookiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Headers {
        get {
            return this.headersField;
        }
        set {
            this.headersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void ExecuteCSharpCodeCompletedEventHandler(object sender, ExecuteCSharpCodeCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ExecuteCSharpCodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ExecuteCSharpCodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void CurrentLogFile_PathCompletedEventHandler(object sender, CurrentLogFile_PathCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CurrentLogFile_PathCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal CurrentLogFile_PathCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void CurrentLogFile_ContentsCompletedEventHandler(object sender, CurrentLogFile_ContentsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CurrentLogFile_ContentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal CurrentLogFile_ContentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public LogEntry[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((LogEntry[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void LogRequestCompletedEventHandler(object sender, LogRequestCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class LogRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal LogRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public LogEntry Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((LogEntry)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void SaveSnippetCompletedEventHandler(object sender, SaveSnippetCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SaveSnippetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SaveSnippetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void GetO2LogsCompletedEventHandler(object sender, GetO2LogsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetO2LogsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetO2LogsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void EmailSnippetToO2SupportCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
