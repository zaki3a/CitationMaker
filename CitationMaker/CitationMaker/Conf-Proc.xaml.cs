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
    /// Conf_Proc.xaml の相互作用ロジック
    /// </summary>
    public partial class Conf_Proc : Page
    {

        string citation;
        RadioButton Lang;
        private static Page page = null;

        public Conf_Proc()
        {
            InitializeComponent();
            RB_Jpn.IsChecked = true;    /*日本語(ラジオボタン)の選択*/
            CitationT.IsReadOnly = true;
            tmp.Text = "著者名，“標題，”会議名，no.を付けて論文番号，pp.を付けて始め-終りのページ，開催都市名，国名，月年．";
            tmpJpn.Text = "川上三郎，川口四郎，“紫外域半導体レーザ，”1995信学全大，分冊2, no.SB2-1, pp.20-21, Sept. 1995.";
            tmpEng.Text = "H.K. Hartline, A.B. Smith, and F. Ratlliff, “Inhibitory interaction in the retina,” " +
                "in Handbook of Sensory Physiology, ed. M.G.F. Fuortes, pp.381-390, Springer-Verlag, Berlin, 1972.";
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            page = new SelectPage();
            this.NavigationService.Navigate(page);
        }

        private void Button_Click_Make(object sender, RoutedEventArgs e)
        {
            switch (Lang.Name)
            {
                
            }
            CitationT.Text = citation;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Lang = (RadioButton)sender;
            switch (Lang.Name)
            {
                case "RB_Jpn":
                    tmpEng.Background = Brushes.White;
                    tmpJpn.Background = Brushes.Gold;
                    break;
                case "RB_Eng":
                    tmpJpn.Background = Brushes.White;
                    tmpEng.Background = Brushes.Gold;
                    break;
            }
        }
    }
}
