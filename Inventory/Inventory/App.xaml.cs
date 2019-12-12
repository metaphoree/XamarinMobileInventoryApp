﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inventory
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new TabbedPage
            {
                Children ={
                new MainPage(),
                new NextPage_2(),
                new NextPage_3()
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}