using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Escolha1_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new TelaInicial());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }


        }

        private void Escolha2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new TelaInicial());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }

        private void Escolha3_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new TelaInicial());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }
    }
}