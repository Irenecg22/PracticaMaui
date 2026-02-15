using MauiPractica.ViewModels;

namespace MauiPractica.View;

public partial class SettingsView : ContentPage
{
	public SettingsView(SettingsViewModel settingsViewModel)
	{
		BindingContext = settingsViewModel;
		InitializeComponent();
	}
}