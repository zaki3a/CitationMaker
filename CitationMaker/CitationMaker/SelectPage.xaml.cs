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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CitationMaker
{
    /// <summary>
    /// SelectPage.xaml の相互作用ロジック
    /// </summary>
    public partial class SelectPage : Page
    {
        private static Page page = null;
        RadioButton Ctype;

        public SelectPage()
        {
            InitializeComponent();
            RB_journal.IsChecked = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch(Ctype.Name)
            {
                case "RB_journal":
                    page = new Journal();
                    break;
            }
            this.NavigationService.Navigate(page);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Ctype = (RadioButton)sender;
        }
    }
}
