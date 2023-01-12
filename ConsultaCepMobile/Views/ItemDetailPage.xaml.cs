using ConsultaCepMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ConsultaCepMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}