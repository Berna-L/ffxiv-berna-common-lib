using BernaCommonLib.Configuration;
using KamiLib.Interfaces;

namespace BernaCommonLib.Windows;

public interface ConfigPane: ISelectable, IDrawable {

}

public abstract class ConfigPane<T>: ConfigPane
{
    protected readonly T configuration;

    public IDrawable Contents => this;
    public string ID => $"##{GetType()}";

    protected ConfigPane(T configuration)
    {
        this.configuration = configuration;
    }

    public abstract void DrawLabel();

    public abstract void Draw();
}
