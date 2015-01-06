using PC_Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace PC_Cleaner.ViewModels
{
    public class usrcntrlSettingsVM : ViewModelBase
    {
        private ObservableCollection<settingsType> _lstsettingsTypes;
        public ObservableCollection<settingsType> lstsettingsTypes
        {
            get { return _lstsettingsTypes; }
            set { _lstsettingsTypes = value; RaisePropertyChanged("lstsettingsTypes"); }
        }

        private ObservableCollection<csLogFiles> _lstLogFile;
        public ObservableCollection<csLogFiles> lstLogFile
        {
            get { return _lstLogFile; }
            set { _lstLogFile = value; RaisePropertyChanged("lstLogFile"); }
        }

        private ObservableCollection<csIgnoreList> _lstignoreList;
        public ObservableCollection<csIgnoreList> lstignoreList
        {
            get { return _lstignoreList; }
            set { _lstignoreList = value; RaisePropertyChanged("lstignoreList"); }
        }

        public usrcntrlSettingsVM()
        {
            GlobalClass.shrdSettingsVM = this;
            fillData();
            fillLogData();
        }

        public void fillLogData()
        {
            string strScanLogPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TotalPCCleaner\\ScanLog";

            if (!Directory.Exists(strScanLogPath))
            {
                Directory.CreateDirectory(strScanLogPath);
            }

            string[] files = Directory.GetFiles(strScanLogPath);
            lstLogFile = new ObservableCollection<csLogFiles>();


            foreach (var fl in files)
            {
                var lgfl = new csLogFiles();
                lgfl.fileName = Path.GetFileName(fl);
                lgfl.fileTime = File.GetCreationTime(fl).ToString();
                
                lgfl.filePath = fl;
                lstLogFile.Add(lgfl);
            }

        }

        private void fillData()
        {

            //Fill setting Types
            lstsettingsTypes = new ObservableCollection<settingsType>();
            lstsettingsTypes.Add(new settingsType { settingName = "Run at system startup", settingChecked = true });
            lstsettingsTypes.Add(new settingsType { settingName = "Show startup screen while launching", settingChecked = true });
            lstsettingsTypes.Add(new settingsType { settingName = "Close Total PC Cleaner after repair" });
            lstsettingsTypes.Add(new settingsType { settingName = "Minimize Total PC Cleaner while scanning for errors" });
            lstsettingsTypes.Add(new settingsType { settingName = "Auto Repair Errors" });
            lstsettingsTypes.Add(new settingsType { settingName = "Create backup before repairing errors", settingChecked = true });
            lstsettingsTypes.Add(new settingsType { settingName = "Check for updates automatically", settingChecked = true });
            lstsettingsTypes.Add(new settingsType { settingName = "Ask me before downloading updates", settingChecked = true });
            lstsettingsTypes.Add(new settingsType { settingName = "Auto scan for errors when software is launched" });
            //----------------------

            lstignoreList = new ObservableCollection<csIgnoreList>();
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\mcdspwrp.comctelemetryapishm\curver\mcdspwrp.mcdspdatabasemgr.1" });
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\osf.remoteproxy\curve\|osf.remoteproxy.1" });
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\osf.osfaxcontrol\curver\|osf.osfaxcontrol.1" });
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\msopeopledatahandler.peopledataprovider\curver\|msopeopledatahandler.pikcerdataprovider.2" });
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\microsoft.ssis.graph\\|" });
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\mcoobesvc.mcsvcsubsystem.1\\|" });
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\mcoobesvc.mcsvcsubsystem\curver\|testsubsystem1.mcsvcsubsystem.1" });
            lstignoreList.Add(new csIgnoreList { fileType = "File Associations", ignoreName = @"hkey_local_machine\software\classes\mcdspwrp.comctelemetryapishm.1\\|" });
        }
    }
}
