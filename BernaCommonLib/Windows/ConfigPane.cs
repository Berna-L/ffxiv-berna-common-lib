using BernaCommonLib.Configuration;
using KamiLib.Interfaces;

namespace BernaCommonLib.Windows;

public abstract class ConfigPane<T>: ISelectable, IDrawable where T: BaseConfiguration
{
    internal readonly T configuration;

    public IDrawable Contents => this;
    public string ID => $"##{GetType()}";

    protected ConfigPane(T configuration)
    {
        this.configuration = configuration;
    }

    public abstract void DrawLabel();

    public abstract void Draw();
}
