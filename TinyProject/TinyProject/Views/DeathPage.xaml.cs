﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TinyProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeathPage : ContentPage
    {
        public int ItemIndex { get; set; }
        public DeathPage(int itemIndex = 0)
        {
            ItemIndex = itemIndex;
            InitializeComponent();
        }
    }
}