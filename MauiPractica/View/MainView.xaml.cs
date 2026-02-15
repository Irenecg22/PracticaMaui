using MauiPractica.ViewModels;

namespace MauiPractica.View;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel mainViewModel)
	{
		BindingContext = mainViewModel;
		InitializeComponent();
	}
}