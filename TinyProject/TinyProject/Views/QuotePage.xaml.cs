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
    public partial class QuotePage : ContentPage
    {
        public int ItemIndex { get; set; }
        public QuotePage(int itmIndex = 0)
        {
            ItemIndex = ItemIndex;
            InitializeComponent();
        }
    }
}