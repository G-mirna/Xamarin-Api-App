using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UsoApiTurismo
{
    public class lugaresViewModel : INotifyPropertyChanged
    {
            public lugaresViewModel()
            {
                LoadData();
            }

            private async void LoadData()
            {
                await GetProductsAsync();
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private List<lugares> _lugares;
            public List<lugares> Lugares
            {
                get { return _lugares; }
                set
                {
                _lugares = value;
                    OnPropertyChanged();
                }
            }

            private ApiService _apiService = new ApiService();

            public async Task GetProductsAsync()
            {
            Lugares = await _apiService.GetProductsAsync();
            }

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
