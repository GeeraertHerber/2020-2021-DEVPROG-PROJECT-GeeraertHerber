using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyProject.Models;
using Xamarin.Forms;

namespace TinyProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestModels();
        }

        public async void TestModels()
        {

            List<Character> characters = await BBRepository.GetCharactersAsync();
            Debug.WriteLine($"Aantal Characters: {characters.Count}");
        }
    }
}
