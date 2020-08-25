using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace ITMS.Infrastructure
{
    public class LogHelper
    {//(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
  
        static readonly log4net.ILog logError = log4net.LogManager.GetLogger("ErrorLogger");
        
        public static void Error(string message)
        {
            Task.Run(() => logError.Error(message));
        }
      
    }
}
