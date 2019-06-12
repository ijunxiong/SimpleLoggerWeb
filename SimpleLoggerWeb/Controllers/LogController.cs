using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleLoggerWeb.Controllers
{
    public class LogController : Controller
    {
        private ActionResult getMessage(string message)
        {
            //return Json(new { message = message });
            return Content(message);
        }

        public ActionResult GetLogger(string date = "")
        {
            if (string.IsNullOrEmpty(date)) date = DateTime.Now.ToString("yyyy-MM-dd");
            //var logfile = HttpContext.Current.Server.MapPath("/App_Data/Logs/") + date + ".LOG";
            var logfile = Server.MapPath("/App_Data/Logs/") + date + ".LOG";
            //HttpContextBase
            //httpContextBase.ApplicationInstance.Context;
            var content = "";
            if (!System.IO.File.Exists(logfile)) getMessage("不存在");
            try
            {
                var fs = new System.IO.FileStream(logfile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);

                var sr = new System.IO.StreamReader(fs, System.Text.Encoding.Default);

                //StringBuilder sb = new StringBuilder();
                var lines = new List<string>();
                while (!sr.EndOfStream)
                {
                    lines.Insert(0, sr.ReadLine() + "\r\n");
                    if (lines.Count > 100) lines.RemoveAt(lines.Count - 1);
                }

                return getMessage(string.Concat(lines));
            }
            catch (Exception ex)
            {
                return getMessage(ex.Message);
            }
        }
        

    }
}