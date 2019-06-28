using Avalonia;
using Avalonia.Markup.Xaml;

namespace DbManagementStudio
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}