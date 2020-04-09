using System.Windows;
using System.Windows.Controls;

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

        private void Button_Click_Make(object sender, RoutedEventArgs e)
        {
            switch(Ctype.Name)
            {
                case "RB_journal":
                    page = new Journal();
                    break;
                case "RB_book":
                    page = new Book();
                    break;
                case "RB_book2":
                    page = new Book2();
                    break;
                case "RB_conf_proc":
                    page = new Conf_Proc();
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
