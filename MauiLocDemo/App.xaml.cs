using System.Globalization;
using MauiLocDemo.Extension;

namespace MauiLocDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Translator.Instance.CurrentCulture = CultureInfo.CreateSpecificCulture("fr-FR");
		MainPage = new AppShell();
	}
}
