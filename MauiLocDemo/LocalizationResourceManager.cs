using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using MauiLocDemo.Resources;

namespace MauiLocDemo;

public class LocalizationResourceManager:INotifyPropertyChanged
{
    private LocalizationResourceManager()
    {
        JeffResources.Culture=CultureInfo.CurrentCulture;
    }

    public static LocalizationResourceManager Instance { get; private set; } = new();
    
    public object this[string key] 
        => JeffResources.ResourceManager.GetObject(key,JeffResources.Culture) ?? Array.Empty<byte>();
    
    
    public event PropertyChangedEventHandler? PropertyChanged;

    public void SetCulture(CultureInfo culture)
    {
        JeffResources.Culture = culture;
        // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(JeffResources.Culture)));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }

    // protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    // {
    //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    // }
    //
    // protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    // {
    //     if (EqualityComparer<T>.Default.Equals(field, value)) return false;
    //     field = value;
    //     OnPropertyChanged(propertyName);
    //     return true;
    // }
}