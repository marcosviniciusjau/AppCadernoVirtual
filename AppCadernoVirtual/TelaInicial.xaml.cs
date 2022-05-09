using AppCadernoVirtual.Primeiro;
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
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();

            BtnPortuguesPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.portugues.png");
            BtnInglesPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.ingles.png");
            BtnMatematicaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.matematica.png");
            BtnQuimicaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.quimica.png");
            BtnFisicaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.fisica.png");
            BtnBiologiaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.biologia.png");
            BtnGeografiaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.geografia.png");
            BtnHistoriaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.historia.png");
            BtnEducacaoFisicaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.educacaofisica.png");
            BtnFilosofiaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.filosofia.png");
            BtnArtePrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.arte.png");
            BtnDesignDigital.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.design.png");
            BtnLogica.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.logica.png");
            BtnFundamentos.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.fundamentos.png");
            BtnAnalise.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.analise.png");
            BtnBD1.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.bd.png");
            BtnPW1.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.pw.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void PortuguesPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void InglesPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void MatematicaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaPrimeiro());
        }

        private void QuimicaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaPrimeiro());
        }

        private void FisicaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaPrimeiro());
        }

        private void BiologiaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaPrimeiro());
        }

        private void GeografiaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaPrimeiro());
        }

        private void HistoriaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaPrimeiro());
        }

        private void BtnArtePrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Arte());
        }

        private void BtnFilosofiaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaPrimeiro());
        }

        private void BtnEducacaoFisicaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EducacaoFisicaPrimeiro());
        }

        private void BtnAnalise_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Analise());
        }

        private void BtnBD1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BD1());
        }

        private void BtnPW1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PW1());
        }

        private void BtnLogica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogicaProgramacao());
        }

        private void BtnDesignDigital_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesignDigital());
        }

        private void BtnFundamentos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fundamentos());
        }
    }
}