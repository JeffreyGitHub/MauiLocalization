using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MauiLocDemo.Extension;

public class Translator: INotifyPropertyChanged
{
    public string this[string key]
    {
        get => Resources.JeffResources.ResourceManager.GetString(key, CurrentCulture) ?? string.Empty;
    }
    public CultureInfo CurrentCulture { get; set; }
    public static Translator Instance { get; } = new Translator();
    
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged()
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }
    
}