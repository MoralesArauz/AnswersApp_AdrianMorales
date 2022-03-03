using AnswersApp_AdrianMorales.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AnswersApp_AdrianMorales.Views
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