using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PC_Cleaner
{
    /// <summary>
    /// Interaction logic for usrcntrlSettings.xaml
    /// </summary>
    public partial class usrcntrlSettings : UserControl
    {

        int cnt = 0;
        public usrcntrlSettings()
        {
            InitializeComponent();
            Loaded += usrcntrlSettings_Loaded;
        }

        void usrcntrlSettings_Loaded(object sender, RoutedEventArgs e)
        {
            if (cnt == 0)
            {
                layoutrootSetting.DataContext = new usrcntrlSettingsVM();
                cnt++;
            }
        }

        private void btnDefault_Click(object sender, RoutedEventArgs e)
        {
            var objVM = layoutrootSetting.DataContext as usrcntrlSettingsVM;
            if (objVM.lstsettingsTypes != null)
            {
                foreach (var item in objVM.lstsettingsTypes)
                {
                    item.settingChecked = false;
                    if (item.settingName == "Run at system startup" || item.settingName == "Show startup screen while launching" || item.settingName == "Create backup before repairing errors" || item.settingName == "Check for updates automatically" || item.settingName == "Ask me before downloading updates")
                        item.settingChecked = true;
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGotoFolder_Click(object sender, RoutedEventArgs e)
        {
            var dc = layoutrootSetting.DataContext as usrcntrlSettingsVM;
            var item = dc.lstLogFile.FirstOrDefault();
            if (item != null)
            {
                if (File.Exists(item.filePath))
                {
                    Process.Start(System.IO.Path.GetDirectoryName(item.filePath));
                }
            }

        }

        private void btnDeleteLogFile_Click(object sender, RoutedEventArgs e)
        {
            var dc = layoutrootSetting.DataContext as usrcntrlSettingsVM;
            foreach (var item in dc.lstLogFile.Where(f => f.fileChecked))
            {
                if (File.Exists(item.filePath))
                {
                    File.Delete(item.filePath);
                }
            }

            GlobalClass.shrdSettingsVM.fillLogData();
        }



    }
}
