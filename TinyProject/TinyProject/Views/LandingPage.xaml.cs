using System;
using System.Collections.Generic;
using System.Linq;
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
            tapGestureRecognizer.Tapped += TapCharacterTapped;
            frmCharater.GestureRecognizers.Add(tapGestureRecognizer);

            TapGestureRecognizer tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += TapGestureRecognizer_Tapped1;
            frmOverview.GestureRecognizers.Add(tapGestureRecognizer1);

            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += TapGestureRecognizer_Tapped2;
            frmLogout.GestureRecognizers.Add(tapGestureRecognizer2);
        }
        private void TapCharachterTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverviewPage);
        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverviewPage(Email, User));
        }

        //Log-out
        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}