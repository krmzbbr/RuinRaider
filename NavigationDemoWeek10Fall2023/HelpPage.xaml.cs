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

namespace NavigationDemoWeek10Fall2023
{
    /// <summary>
    /// Interaction logic for HelpPage.xaml
    /// </summary>
    public partial class HelpPage : Page
    {
        public HelpPage()
        {
            InitializeComponent();
        }

        private void LoginPageButton_Click(object sender, RoutedEventArgs e)
        {
            Uri loginPage = new Uri("LoginPage.xaml", UriKind.Relative);
            NavigationService.Navigate(loginPage);
        }

        private void MicrosoftButton_Click(object sender, RoutedEventArgs e)
        {
            Uri imageUri = new Uri("assets/Microsoft.png", UriKind.Relative);
            LogoImage.Source = new BitmapImage(imageUri);

        }

        private void GoogleButton_Click(object sender, RoutedEventArgs e)
        {
            Uri imageUri = new Uri("assets/google.png", UriKind.Relative);
            LogoImage.Source = new BitmapImage(imageUri);
        }
    }
}
