using MauiPractica.ViewModels;

namespace MauiPractica.View;

public partial class DepartamentoDetalleView : ContentPage
{
    public DepartamentoDetalleView(DepartamentoDetalleViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
