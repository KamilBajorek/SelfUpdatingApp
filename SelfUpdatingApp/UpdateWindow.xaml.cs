using System;
using System.Diagnostics;
using System.Windows;
using SelfUpdatingApp.Properties;
using System.IO.Compression;
using System.Reflection;

namespace SelfUpdatingApp
{
    public partial class UpdateWindow : Window
    {
        public static readonly UpdateWindow UpdateWindowInstance = new UpdateWindow();

        private UpdateWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            Title.Content = Properties.Resources.UpdateWindowTitle;
            Message.Text = Properties.Resources.UpdateWindowMessage;
            Confirm.Content = Properties.Resources.UpdateWindowConfirm;
            Cancel.Content = Properties.Resources.UpdateWindowCancel;
        }

        private void Confirm_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ArchiveCurrentVersion();

                Process installer = Process.Start(@Settings.Default.installerPath + Settings.Default.setupFileName);

                installer?.WaitForExit();

                Application.Current.Shutdown();
            }
            catch (Exception exception)
            {
                Debug.Write("An error occurred while installing a new version, message: " + exception.Message);
            }
        }

        private void ArchiveCurrentVersion()
        {
            ZipFile.CreateFromDirectory(AppDomain.CurrentDomain.BaseDirectory,
                Settings.Default.archivePath + "\\" + GetArchiveName());
        }

        private string GetArchiveName()
        {
            return Assembly.GetExecutingAssembly().GetName().Name + "__" + UpdateChecker.GetApplicationVersion() +
                   Settings.Default.zipExtension;
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}