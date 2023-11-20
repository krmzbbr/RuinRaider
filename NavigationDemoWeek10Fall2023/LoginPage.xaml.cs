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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.game.PlayerName = UserNameTextBox.Text;

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.UpdatePlayerDetails();


            Uri locationsPage = new Uri("LocationsPage.xaml", UriKind.Relative);
            NavigationService.Navigate(locationsPage);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Will reset all the rectangles to have a white background
            indianajonesRectangle.Fill = new SolidColorBrush(Colors.White);
            lauracraftRectangle.Fill = new SolidColorBrush(Colors.White);
            cavemanRectangle.Fill = new SolidColorBrush(Colors.White);

            //Get a reference to the image that was clicked
            Image image = (Image)sender;

            //Get the name of the rectangle that corresponds to the image that was clicked
            string rectangleName = $"{image.Tag.ToString()}Rectangle";

            ///MessageBox.Show(rectangleName);

            //Find the rectangle that corresponds to the image that was clicked
            Rectangle rectangle = (Rectangle)FindName(rectangleName);

            MainWindow.game.PlayerAvatarPath = $"assets/{image.Tag.ToString()}.png";
            //Update the rectangle to have a red background
            rectangle.Fill = new SolidColorBrush(Colors.Red);

            //
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.UpdatePlayerDetails();

        }
    }
}
