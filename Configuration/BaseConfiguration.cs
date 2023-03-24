using Dalamud.Configuration;

namespace BernaCommonLib.Configuration;

public class BaseConfiguration : IPluginConfiguration
{
    public PluginVersion PluginVersion { get; set; } = PluginVersion.From(0, 0, 0);
    public int Version { get; set; } = -1;
}