using AppCadernoVirtual.Segundo;
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
    public partial class TelaInicialSegundo : ContentPage
    {
        public TelaInicialSegundo()
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
            Navigation.PushAsync(new PortuguesSegundo());
        }


        private void BtnInglesSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesSegundo());
        }

        private void BtnMatematicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaSegundo());
        }

        private void BtnQuimicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaSegundo());
        }

        private void BtnFisicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaSegundo());
        }

        private void BtnBiologiaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaSegundo());
        }

        private void BtnGeografiaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaSegundo());
        }

        private void BtnHistoriaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaSegundo());
        }

        private void BtnEtica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Etica());
        }

        private void BtnFilosofiaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaSegundo());
        }

        private void BtnEducacaoFisicaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EducacaoFisicaSegundo());
        }

        private void BtnSociologiaSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaSegundo());
        }

        private void BtnBD2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BD2());
        }

        private void BtnPW2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PW2());
        }

        private void BtnMobile1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mobile1());
        }

        private void BtnSistemasEmbarcados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SistemasEmbarcados());
        }

        private void BtnDesenvolvimento_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Desenvolvimento());
        }

    }
}