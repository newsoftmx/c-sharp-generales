﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.4927
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.4927.
// 
#pragma warning disable 1591

namespace Invocacion_ABCMV.WS_Javier {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Do_GuardarOperationCompleted;
        
        private System.Threading.SendOrPostCallback Do_EliminarOperationCompleted;
        
        private System.Threading.SendOrPostCallback Do_ActualizarOperationCompleted;
        
        private System.Threading.SendOrPostCallback Do_VerificarOperationCompleted;
        
        private System.Threading.SendOrPostCallback Do_BuscarTodoOperationCompleted;
        
        private System.Threading.SendOrPostCallback Do_BuscarRegistroOperationCompleted;
        
        private System.Threading.SendOrPostCallback Do_BuscarSaldoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::Invocacion_ABCMV.Properties.Settings.Default.Invocacion_ABCMV_WS_Javier_Service;
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
        public event Do_GuardarCompletedEventHandler Do_GuardarCompleted;
        
        /// <remarks/>
        public event Do_EliminarCompletedEventHandler Do_EliminarCompleted;
        
        /// <remarks/>
        public event Do_ActualizarCompletedEventHandler Do_ActualizarCompleted;
        
        /// <remarks/>
        public event Do_VerificarCompletedEventHandler Do_VerificarCompleted;
        
        /// <remarks/>
        public event Do_BuscarTodoCompletedEventHandler Do_BuscarTodoCompleted;
        
        /// <remarks/>
        public event Do_BuscarRegistroCompletedEventHandler Do_BuscarRegistroCompleted;
        
