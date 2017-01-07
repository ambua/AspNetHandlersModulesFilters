using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpHandlersAndModules.Handlers
{
    public class MyErrorHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Debug.WriteLine("Oh no error: {0}", filterContext.Exception);
            base.OnException(filterContext);
        }


    }
}