using System.Windows.Controls;
using System.Windows.Media;

namespace CitationMaker
{
    /// <summary>
    /// Book.xaml の相互作用ロジック
    /// </summary>
    public partial class Book : Page
    {

        string citation;
        RadioButton Lang;
        private static Page page = null;

        public Book()
        {
            InitializeComponent();
            RB_Jpn.IsChecked = true;    /*日本語(ラジオボタン)の選択*/
            CitationT.IsReadOnly = true;
            tmp.Text = "著者名，書名，編者名，発行所，発行都市名，発行年";
            tmpJpn.Text = "山田太郎，移動通信，木村次郎（編），（社）電子情報通信学会，東京，1989.";
            tmpEng.Text = "H. Tong, Nonlinear Time Series: A Dynamical System Approach, J.B. Elsner, ed., Oxford University Press, Oxford, 1990.";
        }

        private void Button_Click_Make(object sender, System.Windows.RoutedEventArgs e)
        {
            switch (Lang.Name)
            {
                case "RB_Jpn":
                    citation = AutherT.Text + "，" + TitleT.Text + "，" + EditorT.Text + "（編），（社）" 
                        + PublishT.Text + "，" + CityT.Text + "，" + YearT.Text + ".";
                    break;
                case "RB_Eng":
                    citation = AutherT.Text + ", " + TitleT.Text + ", " + EditorT.Text + ", ed., " + PublishT.Text 
                        + " Press, " + CityT.Text + ", " + YearT.Text + ".";
                    break;
            }
            CitationT.Text = citation;
        }

        private void RadioButton_Checked_2(object sender, System.Windows.RoutedEventArgs e)
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

        private void Button_Click_Back(object sender, System.Windows.RoutedEventArgs e)
        {
            page = new SelectPage();
            this.NavigationService.Navigate(page);
        }
    }
}
