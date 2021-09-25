using System;
using System.Windows;
using System.Windows.Forms;
using SelfUpdatingApp.Properties;
using Application = System.Windows.Application;

namespace SelfUpdatingApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
            Loaded += HandleUpdateNeed;
        }

        private void InitializeData()
        {
            MenuAbout.Header = Properties.Resources.MenuAboutName;
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (Settings.Default.archivePath == string.Empty)
            {
                Settings.Default.archivePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Settings.Default.Save();
            }

            ArchivePathField.Text = Settings.Default.archivePath;
            InstallerPathField.Text = Settings.Default.installerPath;
        }

        private void HandleUpdateNeed(object sender, RoutedEventArgs e)
        {
            UpdateChecker updateChecker = new UpdateChecker();

            if (updateChecker.IsUpdateNeeded())
            {
                OpenUpdateWindow();
            }
        }

        private void OpenUpdateWindow()
        {
            UpdateWindow updateWindow = UpdateWindow.UpdateWindowInstance;
            updateWindow.Show();
        }

        private void OpenAboutWindow(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = AboutWindow.AboutWindowInstance;
            aboutWindow.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            Settings.Default.installerPath = InstallerPathField.Text;
            Settings.Default.archivePath = ArchivePathField.Text;
            Settings.Default.Save();

            LoadSettings();
        }

        private void ArchivePathSet_OnClick(object sender, RoutedEventArgs e)
        {
            string selectedPath = SelectPath();

            if (selectedPath != null)
            {
                ArchivePathField.Text = selectedPath;
            }
        }

        private void InstallerPathSet_OnClick(object sender, RoutedEventArgs e)
        {
            string selectedPath = SelectPath();

            if (selectedPath != null)
            {
                InstallerPathField.Text = selectedPath;
            }
        }

        private string SelectPath()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult.ToString() != string.Empty)
            {
                return folderBrowserDialog.SelectedPath;
            }

            return null;
        }
    }
}