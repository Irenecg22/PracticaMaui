using CommunityToolkit.Mvvm.ComponentModel;
using MauiPractica.Models;

namespace MauiPractica.ViewModels
{
    [QueryProperty(nameof(Departamento), "Departamento")]
    public partial class DepartamentoDetalleViewModel : ObservableObject
    {
        [ObservableProperty]
        private Departamento departamento;
    }
}

