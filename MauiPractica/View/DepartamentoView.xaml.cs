using MauiPractica.ViewModels;

namespace MauiPractica.View;

public partial class DepartamentoView : ContentPage
{
	public DepartamentoView(DepartamentoViewModel departamentoViewModel)
	{
		BindingContext= departamentoViewModel;
		InitializeComponent();
	}
}