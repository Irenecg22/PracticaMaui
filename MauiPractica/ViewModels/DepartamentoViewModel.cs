using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiPractica.Models;
using MauiPractica.Services;

public partial class DepartamentoViewModel : ObservableObject
{
    private readonly DepartamentoService _departamentoService;
    private Departamento _departamentoSeleccionado;


    [ObservableProperty]
    private List<Departamento> departamentos;

    public IRelayCommand<Departamento> VerDetallesCommand { get; }

    public DepartamentoViewModel(DepartamentoService departamentoService)
    {
        _departamentoService = departamentoService;
        VerDetallesCommand = new RelayCommand<Departamento>(VerDetalles);
        LoadData();
    }

    private async void LoadData()
    {
        Departamentos = await _departamentoService.GetAllAsync();
    }

    private async void VerDetalles(Departamento dept)
    {
        await Shell.Current.GoToAsync(
            "departamentoDetalle",
            new ShellNavigationQueryParameters
            { { "Departamento", dept }
            });
    }
    public Departamento DepartamentoSeleccionado
    {
        get => _departamentoSeleccionado;
        set
        {
            _departamentoSeleccionado = value;
            OnPropertyChanged();
        }
    }
}

