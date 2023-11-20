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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static Game game = new Game();


        public MainWindow()
        {
            InitializeComponent();

            //Displays content on the main frame
            MainContentFrame.Navigate(new LoginPage());

        }

        private void LoginPageButon_Click(object sender, RoutedEventArgs e)
        {
            //Displays content on the main frame
            MainContentFrame.Navigate(new LoginPage());
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            //Displays content on the main frame
            MainContentFrame.Navigate(new HelpPage());
        }


        public void UpdatePlayerDetails()
        {
            PlayerNameLabel.Content = game.PlayerName;
            Uri avatarUri = new Uri(game.PlayerAvatarPath, UriKind.Relative);
            PlayerAvatarImage.Source = new BitmapImage(avatarUri);
        }
    }
}
