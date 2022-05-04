using System;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BtnPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.primeiro.png");
            BtnSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.segundo.png");
            BtnTerceiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.terceiro.png");

            NavigationPage.SetHasNavigationBar(this, false);
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