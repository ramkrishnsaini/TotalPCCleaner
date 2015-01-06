using MahApps.Metro.Controls;
using PC_Cleaner.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PC_Cleaner
{
    /// <summary>
    /// Interaction logic for wndStartupManager.xaml
    /// </summary>
    public partial class wndStartupManager : MetroWindow
    {
        public wndStartupManager()
        {
            InitializeComponent();
            Loaded += wndStartupManager_Loaded;
        }

        void wndStartupManager_Loaded(object sender, RoutedEventArgs e)
        {
            GetAllApps();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void GetAllApps()
        {
            List<csLogFiles> lstPrograms = new List<csLogFiles>();
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            //MessageBox.Show(key.ValueCount.ToString());
            foreach (string appName in key.GetValueNames())
            {
                try
                {
                    csLogFiles obj = new csLogFiles();
                    obj.fileChecked = true;
                    obj.fileName = appName;
                    obj.filePath = Convert.ToString(key.GetValue(appName));
                    lstPrograms.Add(obj);

                    // MessageBox.Show((string)key.GetValue(appName));
                    //ParsePath(appName, (string)key.GetValue(appName), ref data);
                    //db.Insert("startup", data);
                }
                catch (Exception ex)
                {

                }

            }
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", false);

            foreach (string appName in key.GetValueNames())
            {
                try
                {
                    //MessageBox.Show((string)key.GetValue(appName));
                    csLogFiles obj = new csLogFiles();
                    obj.fileChecked = true;
                    obj.fileName = appName;
                    obj.filePath = Convert.ToString(key.GetValue(appName));
                    lstPrograms.Add(obj);
                }
                catch (Exception ex)
                {

                }

            }
            //key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            //foreach (string appName in key.GetValueNames())
            //{
            //    try
            //    {
            //        MessageBox.Show((string)key.GetValue(appName));
            //    }
            //    catch (Exception ex)
            //    {

            //    }

            //}

            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
            FileInfo[] links = di.GetFiles("*.lnk");
            foreach (FileInfo fi in links)
            {
                //MessageBox.Show(fi.FullName);
                csLogFiles obj = new csLogFiles();
                obj.fileChecked=true;
                obj.fileName = fi.FullName;
                obj.filePath = fi.DirectoryName;
                lstPrograms.Add(obj);
            }
            key.Close();


            var binding = new Binding();
            binding.Source = lstPrograms;

            dgStartupManager.SetBinding(DataGrid.ItemsSourceProperty, binding);

        } 
    }
}
