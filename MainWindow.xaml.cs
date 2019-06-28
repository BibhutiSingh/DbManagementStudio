using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DbManagementStudio.Plugin.SQLite;
namespace DbManagementStudio
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var lst=Core.MasterDbConnections.GetAllConnections();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void AddConnection(object sender,RoutedEventArgs e)
        {
            SqliteConnectionManager mgr=new SqliteConnectionManager();
            mgr.AddConnection();
        }
    }
}