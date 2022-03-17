using E1P6NatalieApp.ViewModels;
using E1P6NatalieApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace E1P6NatalieApp
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
