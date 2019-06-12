using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleLoggerWeb.Controllers
{
    public class HomeController:Controller
    {
        private log4net.ILog logger
        {
            get
            {
                log4net.ILog log =
                    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                return log;
            }
        }

        public ActionResult Index()
        {
            logger.Info("index,");
            return Content("Index");
        }
    }
}