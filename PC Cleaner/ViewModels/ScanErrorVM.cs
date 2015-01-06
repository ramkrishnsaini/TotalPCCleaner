using PC_Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace PC_Cleaner.ViewModels
{
    public class ScanErrorVM : ViewModelBase
    {

        private ScanErrorVW objScanErrorVW;

        private ObservableCollection<ErrorType> _lstErrorTypes;
        public ObservableCollection<ErrorType> lstErrorTypes
        {
            get { return _lstErrorTypes; }
            set { _lstErrorTypes = value; RaisePropertyChanged("lstErrorTypes"); }
        }

        private Visibility _visibilityDuringScan;
        public Visibility visibilityDuringScan
        {
            get { return _visibilityDuringScan; }
            set { _visibilityDuringScan = value; RaisePropertyChanged("visibilityDuringScan"); }
        }


        public ScanErrorVM(ScanErrorVW obj)
        {
            objScanErrorVW = obj;
            BindCommands();
            LoadErrorTypeList();

            var str = Path.GetRandomFileName();

            setDefault();

        }

        private void setDefault()
        {
            foreach (var item in lstErrorTypes)
            {
                item.erroIconVisiblity = Visibility.Collapsed;
                item.okIconVisiblity = Visibility.Collapsed;
            }
        }

        private void BindCommands()
        {
            objScanErrorVW.chkbxSelectAll.Click += chkbxSelectAll_Click;
        }

        void chkbxSelectAll_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (objScanErrorVW.chkbxSelectAll.IsChecked.Value)
            {
                foreach (var item in lstErrorTypes)
                {
                    item.ErrorChecked = true;
                }
            }
            else
            {
                foreach (var item in lstErrorTypes)
                {
                    item.ErrorChecked = false;
                }
            }
        }



        private void LoadErrorTypeList()
        {
            lstErrorTypes = new ObservableCollection<ErrorType>();
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/ComActiveX.png", ErrorTypeName = "Com/ActiveX Entries", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/uninstall.png", ErrorTypeName = "Uninstall Entries", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/fonts.jpg", ErrorTypeName = "Font Entries", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/dllIcon.png", ErrorTypeName = "Shared DLLS", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/app path.png", ErrorTypeName = "Application Paths", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/help.jpg", ErrorTypeName = "Help File Information", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/play.png", ErrorTypeName = "Windows Startup Items", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/shortcut.png", ErrorTypeName = "Program Shortcuts", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/empty-box-xxl.png", ErrorTypeName = "Emplty Registry Keys", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/file.png", ErrorTypeName = "File Associations", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/shared folder.png", ErrorTypeName = "Shared Folders", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/invalid key.png", ErrorTypeName = "Invalid Class Keys", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/sound.png", ErrorTypeName = "Sound & App Events", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });
            lstErrorTypes.Add(new ErrorType { icon = "Assets/Img/clsid.png", ErrorTypeName = "CLSID/TypeLib/Interface Entries", ErrorChecked = true, ErrorCount = 0, FontColor = "Black" });

        }
    }
}
