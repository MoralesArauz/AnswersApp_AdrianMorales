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
    public partial class UserRegisterPage : ContentPage
    {
        public UserRegisterPage()
        {
            InitializeComponent();
        }

        private async void CmdCancelRegister(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void CmdRegisterUser(object sender, EventArgs e)
        {
            await DisplayAlert("Success!", "Registration was successful", "OK");
            //await Navigation.PopAsync();

        }

        private void CmdSeePassword(object sender, ToggledEventArgs e)
        {
            TxtPassword.IsPassword = !SwSeePassword.IsToggled;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //lets the Entry be empty
            if (string.IsNullOrEmpty(e.NewTextValue)) return;

            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }
    }
}