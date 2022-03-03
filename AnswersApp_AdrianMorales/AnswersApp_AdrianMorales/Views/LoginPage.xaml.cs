using AnswersApp_AdrianMorales.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnswersApp_AdrianMorales.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        // Show or ocult the password
        public void CmdSeePassword(object sender, ToggledEventArgs e)
        {
            TxtPassword.IsPassword = !SwSeePassword.IsToggled;
        }

        // Métodos de capa gráfica, es necesario el await
        private async void CmdUserRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserRegisterPage());
        }
    }
}