using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFSDIApplication.Managers;
using WPFSDIApplication.Models;
using WPFSDIApplication.MVVMEngine;
using Entities = WPFSDIApplication.Entities;
using Models = WPFSDIApplication.Models;

namespace WPFSDIApplication.Controls.Table
{
    public class TableViewModel : BaseViewModel
    {
        private static TableViewModel _Current;
        public static TableViewModel Current
        {
            get
            {
                if (_Current == null)
                    _Current = new TableViewModel();
                return _Current;
            }
        }

        public ObservableCollection<Models.Person> Persons { get; set; }

        public int PersonsCount
        {
            get { return Persons.Count; }
        }

        private ICommand _SelectPersonCommand;
        public ICommand SelectPersonCommand
        {
            get
            {
                if (_SelectPersonCommand == null)
                    _SelectPersonCommand = new RelayCommand(person =>
                    {
                        SelectPerson(person);
                    });
                return _SelectPersonCommand;
            }
        }

        private void SelectPerson(object param)
        {
            var person = param as Person;
            if (person != null)
                SelectPerson(person);
        }

        private void SelectPerson(Person person)
        {
            var selectedPerson = Persons.FirstOrDefault(p => p.IsSelected);
            if (selectedPerson != null)
                selectedPerson.IsSelected = false;

            person.IsSelected = !person.IsSelected;
        }

        private TableViewModel()
        {
            Persons = new ObservableCollection<Models.Person>(DataManager.GetPersonsFromXML(@"TableData.xml"));
        }
    }
}
