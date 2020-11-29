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
        public string Parameters { get; set; }
        public List<Character> Characters { get; set; }
        public Character ClickedCharacter { get; private set; }

        public PersonPage(List<Character> characters = null)
        {
            InitializeComponent();
            
            Characters = characters;
            ShowPersons();
            

        }

        private async void ShowPersons()
        {
            if(Characters == null)
            {
                lvwPersons.ItemsSource = await BreakingBadRepository.GetCharactersAsync();
            }
            else
            {
                lvwPersons.ItemsSource = Characters;
            }

        }



        private void btnGoBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void lvwPersons_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Character character = (Character)lvwPersons.SelectedItem;
            Navigation.PushAsync(new DetailPage(clickedCharacter: character));
            Console.WriteLine(character.name);
            Console.WriteLine(character.OccupationToString);
            //Navigation.PushAsync(new DetailPage(e.ItemIndex+1, null));
        }

        private async void btnSearch_ClickedAsync(object sender, EventArgs e)
        {
            Parameters = lblNameFilter.Text;
            Console.WriteLine(Parameters);
            List<Character> characters = await BreakingBadRepository.GetCharactersAsync(Parameters);
            Console.WriteLine(characters[0].name);
            if(characters.Count == 1)
            {
                Navigation.PushAsync(new DetailPage(clickedCharacter: characters[0]));
            }
            else
            {
                Characters = characters;
                ShowPersons();
            }
            

        }
    }
}