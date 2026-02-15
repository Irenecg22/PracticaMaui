using CommunityToolkit.Mvvm.ComponentModel;
using MauiPractica.Models;

namespace MauiPractica.ViewModels
{
    [QueryProperty(nameof(Empleado), "Empleado")]
    public partial class MainDetalleViewModel : ObservableObject
    {
        [ObservableProperty]
        private Empleado empleado;
    }
}

