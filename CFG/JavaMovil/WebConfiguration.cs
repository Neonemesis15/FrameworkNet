using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Web;
using System.Net;

namespace Lucky.CFG.JavaMovil
{
    public static class WebConfiguration
    {
        public static void SetDefaultHeader(WebOperationContext context)
        {
            context.OutgoingResponse.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
            context.OutgoingResponse.Headers.Add(HttpResponseHeader.ContentType, " application/xml; charset=utf-8");
        }
    }
}
