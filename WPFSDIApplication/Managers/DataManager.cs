using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities = WPFSDIApplication.Entities;
using Models = WPFSDIApplication.Models;

namespace WPFSDIApplication.Managers
{
    public static class DataManager
    {
        public static List<Models.Person> GetPersonsFromXML(string filePath)
        {
            List<Models.Person> Persons = new List<Models.Person>();

            var tableData = XMLManager.GetXMLFromAssemblyResource<Entities.TableData>(filePath);
            foreach (var person in tableData.Persons)
                Persons.Add(new Models.Person(person));

            return Persons;
        }
    }
}
