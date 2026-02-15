using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiPractica.Models;
using MauiPractica.Services;

public partial class MainViewModel : ObservableObject
{
    private readonly EmpleadoService _empleadoService;

    [ObservableProperty]
    private List<Empleado> empleados;

    public IRelayCommand<Empleado> VerDetallesCommand { get; }
    private Empleado _empleadoSeleccionado;

    public MainViewModel(EmpleadoService empleadoService)
    {
        _empleadoService = empleadoService;
        VerDetallesCommand = new RelayCommand<Empleado>(VerDetalles);
        LoadData();
    }
    private async void LoadData()
    {
        Empleados = await _empleadoService.GetAllAsync();
    }

    private async void VerDetalles(Empleado emp)
    {
        await Shell.Current.GoToAsync(
            "empleadoDetalle",
            new ShellNavigationQueryParameters
            { { "Empleado", emp }
            });
    }
    public Empleado EmpleadoSeleccionado
    {
        get => _empleadoSeleccionado;
        set
        {
            _empleadoSeleccionado = value;
            OnPropertyChanged();
        }
    }
}
