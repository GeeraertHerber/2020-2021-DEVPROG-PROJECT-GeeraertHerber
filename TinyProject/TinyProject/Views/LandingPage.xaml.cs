using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TinyProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            TapGestureRecognizer tapCharachter = new TapGestureRecognizer();
            tapCharachter.Tapped += TapCharacterTapped;
            frmCharacter.GestureRecognizers.Add(tapCharachter);


            TapGestureRecognizer tapQuote = new TapGestureRecognizer();
            tapQuote.Tapped += TapQuoteTapped;
            frmQuote.GestureRecognizers.Add(tapQuote);

            TapGestureRecognizer tapDeath = new TapGestureRecognizer();
            tapDeath.Tapped += TapDeathTapped;
            frmDeaths.GestureRecognizers.Add(tapDeath);

            TapGestureRecognizer tapRandom = new TapGestureRecognizer();
            tapRandom.Tapped += TapRandomTapped;
            frmRandom.GestureRecognizers.Add(tapRandom);
        }

        
        private void TapCharacterTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PersonPage());
        }

        private void TapQuoteTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuotePage());
        }

        private void TapDeathTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeathPage());
        }

        private void TapRandomTapped(object sender, EventArgs e)
        {
            //var random = new Random();
            //var pages = new List<String> { "DeathPage", "QuotePage", "PersonPage" };
            //int index = random.Next(pages.Count);
            //Console.WriteLine(pages[index]);
            Navigation.PushAsync(new PersonPage());
        }
    }
}