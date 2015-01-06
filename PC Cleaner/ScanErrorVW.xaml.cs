using PC_Cleaner.Model;
using PC_Cleaner.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml;
using System.Xml.Linq;

namespace PC_Cleaner
{
    /// <summary>
    /// Interaction logic for ScanErrorVW.xaml
    /// </summary>
    public partial class ScanErrorVW : UserControl
    {
        int cnt = 0;
        bool isBreakdown = false;
        string lastScanStatus = "";
        int errorCountTotal = 0;

        public ScanErrorVW()
        {
            InitializeComponent();
            Loaded += ScanErrorVW_Loaded;

        }

        void ScanErrorVW_Loaded(object sender, RoutedEventArgs e)
        {
            if (cnt == 0)
            {
                layourRootScanError.DataContext = new ScanErrorVM(this);
                ReadDefaultData();
            }
            cnt++;
        }

        private void ReadDefaultData()
        {
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("CommonData.xml");
            //var xmlData = XElement.Parse(((System.Xml.XmlNode)(xmlDoc)).OuterXml);
            //txtLasScan.Text = xmlData.Element("lastScan").Value;
            //txtLasScanStatus.Text = xmlData.Element("lastScanStatus").Value;
            //txtErrorFixed.Text = xmlData.Element("ErrorFixed").Value + " Errors Fixed";
            //txtErrorFound.Text = xmlData.Element("ErrorFound").Value + " Errors Found";


            txtLasScan.Text = GlobalClass.lastScan;
            txtLasScanStatus.Text = GlobalClass.lastScanStatus;
            txtErrorFixed.Text = Convert.ToString(GlobalClass.errorFixed);
            txtErrorFound.Text = Convert.ToString(GlobalClass.errorFound);

            if (txtLasScanStatus.Text == "Completed")
                txtLasScanStatus.Foreground = new SolidColorBrush(Colors.Green);
            else
                txtLasScanStatus.Foreground = new SolidColorBrush(Colors.Red);

        }

        private delegate void UpdateProgressBarDelegate(System.Windows.DependencyProperty dp, Object value);
        private void Process(ErrorType objErrTp, int errorCount)
        {
            //Configure the ProgressBar
            ProgressBar1.Minimum = 0;
            ProgressBar1.Maximum = (short.MaxValue / 3);
            ProgressBar1.Value = 0;

            //Stores the value of the ProgressBar
            double value = 0;

            //Create a new instance of our ProgressBar Delegate that points
            //  to the ProgressBar's SetValue method.
            UpdateProgressBarDelegate updatePbDelegate = new UpdateProgressBarDelegate(ProgressBar1.SetValue);

            //Tight Loop:  Loop until the ProgressBar.Value reaches the max
            do
            {
                if (isBreakdown)
                    break;
                value += 1;

                /*Update the Value of the ProgressBar:
                  1)  Pass the "updatePbDelegate" delegate that points to the ProgressBar1.SetValue method
                  2)  Set the DispatcherPriority to "Background"
                  3)  Pass an Object() Array containing the property to update (ProgressBar.ValueProperty) and the new value */
                Dispatcher.Invoke(updatePbDelegate,
            System.Windows.Threading.DispatcherPriority.Background,
            new object[] { ProgressBar.ValueProperty, value });

                if ((value % errorCount) == 0)
                {
                    objErrTp.ErrorCount += 1;
                    errorCountTotal += 1;
                    txtErrorFound.Text = errorCountTotal.ToString() + " Errors Found";


                    if (GlobalClass.sharedMainWindowVM != null)
                        GlobalClass.sharedMainWindowVM.mainErrorFound = errorCountTotal.ToString();

                }

                if ((value % 1000) == 0)
                {
                    //Show scan entries
                    var path1 = System.IO.Path.GetRandomFileName();
                    path1 = path1.Replace(".", ""); // Remove period.

                    var path2 = System.IO.Path.GetRandomFileName();
                    path2 = path2.Replace(".", ""); // Remove period.

                    var path3 = System.IO.Path.GetRandomFileName();
                    path3 = path3.Replace(".", ""); // Remove period.

                    var path4 = System.IO.Path.GetRandomFileName();
                    path4 = path4.Replace(".", ""); // Remove period.

                    var path5 = System.IO.Path.GetRandomFileName();
                    path5 = path5.Replace(".", ""); // Remove period.

                    var randomgPath = "" + path1 + "-" + path2 + "-" + path3 + "-" + path4 + "-" + path5 + "";
                    randomgPath = randomgPath.ToUpper();
                    txtErrorsScanProgress.Text = "Registry: {" + randomgPath + "}";
                }
            }
            while (ProgressBar1.Value != ProgressBar1.Maximum);

        }

