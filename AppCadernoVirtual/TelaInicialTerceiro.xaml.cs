﻿using AppCadernoVirtual.Terceiro;
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

        private void BtnPortuguesTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesTerceiro());
        }


        private void BtnInglesTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesTerceiro());
        }

        private void BtnMatematicaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaTerceiro());
        }

        private void BtnQuimicaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaTerceiro());
        }

        private void BtnFisicaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaTerceiro());
        }

        private void BtnBiologiaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaTerceiro());
        }

        private void BtnGeografiaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaTerceiro());
        }

        private void BtnHistoriaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaTerceiro());
        }

        private void BtnFilosofiaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaTerceiro());
        }

        private void BtnEducacaoFisicaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EducacaoFisicaTerceiro());
        }

        private void BtnSociologiaTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaTerceiro());
        }

        private void BtnPW3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PW3());
        }

        private void BtnMobile2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mobile2());
        }

    }
}