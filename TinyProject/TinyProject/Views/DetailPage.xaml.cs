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
    public partial class DetailPage : ContentPage
    {
        public int ItemIndex { get; set; }
        public Character ClickedCharacter { get; set; }
        public DetailPage(int itemIndex = 0, Character clickedCharacter = null)
        {
            ItemIndex = itemIndex;
            ClickedCharacter = clickedCharacter;
            InitializeComponent();
            ShowCharacter();
            
        }

        public async void ShowCharacter()
        {
            if (ClickedCharacter == null)
            {
                List<Character> characters = await BreakingBadRepository.GetOneCharacterAsync(ItemIndex);
                MakeCharacter(characters);
            }
            else
            {
                List<Character> characters = new List<Character>();
                Console.WriteLine(ClickedCharacter.GetType());
                Console.WriteLine(characters.Count);
                characters.Add(ClickedCharacter);
                MakeCharacter(characters);
            }
        }

        public void MakeCharacter(List<Character> characters)
        {
            Console.WriteLine(characters[0].name);
            lblName.Text = characters[0].name;
            lblAppearance.Text = characters[0].AppearanceToString;
            imgUrl.Source = characters[0].img;
            lblNickname.Text = characters[0].nickname;
            lblStatus.Text = characters[0].status;
            lblOccupation.Text = characters[0].OccupationToString;
            lblBirthday.Text = characters[0].birthday;
        }

        private void btnQuotes_Clicked(object sender, EventArgs e)
        {

        }
    }
}