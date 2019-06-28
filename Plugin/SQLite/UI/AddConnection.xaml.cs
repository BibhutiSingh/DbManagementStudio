using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DbManagementStudio.Plugin.SQLite.UI
{
    public class AddConnection : Window
    {
        public AddConnection()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        
    }
}