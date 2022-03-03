using AnswersApp_AdrianMorales.ViewModels;
using AnswersApp_AdrianMorales.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AnswersApp_AdrianMorales
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
