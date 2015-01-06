using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Cleaner.Model
{
    public class settingsType : ViewModelBase
    {
        private bool _settingChecked;
        public bool settingChecked
        {
            get { return _settingChecked; }
            set { _settingChecked = value; RaisePropertyChanged("settingChecked"); }
        }

        private string _settingName;
        public string settingName
        {
            get { return _settingName; }
            set { _settingName = value; RaisePropertyChanged("settingName"); }
        }

    }
}
