using System;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //O BtnPrimeiro.Source armazenará a imagem do botão
            logo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.logo.png");
            BtnPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.primeiro.png");
            BtnSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.segundo.png");
            BtnTerceiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.terceiro.png");

            //Esta instrução tirará a barra de navegação
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Escolha1_Clicked(object sender, EventArgs e)
        {
            //Aqui o botão executará o comando try que irá navegar para a tela inicial ao ser clicado
            try
            {
                Navigation.PushAsync(new TelaInicial());
            }
            // O catch é o se não. Se não der certo o comando acima dará um erro
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }


        }

        private void Escolha2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new TelaInicialSegundo());
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
                Navigation.PushAsync(new TelaInicialTerceiro());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }
    }
}