        private void btnFindError_Click(object sender, RoutedEventArgs e)
        {
            var objScanErrorVM = layourRootScanError.DataContext as ScanErrorVM;
            txtErrorFound.Text = "";
            errorCountTotal = 0;
            txtLasScanStatus.Text = "";
            txtLasScan.Text = "";
            lastScanStatus = "Completed";

            if (btnFindError.Content.ToString() == "Cancel Scan")
            {
                isBreakdown = true;
                btnFindError.Content = "Find Error";
                btnFindError.IsEnabled = false;
                //objScanErrorVM.visibilityDuringScan = Visibility.Visible;
                txtErrorsScanProgress.Text = "";
                lastScanStatus = "Canceled by user";
            }
            else
            {
                isBreakdown = false;
                btnFindError.Content = "Cancel Scan";
                objScanErrorVM.visibilityDuringScan = Visibility.Collapsed;
            }

            foreach (var item in objScanErrorVM.lstErrorTypes.Where(l => l.ErrorChecked))
            {
                if (isBreakdown)
                    break;
                int cntForDivision = 0; // Set count to get error. Total value will be devided by this value
                switch (item.ErrorTypeName)
                {
                    case "Com/ActiveX Entries":
                        cntForDivision = 550;
                        break;
                    case "Uninstall Entries":
                        cntForDivision = 20000;
                        break;
                    case "Font Entries":
                        cntForDivision = 20000;
                        break;
                    case "Shared DLLS":
                        cntForDivision = 430;
                        break;
                    case "Application Paths":
                        cntForDivision = 650;
                        break;
                    case "Help File Information":
                        cntForDivision = 20000;
                        break;
                    case "Windows Startup Items":
                        cntForDivision = 5000;
                        break;
                    case "Program Shortcuts":
                        cntForDivision = 700;
                        break;
                    case "Emplty Registry Keys":
                        cntForDivision = 200;
                        break;
                    case "File Associations":
                        cntForDivision = 300;
                        break;
                    case "Shared Folders":
                        cntForDivision = 20000;
                        break;
                    case "Invalid Class Keys":
                        cntForDivision = 150;
                        break;
                    case "Sound & App Events":
                        cntForDivision = 20000;
                        break;
                    case "CLSID/TypeLib/Interface Entries":
                        cntForDivision = 1100;
                        break;
                }

                Process(item, cntForDivision);

                if (item.ErrorCount == 0)
                {
                    item.erroIconVisiblity = Visibility.Collapsed;
                    item.okIconVisiblity = Visibility.Visible;
                    item.FontColor = "Green";
                }
                else
                {
                    item.okIconVisiblity = Visibility.Collapsed;
                    item.erroIconVisiblity = Visibility.Visible;
                    item.FontColor = "Red";
                }
            }


            txtErrorFound.Text = objScanErrorVM.lstErrorTypes.Sum(s => s.ErrorCount).ToString() + " Errors Found";
            btnFindError.IsEnabled = true;
            btnFindError.Visibility = Visibility.Collapsed;
            btnRepaierNow.Visibility = Visibility.Visible;
            btnReset.Visibility = Visibility.Visible;

            saveXmlData(DateTime.Now.ToString(), lastScanStatus, objScanErrorVM.lstErrorTypes.Sum(s => s.ErrorCount).ToString(), "");
            ReadDefaultData();

            GlobalClass.lstErrorTypes = objScanErrorVM.lstErrorTypes;
        }

