using SimHub.Plugins.Styles;
using System.Runtime;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;

namespace Kuramochia.SoftwareRenderingPlugin
{
    /// <summary>
    /// Logique d'interaction pour SettingsControlDemo.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SoftwareRenderingPlugin Plugin { get; }

        public SettingsControl()
        {
            InitializeComponent();
        }

        public SettingsControl(SoftwareRenderingPlugin plugin) : this()
        {
            this.Plugin = plugin;
            toggle.IsChecked = plugin.Settings.IsEnabled;
        }

        private void SHToggleCheckbox_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            Plugin.Settings.IsEnabled = true;
            UpdateMode();
        }

        private void SHToggleCheckbox_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            Plugin.Settings.IsEnabled = false;
            UpdateMode();
        }

        private void UpdateMode()
        {
            RenderMode renderMode = Plugin.Settings.IsEnabled ? RenderMode.SoftwareOnly : RenderMode.Default;
            RenderOptions.ProcessRenderMode = renderMode;
        }
    }
}