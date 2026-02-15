using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using Microsoft.Maui;

namespace MauiPractica.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<AppTheme> themes = new()
        {
            AppTheme.Unspecified, 
            AppTheme.Dark,
            AppTheme.Light
        };

        [ObservableProperty]
        private AppTheme selectedTheme = Application.Current.UserAppTheme;

        [RelayCommand]
        private void SaveSettings()
        {
            Application.Current.UserAppTheme = SelectedTheme;
        }
    }
}

