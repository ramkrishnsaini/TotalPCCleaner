using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace PC_Cleaner
{
    /// <summary>
    /// Interaction logic for RepairNowVW.xaml
    /// </summary>
    public partial class RepairNowVW : MetroWindow
    {

        int errorFixedTotal = 0;
        string errorFoundTotal = "0";
        int cnt = 0;
        bool isClosed = false;

        public RepairNowVW()
        {
            InitializeComponent();
            Loaded += RepairNowVW_Loaded;
        }

        void RepairNowVW_Loaded(object sender, RoutedEventArgs e)
        {
            if (cnt == 0)
            {
                ReadDefaultData();
            }
            cnt++;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            isClosed = true;
            openStatics();
            this.Close();
        }

        private delegate void UpdateProgressBarDelegate(System.Windows.DependencyProperty dp, Object value);
        private void Process()
        {
            //Configure the ProgressBar
            ProgressBar1.Minimum = 0;
            ProgressBar1.Maximum = short.MaxValue;
            ProgressBar1.Value = 0;

            //Stores the value of the ProgressBar
            double value = 0;

            //Create a new instance of our ProgressBar Delegate that points
            //  to the ProgressBar's SetValue method.
            UpdateProgressBarDelegate updatePbDelegate = new UpdateProgressBarDelegate(ProgressBar1.SetValue);

            //Tight Loop:  Loop until the ProgressBar.Value reaches the max
            do
            {
                if (isClosed)
                    break;
                value += 1;

                if ((value % 1280) == 0 && GlobalClass.currentErrorFixed < Convert.ToInt32(errorFoundTotal))
                {
                    errorFixedTotal += 1;
                    GlobalClass.currentErrorFixed += 1;

                    if (errorFixedTotal == 25)
                    {
                        MessageBox.Show(@"Total Clean PC has found " + errorFoundTotal + @" ERRORS on your System.
Your 25 FREE repairs used, You will need to buy this version of TOTAL CLEAN PC to repair the rest of your errors.
To buy Call below toll free number
1-877-776-3645");

                        break;
                    }
                    txtErrorFixed.Text = GlobalClass.currentErrorFixed.ToString() + " Error Fixed";
                }

                /*Update the Value of the ProgressBar:
                  1)  Pass the "updatePbDelegate" delegate that points to the ProgressBar1.SetValue method
                  2)  Set the DispatcherPriority to "Background"
                  3)  Pass an Object() Array containing the property to update (ProgressBar.ValueProperty) and the new value */
                Dispatcher.Invoke(updatePbDelegate,
            System.Windows.Threading.DispatcherPriority.Background,
            new object[] { ProgressBar.ValueProperty, value });

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

                    var randomgPath = "" + path1 + "-" + path2 + "-" + path3 + ".....";
                    randomgPath = randomgPath.ToUpper();
                    txtErrorsScanProgress.Text = "Registry Cleaning: {" + randomgPath + "}";
                }
            }
            while (ProgressBar1.Value != ProgressBar1.Maximum);

        }

        private void btnRepair_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.currentErrorFixed = 0;

            if (errorFixedTotal == 25)
            {
                MessageBox.Show(@"Total Clean PC has found " + errorFoundTotal + @" ERRORS on your System.
Since you have alread used your 25 FREE repairs, You will need to buy this version of CLEANPC to repair the rest of your errors.
To buy Call below toll free number
1-877-776-3645");
            }
            else
            {
                grdInfo.Visibility = Visibility.Collapsed;
                spProgressRepair.Visibility = Visibility.Visible;
                Process();
                saveXmlData();
                openStatics();
                this.Close();
            }
        }

        private void openStatics()
        {
            StaticsVW objStaticsVW = new StaticsVW();
            objStaticsVW.Show();
        }

        private void ReadDefaultData()
        {
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("CommonData.xml");
            //var xmlData = XElement.Parse(((System.Xml.XmlNode)(xmlDoc)).OuterXml);
            //txtErrorfound.Text = xmlData.Element("ErrorFound").Value + " Errors Found";
            //txtErrorResult.Text = xmlData.Element("ErrorFound").Value + " Errors Found";
            //errorFoundTotal = xmlData.Element("ErrorFound").Value;
            //errorFixedTotal = Convert.ToInt32(xmlData.Element("ErrorFixed").Value);

            //if (errorFixedTotal >= 25)
            //{
            //    txtwithTheTrialPeriodResult.Text = "You have used your 25 Repairs, you need to buy the full version to reapair the rest.";
            //}
            //else
            //{
            //    txtwithTheTrialPeriodResult.Text = "25 Repairs allowed.";
            //}

            txtErrorfound.Text = Convert.ToString(GlobalClass.errorFound);
            txtErrorResult.Text = Convert.ToString(GlobalClass.errorFound);
            errorFoundTotal = Convert.ToString(GlobalClass.errorFound);
            errorFixedTotal = GlobalClass.errorFixed;

            txtwithTheTrialPeriodResult.Text = "25 Repairs allowed.";
        }

        void saveXmlData()
        {
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("CommonData.xml");
            //var xmlData = XElement.Parse(((System.Xml.XmlNode)(xmlDoc)).OuterXml);

            //xmlData.Element("ErrorFixed").Value = errorFixedTotal.ToString();

            //xmlData.Save("CommonData.xml");
            GlobalClass.errorFixed = errorFixedTotal;

            if (GlobalClass.sharedMainWindowVM != null)
                GlobalClass.sharedMainWindowVM.mainErrorFixed = Convert.ToString(GlobalClass.errorFixed);
        }

    }
}
