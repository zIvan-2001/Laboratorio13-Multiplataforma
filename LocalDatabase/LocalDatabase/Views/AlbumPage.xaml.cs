﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocalDatabase.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDatabase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumPage : ContentPage
    {
        public AlbumPage()
        {
            InitializeComponent();
            this.BindingContext = new AlbumViewModel();
        }
    }
}
