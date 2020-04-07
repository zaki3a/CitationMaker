using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
        private static Page page = null;

        public Journal()
        {
            InitializeComponent();
            RB_Jpn.IsChecked = true;    /*日本語(ラジオボタン)の選択*/
            ManthC.SelectedIndex = 0;   /*月(コンボボックス)の選択*/
            CitationT.IsReadOnly = true;
            tmp.Text = "著者名，“標題，”雑誌名，巻，号，pp.を付けて始め-終りのページ，月年．";
            tmpJpn.Text = "山上一郎，山下二郎，“パラメトリック増幅器，”信学論 (B), vol.J62-B, no.1, pp.20-27, Jan. 1979.";
            tmpEng.Text = "W. Rice, A.C. Wine, and B.D. Grain, “Diffusion of impurities during epitaxy,” Proc. IEEE, vol.52, no.3, pp.284-290, March 1964.";
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
            switch(Lang.Name)
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            page = new SelectPage();
            this.NavigationService.Navigate(page);
        }
    }
}
