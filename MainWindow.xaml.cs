using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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
    }
}