using ConsultaCepMobile.Models;
using ConsultaCepMobile.Services;
using ConsultaCepMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsultaCepMobile.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }

        private void MetodoPesquisaCEP(object sender, EventArgs e)
        {
            PesquisaCEP pesquisaCEP = new PesquisaCEP();

            ViaCEP oViacep = new ViaCEP();
            oViacep = pesquisaCEP.Consulta(TextCepADD.Text);

            lbl_logradouro.Text = oViacep.logradouro;
        }
    }
}