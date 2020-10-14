using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MyBooks.models;

namespace MyBooks.Views
{
    public partial class BookCreated : ContentPage
    {

        public BookCreated(Boolean hasDelete)
        {
            InitializeComponent();

            if (!hasDelete) {
                btnExcluir.IsVisible = false;
            }
        }

        void OnSaveBook(System.Object sender, System.EventArgs e)
        {
            Book b = BindingContext as Book;
            App.Connection.insert(b);
            Navigation.PopAsync();
        }

        void OnDeleteBook(System.Object sender, System.EventArgs e)
        {
            Book b = BindingContext as Book;
            App.Connection.delete(b);
            Navigation.PopAsync();
        }

    }
}