        private void btnRepaierNow_Click(object sender, RoutedEventArgs e)
        {

            RepairNowVW objRepairNowVW = new RepairNowVW();
            objRepairNowVW.ShowDialog();
        }

        void saveXmlData(string lastScan, string lastScanStatus, string errorFound, string errorFixed)
        {
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("CommonData.xml");
            //var xmlData = XElement.Parse(((System.Xml.XmlNode)(xmlDoc)).OuterXml);
            //xmlData.Element("lastScan").Value = lastScan;
            //xmlData.Element("lastScanStatus").Value = lastScanStatus;
            //xmlData.Element("ErrorFixed").Value = errorFixed == "" ? xmlData.Element("ErrorFixed").Value : errorFixed;
            //xmlData.Element("ErrorFound").Value = errorFound;
            //xmlData.Save("CommonData.xml");

            string strScanLogPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TotalPCCleaner\\ScanLog";
            string strBackupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TotalPCCleaner\\Backup";


            #region Write Log File

            if (!Directory.Exists(strScanLogPath))
            {
                Directory.CreateDirectory(strScanLogPath);
            }

            string strLogFileName = "LOGS_" + DateTime.Now.ToShortDateString().Replace('/', '_') + DateTime.Now.ToShortTimeString().Replace(':', '_');

            // Create a stringbuilder and write the new user input to it.
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Total PC Cleaner Log");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine("= = = = = =");
            sb.AppendLine("Scan Status:   " + lastScanStatus);
            sb.AppendLine("Scan Found:   " + errorFound);
            sb.AppendLine("Scan Fixed:   " + (errorFixed == "" ? Convert.ToString(GlobalClass.errorFixed) : errorFixed));
            sb.AppendLine();
            sb.AppendLine();

            // Open a streamwriter to a new text file named "UserInputFile.txt"and write the contents of 
            // the stringbuilder to it. 
            using (StreamWriter outfile = new StreamWriter(strScanLogPath + @"\" + strLogFileName, true))
            {
                outfile.Write(sb.ToString());
            }

            #endregion

            #region Registry Bakup

            if (!Directory.Exists(strBackupPath))
            {
                Directory.CreateDirectory(strBackupPath);
            }

            string strBackupFileName = "Backup_" + DateTime.Now.ToShortDateString().Replace('/', '_') + DateTime.Now.ToShortTimeString().Replace(':', '_') + ".reg";

            // Create a stringbuilder and write the new user input to it.
            StringBuilder sbBak = new StringBuilder();

            sbBak.AppendLine();

            // Open a streamwriter to a new text file named "UserInputFile.txt"and write the contents of 
            // the stringbuilder to it. 
            using (StreamWriter outfile = new StreamWriter(strBackupPath + @"\" + strBackupFileName, true))
            {
                outfile.Write(sbBak.ToString());
            }

            #endregion

            GlobalClass.lastScan = lastScan;
            GlobalClass.lastScanStatus = lastScanStatus;
            GlobalClass.errorFixed = errorFixed == "" ? GlobalClass.errorFixed : Convert.ToInt32(errorFixed);
            GlobalClass.errorFound = Convert.ToInt32(errorFound);

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();

        }

        public void ResetAll()
        {
            btnFindError.Visibility = Visibility.Visible;
            btnRepaierNow.Visibility = Visibility.Collapsed;
            btnReset.Visibility = Visibility.Collapsed;

            btnFindError.Content = "Find Error";
            layourRootScanError.DataContext = null;
            layourRootScanError.DataContext = new ScanErrorVM(this);
            ReadDefaultData();
        }
    }
}
