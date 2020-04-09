using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CitationMaker
{
    /// <summary>
    /// Book2.xaml の相互作用ロジック
    /// </summary>
    public partial class Book2 : Page
    {

        string citation;
        RadioButton Lang;
        private static Page page = null;

        public Book2()
        {
            InitializeComponent();
            RB_Jpn.IsChecked = true;    /*日本語(ラジオボタン)の選択*/
            CitationT.IsReadOnly = true;
            tmp.Text = "著者名，“標題，”書名，編者名，章番号またはpp.を付けて始め-終りのページ，発行所，発行都市名，発行年．";
            tmpJpn.Text = "山田太郎，“周波数の有効利用，”移動通信，木村次郎（編），pp.21-41，（社）電子情報通信学会，東京，1989.";
            tmpEng.Text = "H.K. Hartline, A.B. Smith, and F. Ratlliff, “Inhibitory interaction in the retina,” in Handbook of Sensory Physiology, ed. M.G.F. Fuortes, pp.381-390, Springer-Verlag, Berlin, 1972.";
        }

        private void Button_Click_Make(object sender, RoutedEventArgs e)
        {
            switch (Lang.Name)
            {
                case "RB_Jpn":
                    citation = AutherT.Text + "，“" + SemiTitleT.Text + "，”" + TitleT.Text + "，" + EditorT.Text + "（編），pp." + PageST.Text + " - " + PageET.Text + "，（社）" + PublishT.Text + "，" + CityT.Text + "，" + YearT.Text + ".";
                    break;
                case "RB_Eng":
                    citation = AutherT.Text + ", “" + SemiTitleT.Text + ",” " + "in " + TitleT.Text + ", ed. " + EditorT.Text + ", pp." + PageST.Text + " - " + PageET.Text + ", " + PublishT.Text + ", " + CityT.Text + ", " + YearT.Text + ".";
                    break;
            }
            CitationT.Text = citation;
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            page = new SelectPage();
            this.NavigationService.Navigate(page);
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
