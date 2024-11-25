using System.Globalization;
using MauiLocDemo.Resources;

namespace MauiLocDemo;

public partial class MainPage : ContentPage
{
	int count = 0;
	public LocalizationResourceManager LocalizationResourceManager => LocalizationResourceManager.Instance;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
		
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var switchCulture = JeffResources.Culture.TwoLetterISOLanguageName.Equals("en")?
			new CultureInfo("fr-FR"):new CultureInfo("en-US");
		
		LocalizationResourceManager.Instance.SetCulture(switchCulture);
		
		count++;

		// if (count == 1)
		// 	CounterBtn.Text = $"Clicked {count} time";
		// else
		// 	CounterBtn.Text = $"Clicked {count} times";

		CounterBtn.Text = string.Format(LocalizationResourceManager.Instance["CounterClicked"].ToString(), count);
		
		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

