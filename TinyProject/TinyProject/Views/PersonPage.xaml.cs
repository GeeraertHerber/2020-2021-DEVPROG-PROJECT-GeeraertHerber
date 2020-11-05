using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TinyProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPage : ContentPage
    {
        public PersonPage()
        {
            InitializeComponent();
            ShowPersons();
        }

        private async void ShowPersons()
        {
            lvwPersons.ItemsSource = await BBRepository.GetCharactersAsync();
        }

        private void btnGoBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void lvwPersons_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetailPage(e.ItemIndex+1));
        }
    }
}