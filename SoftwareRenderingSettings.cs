namespace Kuramochia.SoftwareRenderingPlugin
{
    /// <summary>
    /// Settings class, make sure it can be correctly serialized using JSON.net
    /// </summary>
    public class SoftwareRenderingSettings
    {
        public bool IsEnabled { get; set; } = true;
    }
}