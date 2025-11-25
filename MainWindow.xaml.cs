using Ookii.Dialogs.Wpf;
using System.Windows;

namespace NET10WineBugReproduceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = SelectEXEFile();
            MessageBox.Show($"You selected:\n{result}");
        }

        // from Reloaded-II Reloaded.Mod.Launcher.Lib/Commands/Application/AddApplicationCommand.cs
        // https://github.com/Reloaded-Project/Reloaded-II/blob/master/source/Reloaded.Mod.Launcher.Lib/Commands/Application/AddApplicationCommand.cs
        // Note: intentionally uses SaveFileDialog due to Microsoft Store access permissions instead of OpenFileDialog
        private string SelectEXEFile()
        {
            var dialog = new VistaSaveFileDialog();
            dialog.OverwritePrompt = false;
            dialog.Title = "Some title";
            dialog.Filter = "Executable (*.exe)|*.exe";
            if ((bool)dialog.ShowDialog()!)
                return dialog.FileName;
            return "";
        }
    }
}