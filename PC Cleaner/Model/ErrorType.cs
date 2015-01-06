using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PC_Cleaner.Model
{
    public class ErrorType : ViewModelBase
    {
        private string _icon;
        public string icon
        {
            get { return _icon; }
            set { _icon = value; RaisePropertyChanged("icon"); }
        }

        private string _ErrorTypeName;
        public string ErrorTypeName
        {
            get { return _ErrorTypeName; }
            set { _ErrorTypeName = value; RaisePropertyChanged("ErrorTypeName"); }
        }

        private bool _ErrorChecked;
        public bool ErrorChecked
        {
            get { return _ErrorChecked; }
            set { _ErrorChecked = value; RaisePropertyChanged("ErrorChecked"); }
        }

        private Visibility _erroIconVisiblity;
        public Visibility erroIconVisiblity
        {
            get { return _erroIconVisiblity; }
            set { _erroIconVisiblity = value; RaisePropertyChanged("erroIconVisiblity"); }
        }

        private Visibility _okIconVisiblity;
        public Visibility okIconVisiblity
        {
            get { return _okIconVisiblity; }
            set { _okIconVisiblity = value; RaisePropertyChanged("okIconVisiblity"); }
        }

        private int _ErrorCount;
        public int ErrorCount
        {
            get { return _ErrorCount; }
            set { _ErrorCount = value; RaisePropertyChanged("ErrorCount"); }
        }

        private int _ErrorFixed;
        public int ErrorFixed
        {
            get { return _ErrorFixed; }
            set { _ErrorFixed = value; RaisePropertyChanged("ErrorFixed"); }
        }

        private string _FontColor;
        public string FontColor
        {
            get { return _FontColor; }
            set { _FontColor = value; RaisePropertyChanged("FontColor"); }
        }
    }
}
