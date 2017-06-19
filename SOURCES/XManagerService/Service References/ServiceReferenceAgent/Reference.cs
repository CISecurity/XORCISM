﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XManagerService.ServiceReferenceAgent {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceAgent.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LaunchJob", ReplyAction="http://tempuri.org/IService1/LaunchJobResponse")]
        void LaunchJob(System.Guid userID, int jobID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/LaunchJob", ReplyAction="http://tempuri.org/IService1/LaunchJobResponse")]
        System.IAsyncResult BeginLaunchJob(System.Guid userID, int jobID, System.AsyncCallback callback, object asyncState);
        
        void EndLaunchJob(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancelJob", ReplyAction="http://tempuri.org/IService1/CancelJobResponse")]
        bool CancelJob(int jobID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/CancelJob", ReplyAction="http://tempuri.org/IService1/CancelJobResponse")]
        System.IAsyncResult BeginCancelJob(int jobID, System.AsyncCallback callback, object asyncState);
        
        bool EndCancelJob(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : XManagerService.ServiceReferenceAgent.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CancelJobCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CancelJobCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<XManagerService.ServiceReferenceAgent.IService1>, XManagerService.ServiceReferenceAgent.IService1 {
        
        private BeginOperationDelegate onBeginLaunchJobDelegate;
        
        private EndOperationDelegate onEndLaunchJobDelegate;
        
        private System.Threading.SendOrPostCallback onLaunchJobCompletedDelegate;
        
        private BeginOperationDelegate onBeginCancelJobDelegate;
        
        private EndOperationDelegate onEndCancelJobDelegate;
        
        private System.Threading.SendOrPostCallback onCancelJobCompletedDelegate;
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> LaunchJobCompleted;
        
        public event System.EventHandler<CancelJobCompletedEventArgs> CancelJobCompleted;
        
        public void LaunchJob(System.Guid userID, int jobID) {
            base.Channel.LaunchJob(userID, jobID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginLaunchJob(System.Guid userID, int jobID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginLaunchJob(userID, jobID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndLaunchJob(System.IAsyncResult result) {
            base.Channel.EndLaunchJob(result);
        }
        
        private System.IAsyncResult OnBeginLaunchJob(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Guid userID = ((System.Guid)(inValues[0]));
            int jobID = ((int)(inValues[1]));
            return this.BeginLaunchJob(userID, jobID, callback, asyncState);
        }
        
        private object[] OnEndLaunchJob(System.IAsyncResult result) {
            this.EndLaunchJob(result);
            return null;
        }
        
        private void OnLaunchJobCompleted(object state) {
            if ((this.LaunchJobCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.LaunchJobCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void LaunchJobAsync(System.Guid userID, int jobID) {
            this.LaunchJobAsync(userID, jobID, null);
        }
        
        public void LaunchJobAsync(System.Guid userID, int jobID, object userState) {
            if ((this.onBeginLaunchJobDelegate == null)) {
                this.onBeginLaunchJobDelegate = new BeginOperationDelegate(this.OnBeginLaunchJob);
            }
            if ((this.onEndLaunchJobDelegate == null)) {
                this.onEndLaunchJobDelegate = new EndOperationDelegate(this.OnEndLaunchJob);
            }
            if ((this.onLaunchJobCompletedDelegate == null)) {
                this.onLaunchJobCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnLaunchJobCompleted);
            }
            base.InvokeAsync(this.onBeginLaunchJobDelegate, new object[] {
                        userID,
                        jobID}, this.onEndLaunchJobDelegate, this.onLaunchJobCompletedDelegate, userState);
        }
        
        public bool CancelJob(int jobID) {
            return base.Channel.CancelJob(jobID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginCancelJob(int jobID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCancelJob(jobID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool EndCancelJob(System.IAsyncResult result) {
            return base.Channel.EndCancelJob(result);
        }
        
        private System.IAsyncResult OnBeginCancelJob(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int jobID = ((int)(inValues[0]));
            return this.BeginCancelJob(jobID, callback, asyncState);
        }
        
        private object[] OnEndCancelJob(System.IAsyncResult result) {
            bool retVal = this.EndCancelJob(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCancelJobCompleted(object state) {
            if ((this.CancelJobCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CancelJobCompleted(this, new CancelJobCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CancelJobAsync(int jobID) {
            this.CancelJobAsync(jobID, null);
        }
        
        public void CancelJobAsync(int jobID, object userState) {
            if ((this.onBeginCancelJobDelegate == null)) {
                this.onBeginCancelJobDelegate = new BeginOperationDelegate(this.OnBeginCancelJob);
            }
            if ((this.onEndCancelJobDelegate == null)) {
                this.onEndCancelJobDelegate = new EndOperationDelegate(this.OnEndCancelJob);
            }
            if ((this.onCancelJobCompletedDelegate == null)) {
                this.onCancelJobCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCancelJobCompleted);
            }
            base.InvokeAsync(this.onBeginCancelJobDelegate, new object[] {
                        jobID}, this.onEndCancelJobDelegate, this.onCancelJobCompletedDelegate, userState);
        }
    }
}