using PC_Cleaner.Model;
using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Cleaner
{
    public static class GlobalClass
    {
        public static ObservableCollection<ErrorType> lstErrorTypes { get; set; }

        public static MainWindowVM sharedMainWindowVM { get; set; }

        public static int currentErrorFixed { get; set; }
        public static string lastScan { get; set; }
        public static string lastScanStatus { get; set; }
        public static int errorFixed { get; set; }
        public static int errorFound { get; set; }

        public static usrcntrlSettingsVM shrdSettingsVM { get; set; }

        public static UndoRepairVM shrdUndoRepairVM { get; set; }
    }
}
