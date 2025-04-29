using GameReaderCommon;
using SimHub.Plugins;
using System;
using System.Windows.Interop;
using System.Windows.Media;

namespace Kuramochia.SoftwareRenderingPlugin
{
    [PluginDescription("Setting WPF Sofware Rendering Mode.")]
    [PluginAuthor("kuramochia")]
    [PluginName("Software Rendering Plugin")]
    public class SoftwareRenderingPlugin : IPlugin, IWPFSettingsV2
    {
        public SoftwareRenderingSettings Settings;

        /// <summary>
        /// Instance of the current plugin manager
        /// </summary>
        public PluginManager PluginManager { get; set; }

        /// <summary>
        /// Gets the left menu icon. Icon must be 24x24 and compatible with black and white display.
        /// </summary>
        public ImageSource PictureIcon => this.ToIcon(Properties.Resources.sdkmenuicon);

        /// <summary>
        /// Gets a short plugin title to show in left menu. Return null if you want to use the title as defined in PluginName attribute.
        /// </summary>
        public string LeftMenuTitle => "Software Rendering Plugin";


        /// <summary>
        /// Called at plugin manager stop, close/dispose anything needed here !
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void End(PluginManager pluginManager)
        {
            // Save settings
            this.SaveCommonSettings("SoftwareRenderingSettings", Settings);
        }

        /// <summary>
        /// Returns the settings control, return null if no settings control is required
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <returns></returns>
        public System.Windows.Controls.Control GetWPFSettingsControl(PluginManager pluginManager)
        {
            return new SettingsControl(this);
        }

        /// <summary>
        /// Called once after plugins startup
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void Init(PluginManager pluginManager)
        {
            SimHub.Logging.Current.Info("Starting plugin");

            // Load settings
            Settings = this.ReadCommonSettings<SoftwareRenderingSettings>("SoftwareRenderingSettings", () => new SoftwareRenderingSettings());

            RenderMode renderMode = Settings.IsEnabled ? RenderMode.SoftwareOnly : RenderMode.Default;
            RenderOptions.ProcessRenderMode = renderMode;
        }
    }
}