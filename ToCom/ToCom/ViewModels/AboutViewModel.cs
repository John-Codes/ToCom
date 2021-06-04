using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using ToCom.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ToCom.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            SelectedCommand = new AsyncCommand<Food>(Selected);
            Foods = new List<Food> {
                     new Food { Name="Arroz", Price=3},
                      new Food { Name="habichuelas", Price=5},
                      new Food { Name="Viandas", Price=2},
                      new Food { Name="Pan", Price=4},

            };
            
        }
        private List<Food> foods;

        public List<Food> Foods
        {
            get { return foods; }
            set { foods = value; }
        }



        private Food selectedfood;

        public Food SelectedFood
        {
            get { return selectedfood; }
            set { selectedfood = value; }
        }
        async Task Selected(Food food)
        {
            if(food == null)
            return;
            await Application.Current.MainPage.DisplayAlert("Selected", food.Name,"ok");
        }





        public AsyncCommand<Food> SelectedCommand { get; }


        public ICommand OpenWebCommand { get; }
    }
}