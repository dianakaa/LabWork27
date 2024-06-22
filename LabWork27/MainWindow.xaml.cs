using LabWork27.Pages;
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

namespace LabWork27
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ContentFrame.Navigate(new Pages.MainPage());

            ContentFrame.NavigationService.Navigate(new AuthorizationPage());
            ContentFrame.NavigationService.Navigate(new RegistrationPage());
            ContentFrame.NavigationService.Navigate(new SettingPage());

            Manager.MainFrame = ContentFrame;
        }

        public void ContentFrame_ContentRendered(object sender, NavigationEventArgs e)
        {
            BackButton.Visibility = ContentFrame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }

        public void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
        public class AuthorizationPage : Page { }
        public class RegistrationPage : Page { }
        public class SettingPage : Page { }
    }
}
