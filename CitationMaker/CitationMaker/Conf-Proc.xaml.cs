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
        string Manth;
        RadioButton Lang;
        private static Page page = null;

        public Conf_Proc()
        {
            InitializeComponent();
            RB_Jpn.IsChecked = true;    /*日本語(ラジオボタン)の選択*/
            CitationT.IsReadOnly = true;
            tmp.Text = "著者名，“標題，”会議名，no.を付けて論文番号，pp.を付けて始め-終りのページ，開催都市名，国名，月年．";
            tmpJpn.Text = "川上三郎，川口四郎，“紫外域半導体レーザ，”1995信学全大，分冊2, no.SB2-1, pp.20-21, Sept. 1995.";
            tmpEng.Text = "具体例なし";
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            page = new SelectPage();
            this.NavigationService.Navigate(page);
        }

        private void Button_Click_Make(object sender, RoutedEventArgs e)
        {
            //月変換
            switch (ManthC.SelectionBoxItem)
            {
                case "1":
                    Manth = "Jan";
                    break;
                case "2":
                    Manth = "Feb";
                    break;
                case "3":
                    Manth = "Mar";
                    break;
                case "4":
                    Manth = "Apr";
                    break;
                case "5":
                    Manth = "May";
                    break;
                case "6":
                    Manth = "June";
                    break;
                case "7":
                    Manth = "July";
                    break;
                case "8":
                    Manth = "Aug";
                    break;
                case "9":
                    Manth = "Sept";
                    break;
                case "10":
                    Manth = "Oct";
                    break;
                case "11":
                    Manth = "Nov";
                    break;
                case "12":
                    Manth = "Dec";
                    break;
            }

            switch (Lang.Name)
            {
                case "RB_Jpn":
                    citation = AutherT.Text + "，“" + TitleT.Text + "，”" + ConfT.Text + "，no." + NoT.Text + "，pp." + PageST.Text + "-" + PageST.Text + "，" + Manth + ". " + YearT.Text + "．";
                    break;
                case "RB_Eng":
                    citation = AutherT.Text + ", \"" + TitleT.Text + ",\" " + ConfT.Text + ", no." + NoT.Text + ", pp." + PageST.Text + "-" + PageST.Text + ", " + Manth + ". " + YearT.Text + ".";
                    break;
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
