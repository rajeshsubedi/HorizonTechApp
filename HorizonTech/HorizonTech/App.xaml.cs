using SQLitePCL;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data.SQLite;
using HorizonTech.FeaturesDatabase;
using HorizonTech.Helpers;

namespace HorizonTech
{
    public partial class App : Application
    {


        // for homepage database

        static Database dB;

        public static Database Database
        {
            get
            {
                if (dB == null)
                {
                    dB = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return dB;
            }
        }

        //in feature 1
        static Database1 database1;

        public static Database1 Database1
        {
            get
            {
                if (database1 == null)
                {
                    database1 = new Database1(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database1;
            }
        }

        //in feature 2
        private static sqlite db;

        public static sqlite MyDatabase
        {
            get
            {
                if (db == null)
                {
                    db = new sqlite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyStore.db3"));
                }
                return db;
            }
        }




        //------------------------------for access token---------------------------------




        //public App()
        //{
        //    InitializeComponent();

        //    //MainPage = new NavigationPage(new Page1());

        //    SetMainPage();
        //}

        //private void SetMainPage()
        //{
        //    if (!string.IsNullOrEmpty(Setting.AccessToken))
        //    {
        //        MainPage = new NavigationPage(new MainPage());
        //    }
        //    else
        //    {
        //        MainPage = new NavigationPage(new Page1());
        //    }
        //}














        //<------------------------------------------------------------------------------------------------>

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
