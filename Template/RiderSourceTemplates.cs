using Dalamud.Logging;
using JetBrains.Annotations;

namespace BernaCommonLib.Template;

public static class RiderSourceTemplates
{
    [SourceTemplate]
    public static void log(this string obj)
    {
        PluginLog.Debug(obj);
    }

    [SourceTemplate]
    public static void logobj(this object obj)
    {
        PluginLog.Debug(obj.ToString());
    }
}
