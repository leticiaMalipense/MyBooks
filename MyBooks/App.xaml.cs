using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyBooks.DataBase;

namespace MyBooks
{
    public partial class App : Application
    {
        private static BaseData dbConnection;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        internal static BaseData Connection
        {
            get
            {
                if (dbConnection == null)
                {
                    dbConnection = new BaseData(DependencyService.Get<IFileHelper>().GetLocalFilePath("MyBooks.db3"));
                }
                return dbConnection;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        
    }
}
