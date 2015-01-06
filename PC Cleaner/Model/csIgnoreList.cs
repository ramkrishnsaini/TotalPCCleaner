using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Cleaner.Model
{
    public class csIgnoreList : ViewModelBase
    {
        private bool _ignoreChecked;
        public bool ignoreChecked
        {
            get { return _ignoreChecked; }
            set { _ignoreChecked = value; RaisePropertyChanged("ignoreChecked"); }
        }

        private string _fileType;
        public string fileType
        {
            get { return _fileType; }
            set { _fileType = value; RaisePropertyChanged("fileType"); }
        }

        private string _ignoreName;
        public string ignoreName
        {
            get { return _ignoreName; }
            set { _ignoreName = value; RaisePropertyChanged("ignoreName"); }
        }
    }
}
