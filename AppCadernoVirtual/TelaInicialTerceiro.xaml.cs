using AppCadernoVirtual.Terceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaInicialTerceiro : ContentPage
    {
        public TelaInicialTerceiro()
        {
            InitializeComponent();
            BtnPortuguesSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.portugues.png");
            BtnInglesSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.ingles.png");
            BtnMatematicaSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.matematica.png");
            BtnQuimicaSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.quimica.png");
            BtnFisicaSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.fisica.png");
            BtnBiologiaSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.biologia.png");
            BtnGeografiaSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.geografia.png");
            BtnHistoriaSegundo.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.historia.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnPortuguesSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnPortuguesSegundo_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnInglesSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnMatematicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnQuimicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnFisicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnBiologiaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnGeografiaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnHistoriaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnEtica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnFilosofiaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnEducacaoFisicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnSociologia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnBD2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnPW2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnMobile1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnSistemasEmbarcados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnDesenvolvimento_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }
    }
}