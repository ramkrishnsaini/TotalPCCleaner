using MahApps.Metro.Controls;
using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PC_Cleaner
{
    /// <summary>
    /// Interaction logic for wndUndoRepair.xaml
    /// </summary>
    public partial class wndUndoRepair : MetroWindow
    {
        int cnt = 0;
        public wndUndoRepair()
        {
            InitializeComponent();
            Loaded += wndUndoRepair_Loaded;
        }

        void wndUndoRepair_Loaded(object sender, RoutedEventArgs e)
        {
            if (cnt == 0)
            {
                layoutRootUndorRepair.DataContext = new UndoRepairVM();
            }
            cnt++;
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            var dc = layoutRootUndorRepair.DataContext as UndoRepairVM;
            var item = dc.lstBackupFile.Where(f => f.fileChecked).FirstOrDefault();
            if (item == null)
            {
                MessageBox.Show("Please select at least one item to restore.");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Do you really want to restore registry?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Thread.Sleep(5000);
                    MessageBox.Show("Successfully restored. Please restart the computer.");
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var dc = layoutRootUndorRepair.DataContext as UndoRepairVM;
            foreach (var item in dc.lstBackupFile.Where(f => f.fileChecked))
            {
                if (File.Exists(item.filePath))
                {
                    MessageBoxResult result = MessageBox.Show("Do you really want to delete?", "Confirmation", MessageBoxButton.YesNo);
                    File.Delete(item.filePath);
                }
            }

            GlobalClass.shrdUndoRepairVM.FillBackupData();
        }
    }
}
