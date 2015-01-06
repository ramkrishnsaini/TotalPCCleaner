using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Cleaner.Model
{
    public class csLogFiles : ViewModelBase
    {
        private bool _fileChecked;
        public bool fileChecked
        {
            get { return _fileChecked; }
            set { _fileChecked = value; RaisePropertyChanged("fileChecked"); }
        }

        private string _fileTime;
        public string fileTime
        {
            get { return _fileTime; }
            set { _fileTime = value; RaisePropertyChanged("fileTime"); }
        }

        private string _fileName;
        public string fileName
        {
            get { return _fileName; }
            set { _fileName = value; RaisePropertyChanged("fileName"); }
        }

        private string _filePath;
        public string filePath
        {
            get { return _filePath; }
            set { _filePath = value; RaisePropertyChanged("filePath"); }
        }
    }
}
