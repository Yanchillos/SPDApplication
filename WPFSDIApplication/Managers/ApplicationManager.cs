using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSDIApplication.Properties;

namespace WPFSDIApplication.Managers
{
    public static class ApplicationManager
    {
        public static string AssamblyName
        {
            get
            {
                var assamblyName = Settings.Default.AssamblyName;
                return assamblyName;
            }
        }

        public static string XMLDataFilePath
        {
            get
            {
                var xmlDataFileName = Settings.Default.XMLDataFilePath;
                return xmlDataFileName;
            }
        }
    }
}
