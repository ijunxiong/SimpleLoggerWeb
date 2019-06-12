using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleLoggerWeb
{
    public class LogRegister
    {
        public static void Log4NetRegister()
        {
            var log4netFile = System.Web.HttpContext.Current.Server.MapPath("/") + System.Configuration.ConfigurationManager.AppSettings["log4net.Config"];
            if (!System.IO.File.Exists(log4netFile)) return;
            log4net.Config.XmlConfigurator.ConfigureAndWatch(
                new System.IO.FileInfo(log4netFile)
                );
        }
    }
}