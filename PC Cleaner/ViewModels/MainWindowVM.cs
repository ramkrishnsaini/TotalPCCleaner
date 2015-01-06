using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Cleaner.ViewModels
{
    public class MainWindowVM : ViewModelBase
    {

        private string _mainErrorFound;
        public string mainErrorFound
        {
            get { return _mainErrorFound; }
            set { _mainErrorFound = value; RaisePropertyChanged("mainErrorFound"); }
        }

        private string _mainErrorFixed;
        public string mainErrorFixed
        {
            get { return _mainErrorFixed; }
            set { _mainErrorFixed = value; RaisePropertyChanged("mainErrorFixed"); }
        }

        public MainWindowVM()
        {
            GlobalClass.sharedMainWindowVM = this;

            mainErrorFound = Convert.ToString(GlobalClass.errorFound);
            mainErrorFixed = Convert.ToString(GlobalClass.errorFixed);
        }
    }
}
