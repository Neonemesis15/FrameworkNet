using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;
using System.ServiceModel.Configuration;
using System.ServiceModel.Dispatcher;
using log4net;
using System.ServiceModel;

namespace Lucky.CFG.JavaMovil
{
    public class LogExtension : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {

        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new MessageInspectorCustom());
        }

        public void Validate(ServiceEndpoint endpoint)
        {

        }
    }

    public class LogBehaviorExtensionElement : BehaviorExtensionElement
    {

        public override Type BehaviorType
        {
            get { return typeof(LogExtension); }
        }

        protected override object CreateBehavior()
        {
            return new LogExtension();
        }
    }
    public class MessageInspectorCustom : IDispatchMessageInspector
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogExtension));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            if (isDebugEnabled)
                log.Debug(request.ToString());

            return request;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {

            if (isDebugEnabled)
            {
                System.ServiceModel.Channels.MessageBuffer buffer = reply.CreateBufferedCopy(Int32.MaxValue);
                reply = buffer.CreateMessage();
                log.Debug(buffer.CreateMessage().GetBody<string>());
            }
        }
    }
}
