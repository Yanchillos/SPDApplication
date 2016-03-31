using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPFSDIApplication.Managers
{
    public static class XMLManager
    {
        public static T GetXMLFromAssemblyResource<T>(string filePath)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = string.Format("{0}.{1}", ApplicationManager.AssamblyName, ApplicationManager.XMLDataFilePath);

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    return XMLManager.ParseXML<T>(data);
                }
            }
        }

        private static T ParseXML<T>(string data)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(data))
            {
                var result = (T)serializer.Deserialize(reader);
                return result;
            }
        }
    }
}
