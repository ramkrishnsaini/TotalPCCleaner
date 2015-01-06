using MahApps.Metro.Controls;
using Microsoft.Win32;
using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PC_Cleaner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {


        DispatcherTimer dispatcherTimer;
        NotificationWindow objNotificationWindow;
        int cnt = 0;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            //this.Deactivated += MainWindow_Deactivated;
        }

        //void MainWindow_Deactivated(object sender, EventArgs e)
        //{
        //    Window window = (Window)sender;
        //    window.Topmost = true;
        //}

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (cnt == 0)
            {
                this.Topmost = true;
                layoutGrid.DataContext = new MainWindowVM();

            }
            cnt++;

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 30);
            dispatcherTimer.Start();
            //objNotificationWindow = new NotificationWindow();
            //NotificationWindow objNotificationWindow = new NotificationWindow();
            //objNotificationWindow.Show();
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            this.ShowCloseButton = true;
            this.Topmost = false;
            //this.Deactivated -= MainWindow_Deactivated;

            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "iexplore" || s == "iexplorer" || s == "chrome" || s == "firefox" || s == "torch")
                    {
                        process.Kill();

                    }
                }
            }
            if (objNotificationWindow == null)
            {
                objNotificationWindow = new NotificationWindow();
                objNotificationWindow.Show();
                objNotificationWindow.Topmost = true;
            }
            else
            {
                if (objNotificationWindow.WindowState == WindowState.Minimized)
                {
                    objNotificationWindow.WindowState = WindowState.Normal;
                    objNotificationWindow.Show();
                    objNotificationWindow.Topmost = true;
                }
            }
        }

        private void txtScanComputer_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Topmost = false;
            grdMain1.Visibility = Visibility.Collapsed;
            grdMain2.Visibility = Visibility.Collapsed;
            cntrlSettings.Visibility = Visibility.Collapsed;
            cntrlScanerror.Visibility = Visibility.Visible;
        }

        private void txtHome_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Topmost = false;
            cntrlScanerror.Visibility = Visibility.Collapsed;
            cntrlScanerror.ResetAll();
            cntrlSettings.Visibility = Visibility.Collapsed;

            grdMain1.Visibility = Visibility.Visible;
            grdMain2.Visibility = Visibility.Visible;
        }

        private void TextBlock_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Topmost = false;

            StaticsVW objStaticsVW = new StaticsVW();
            objStaticsVW.ShowDialog();
        }

        private void txtSettings_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Topmost = false;
            grdMain1.Visibility = Visibility.Collapsed;
            grdMain2.Visibility = Visibility.Collapsed;
            cntrlScanerror.Visibility = Visibility.Collapsed;
            cntrlSettings.Visibility = Visibility;
            if (GlobalClass.shrdSettingsVM != null)
            {
                GlobalClass.shrdSettingsVM.fillLogData();
            }
        }

        private void btnRegisterNow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Topmost = false;
            wndRegisterNow objRegisterNow = new wndRegisterNow();
            objRegisterNow.ShowDialog();
        }

        private void btnUndoRepair_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Topmost = false;
            wndUndoRepair objUndoRepair = new wndUndoRepair();
            objUndoRepair.ShowDialog();
        }



        private void txtStartupManager_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Topmost = false;
            wndStartupManager objStartupManager = new wndStartupManager();
            objStartupManager.ShowDialog();
        }

    }
}
