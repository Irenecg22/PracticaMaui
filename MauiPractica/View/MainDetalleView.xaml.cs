using MauiPractica.ViewModels;

namespace MauiPractica.View;

public partial class MainDetalleView : ContentPage
{
	public MainDetalleView(MainDetalleViewModel mainDetalleViewModel)
	{
        InitializeComponent();
        BindingContext =mainDetalleViewModel;
		
	}
}