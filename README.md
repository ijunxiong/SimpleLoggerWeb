# SimpleLoggerWeb
use log4net define a simple logger for web work



测试：



访问：  http://localhost:5845/

看到 Index



再访问： http://localhost:5845/log/getlogger

看到日志变化：

2019-06-12 11:44:05,034 [12] INFO SimpleLoggerWeb.Controllers.HomeController [Index] - Line 23:index,



说明，日志为当天，最新100条