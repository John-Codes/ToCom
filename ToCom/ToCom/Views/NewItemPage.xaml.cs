using System;
using System.Collections.Generic;
using System.ComponentModel;
using ToCom.Models;
using ToCom.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToCom.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}