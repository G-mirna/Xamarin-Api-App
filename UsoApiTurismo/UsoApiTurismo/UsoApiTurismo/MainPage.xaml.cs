using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using UsoApiTurismo;

namespace UsoApiTurismo
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var viewModel = new lugaresViewModel();
            BindingContext = viewModel;

            LoadDataAsync(viewModel);
        }
        private async void LoadDataAsync(lugaresViewModel viewModel)
        {
            await viewModel.GetProductsAsync();
        }
    }
}
