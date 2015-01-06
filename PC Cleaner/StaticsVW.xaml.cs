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
    /// Interaction logic for StaticsVW.xaml
    /// </summary>
    public partial class StaticsVW : MetroWindow
    {
        public StaticsVW()
        {
            InitializeComponent();
            Loaded += StaticsVW_Loaded;
        }

        void StaticsVW_Loaded(object sender, RoutedEventArgs e)
        {
            var tempFixedCount = GlobalClass.currentErrorFixed;
            if (GlobalClass.lstErrorTypes != null)
            {
                foreach (var item in GlobalClass.lstErrorTypes)
                {
                    if (tempFixedCount > 0 && tempFixedCount >= item.ErrorCount)
                    {
                        item.ErrorFixed = item.ErrorCount;
                        tempFixedCount = tempFixedCount - item.ErrorCount;
                    }
                    else if (tempFixedCount > 0 && item.ErrorCount >= tempFixedCount)
                    {
                        item.ErrorFixed = tempFixedCount;
                        tempFixedCount = tempFixedCount - tempFixedCount;
                    }
                }

                dgStatics.ItemsSource = GlobalClass.lstErrorTypes;

                ReadDefaultData();
            }
        }


        private void ReadDefaultData()
        {
            txtErrorFixed.Text = GlobalClass.currentErrorFixed.ToString();
            txtErrorFound.Text = GlobalClass.lstErrorTypes.Sum(s => s.ErrorCount).ToString();


        }

    }
}
