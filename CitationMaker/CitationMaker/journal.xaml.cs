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
    /// journal.xaml の相互作用ロジック
    /// </summary>
    public partial class Journal : Page
    {

        string citation;
        string Manth;
        RadioButton Lang;

        public Journal()
        {
            InitializeComponent();
            RB_Jpn.IsChecked = true;    /*日本語(ラジオボタン)の選択*/
            ManthC.SelectedIndex = 0;   /*月(コンボボックス)の選択*/

            AutherL.Content = "著者";
            AutherT.Text = "";
            TitleL.Content = "タイトル";
            TitleT.Text = "";
            BookL.Content = "掲載";
            BookT.Text = "";
            VolL.Content = "巻";
            VolT.Text = "";
            NoL.Content = "号";
            NoT.Text = "";
            PageSL.Content = "ページ";
            PageST.Text = "";
            PageET.Text = "";
            ManthL.Content = "月";
            YearL.Content = "年";
            YearT.Text = "";
            CitationT.Text = "";
            CitationT.IsReadOnly = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

            switch(Lang.Name)
            {
                case "RB_Jpn":
                    citation = AutherT.Text + "，“" + TitleT.Text + "，”" + BookT.Text + "，vol." + VolT.Text + "，no." + NoT.Text + "，pp." + PageST.Text + "-" + PageET.Text + "，" + Manth + ". " + YearT.Text + ".";
                    break;
                case "RB_Eng":
                    citation = AutherT.Text + ", \"" + TitleT.Text + ",\" " + BookT.Text + ", vol." + VolT.Text + ", no." + NoT.Text + ", pp." + PageST.Text + "-" + PageET.Text + ", " + Manth + ". " + YearT.Text + ".";
                    break;
            }
            CitationT.Text = citation;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Lang = (RadioButton)sender;
        }
    }
}
