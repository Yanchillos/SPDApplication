using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSDIApplication.Models;
using WPFSDIApplication.MVVMEngine;

namespace WPFSDIApplication.Controls.SelectedPerson
{
    public class SelectedPersonViewModel : BaseViewModel
    {
        private static SelectedPersonViewModel _Current;
        public static SelectedPersonViewModel Current
        {
            get
            {
                if (_Current == null)
                    _Current = new SelectedPersonViewModel();
                return _Current;
            }
        }

        private Person _SelectedPerson;
        public Person SelectedPerson
        {
            get { return _SelectedPerson; }
            set 
            {
                if (_SelectedPerson != value)
                {
                    _SelectedPerson = value;
                    RaisePropertyChanged("SelectedPerson");
                }
            }
        }
        

        public SelectedPersonViewModel()
        {

        }
    }
}
