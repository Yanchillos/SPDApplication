using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPFSDIApplication.Entities
{
    [Serializable, XmlRoot(ElementName = "tableData")]
    public class TableData
    {
        [XmlArray("persons")]
        [XmlArrayItem("person")]
        public Person[] Persons { get; set; }
    }
}