        /// <remarks/>
        public event Do_BuscarSaldoCompletedEventHandler Do_BuscarSaldoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Do_Guardar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Do_Guardar(string p_strNombre, string p_strDomicilio, string p_strTelefono, int p_intEdad, double p_dblSaldo) {
            object[] results = this.Invoke("Do_Guardar", new object[] {
                        p_strNombre,
                        p_strDomicilio,
                        p_strTelefono,
                        p_intEdad,
                        p_dblSaldo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Do_GuardarAsync(string p_strNombre, string p_strDomicilio, string p_strTelefono, int p_intEdad, double p_dblSaldo) {
            this.Do_GuardarAsync(p_strNombre, p_strDomicilio, p_strTelefono, p_intEdad, p_dblSaldo, null);
        }
        
        /// <remarks/>
        public void Do_GuardarAsync(string p_strNombre, string p_strDomicilio, string p_strTelefono, int p_intEdad, double p_dblSaldo, object userState) {
            if ((this.Do_GuardarOperationCompleted == null)) {
                this.Do_GuardarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDo_GuardarOperationCompleted);
            }
            this.InvokeAsync("Do_Guardar", new object[] {
                        p_strNombre,
                        p_strDomicilio,
                        p_strTelefono,
                        p_intEdad,
                        p_dblSaldo}, this.Do_GuardarOperationCompleted, userState);
        }
        
        private void OnDo_GuardarOperationCompleted(object arg) {
            if ((this.Do_GuardarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Do_GuardarCompleted(this, new Do_GuardarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Do_Eliminar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Do_Eliminar(int p_intID) {
            object[] results = this.Invoke("Do_Eliminar", new object[] {
                        p_intID});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Do_EliminarAsync(int p_intID) {
            this.Do_EliminarAsync(p_intID, null);
        }
        
        /// <remarks/>
        public void Do_EliminarAsync(int p_intID, object userState) {
            if ((this.Do_EliminarOperationCompleted == null)) {
                this.Do_EliminarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDo_EliminarOperationCompleted);
            }
            this.InvokeAsync("Do_Eliminar", new object[] {
                        p_intID}, this.Do_EliminarOperationCompleted, userState);
        }
        
        private void OnDo_EliminarOperationCompleted(object arg) {
            if ((this.Do_EliminarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Do_EliminarCompleted(this, new Do_EliminarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Do_Actualizar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Do_Actualizar(int p_intID, string p_strNombre, string p_strDomicilio, string p_strTelefono, int p_intEdad, double p_dblSaldo) {
            object[] results = this.Invoke("Do_Actualizar", new object[] {
                        p_intID,
                        p_strNombre,
                        p_strDomicilio,
                        p_strTelefono,
                        p_intEdad,
                        p_dblSaldo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Do_ActualizarAsync(int p_intID, string p_strNombre, string p_strDomicilio, string p_strTelefono, int p_intEdad, double p_dblSaldo) {
            this.Do_ActualizarAsync(p_intID, p_strNombre, p_strDomicilio, p_strTelefono, p_intEdad, p_dblSaldo, null);
        }
        
        /// <remarks/>
        public void Do_ActualizarAsync(int p_intID, string p_strNombre, string p_strDomicilio, string p_strTelefono, int p_intEdad, double p_dblSaldo, object userState) {
            if ((this.Do_ActualizarOperationCompleted == null)) {
                this.Do_ActualizarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDo_ActualizarOperationCompleted);
            }
            this.InvokeAsync("Do_Actualizar", new object[] {
                        p_intID,
                        p_strNombre,
                        p_strDomicilio,
                        p_strTelefono,
                        p_intEdad,
                        p_dblSaldo}, this.Do_ActualizarOperationCompleted, userState);
        }
        
        private void OnDo_ActualizarOperationCompleted(object arg) {
            if ((this.Do_ActualizarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Do_ActualizarCompleted(this, new Do_ActualizarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Do_Verificar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Do_Verificar(int p_intID) {
            object[] results = this.Invoke("Do_Verificar", new object[] {
                        p_intID});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Do_VerificarAsync(int p_intID) {
            this.Do_VerificarAsync(p_intID, null);
        }
        
        /// <remarks/>
        public void Do_VerificarAsync(int p_intID, object userState) {
            if ((this.Do_VerificarOperationCompleted == null)) {
                this.Do_VerificarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDo_VerificarOperationCompleted);
            }
            this.InvokeAsync("Do_Verificar", new object[] {
                        p_intID}, this.Do_VerificarOperationCompleted, userState);
        }
        
        private void OnDo_VerificarOperationCompleted(object arg) {
            if ((this.Do_VerificarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Do_VerificarCompleted(this, new Do_VerificarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Do_BuscarTodo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Do_BuscarTodo() {
            object[] results = this.Invoke("Do_BuscarTodo", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void Do_BuscarTodoAsync() {
            this.Do_BuscarTodoAsync(null);
        }
        
        /// <remarks/>
        public void Do_BuscarTodoAsync(object userState) {
            if ((this.Do_BuscarTodoOperationCompleted == null)) {
                this.Do_BuscarTodoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDo_BuscarTodoOperationCompleted);
            }
            this.InvokeAsync("Do_BuscarTodo", new object[0], this.Do_BuscarTodoOperationCompleted, userState);
        }
        
        private void OnDo_BuscarTodoOperationCompleted(object arg) {
            if ((this.Do_BuscarTodoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Do_BuscarTodoCompleted(this, new Do_BuscarTodoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Do_BuscarRegistro", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Do_BuscarRegistro(int p_intID) {
            object[] results = this.Invoke("Do_BuscarRegistro", new object[] {
                        p_intID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void Do_BuscarRegistroAsync(int p_intID) {
            this.Do_BuscarRegistroAsync(p_intID, null);
        }
        
        /// <remarks/>
        public void Do_BuscarRegistroAsync(int p_intID, object userState) {
            if ((this.Do_BuscarRegistroOperationCompleted == null)) {
                this.Do_BuscarRegistroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDo_BuscarRegistroOperationCompleted);
            }
            this.InvokeAsync("Do_BuscarRegistro", new object[] {
                        p_intID}, this.Do_BuscarRegistroOperationCompleted, userState);
        }
        
        private void OnDo_BuscarRegistroOperationCompleted(object arg) {
            if ((this.Do_BuscarRegistroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Do_BuscarRegistroCompleted(this, new Do_BuscarRegistroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Do_BuscarSaldo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Do_BuscarSaldo(int p_intID) {
            object[] results = this.Invoke("Do_BuscarSaldo", new object[] {
                        p_intID});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void Do_BuscarSaldoAsync(int p_intID) {
            this.Do_BuscarSaldoAsync(p_intID, null);
        }
        
        /// <remarks/>
        public void Do_BuscarSaldoAsync(int p_intID, object userState) {
            if ((this.Do_BuscarSaldoOperationCompleted == null)) {
                this.Do_BuscarSaldoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDo_BuscarSaldoOperationCompleted);
            }
            this.InvokeAsync("Do_BuscarSaldo", new object[] {
                        p_intID}, this.Do_BuscarSaldoOperationCompleted, userState);
        }
        
        private void OnDo_BuscarSaldoOperationCompleted(object arg) {
            if ((this.Do_BuscarSaldoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Do_BuscarSaldoCompleted(this, new Do_BuscarSaldoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void Do_GuardarCompletedEventHandler(object sender, Do_GuardarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Do_GuardarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Do_GuardarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void Do_EliminarCompletedEventHandler(object sender, Do_EliminarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Do_EliminarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Do_EliminarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void Do_ActualizarCompletedEventHandler(object sender, Do_ActualizarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Do_ActualizarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Do_ActualizarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void Do_VerificarCompletedEventHandler(object sender, Do_VerificarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Do_VerificarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Do_VerificarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void Do_BuscarTodoCompletedEventHandler(object sender, Do_BuscarTodoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Do_BuscarTodoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Do_BuscarTodoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void Do_BuscarRegistroCompletedEventHandler(object sender, Do_BuscarRegistroCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Do_BuscarRegistroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Do_BuscarRegistroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void Do_BuscarSaldoCompletedEventHandler(object sender, Do_BuscarSaldoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Do_BuscarSaldoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Do_BuscarSaldoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591