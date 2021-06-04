using System;
using System.Collections.Generic;
using ToCom.ViewModels;
using ToCom.Views;
using Xamarin.Forms;

namespace ToCom
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
