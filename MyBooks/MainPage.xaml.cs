﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyBooks.models;
using MyBooks.Views;

namespace MyBooks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listBooks.ItemsSource = await App.Connection.findAll();
            listBooks.HasUnevenRows = true;
        }

        void OnItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new BookCreated()
                {
                    BindingContext = args.SelectedItem as Book
                });
            }
        }

        void onClicked(System.Object sender, System.EventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new BookCreated()
                {
                    BindingContext = new Book()
                });
            }
        }

        void OnDetails(System.Object sender, System.EventArgs e)
        {
        }

        void Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs args)
        {
         
        }
    }
}
