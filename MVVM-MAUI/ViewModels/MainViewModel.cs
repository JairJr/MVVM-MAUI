using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM_MAUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel(string carName)
        {
            this.carName = carName;
        }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(CarSelected))]        
        private string carName;


        public string CarSelected => $"Carro que eu quero é o : {carName}";

        [RelayCommand]
        async Task EnviarFormularioAsync()
        {
            await Shell.Current.DisplayAlert("Alerta", "Carro Selecionado!", "OK");
            return;
        }
    }





}
