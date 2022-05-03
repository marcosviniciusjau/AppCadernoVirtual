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

            PortuguesPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.portugues.png");
            InglesPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.ingles.png");
            MatematicaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.matematica.png");
            QuimicaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.quimica.png");
            FisicaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.fisica.png");
            BiologiaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.biologia.png");
            GeografiaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.geografia.png");
            HistoriaPrimeiro.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.historia.png");
            
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
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void QuimicaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void FisicaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void BiologiaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void GeografiaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void HistoriaPrimeiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }
    }
}