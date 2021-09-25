using System.Reflection;
using System.Windows;

namespace SelfUpdatingApp
{
    public partial class AboutWindow : Window
    {
        public static readonly AboutWindow AboutWindowInstance = new AboutWindow();

        private AboutWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            ApplicationName.Content = Assembly.GetExecutingAssembly().GetName().Name;
            Version.Text = UpdateChecker.GetApplicationVersion();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}