using PC_Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace PC_Cleaner.ViewModels
{
    public class UndoRepairVM : ViewModelBase
    {
        private ObservableCollection<csLogFiles> _lstBackupFile;
        public ObservableCollection<csLogFiles> lstBackupFile
        {
            get { return _lstBackupFile; }
            set { _lstBackupFile = value; RaisePropertyChanged("lstBackupFile"); }
        }

        public UndoRepairVM()
        {
            GlobalClass.shrdUndoRepairVM = this;
            FillBackupData();
        }

        public void FillBackupData()
        {
            string strBackupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TotalPCCleaner\\Backup";

            if (!Directory.Exists(strBackupPath))
            {
                Directory.CreateDirectory(strBackupPath);
            }

            string[] files = Directory.GetFiles(strBackupPath);
            lstBackupFile = new ObservableCollection<csLogFiles>();

            foreach (var fl in files)
            {
                var lgfl = new csLogFiles();
                lgfl.fileName = Path.GetFileName(fl);
                lgfl.fileTime = File.GetCreationTime(fl).ToString();

                lgfl.filePath = fl;
                lstBackupFile.Add(lgfl);
            }
        }
    }
}
