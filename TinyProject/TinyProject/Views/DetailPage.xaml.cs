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
        public DetailPage(int itemIndex)
        {
            ItemIndex = itemIndex;
            InitializeComponent();
            Console.WriteLine(ItemIndex);
            ShowCharacter();
        }

        public async void ShowCharacter()
        {
            List<Character> character = await BBRepository.GetOneCharacterAsync(ItemIndex);
            Console.WriteLine(character[0].name);
            lblName.Text = character[0].name;
            lblAppearance.Text = character[0].AppearanceToString;
            imgUrl.Source = character[0].img;
        }
    }
}