using System;
using System.Collections.Generic;

using Xamarin.Forms;
using FreshMvvm;

namespace Icatuzinho
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            //var loginPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<LoginPageModel>(); 
            //var loginContainer = new FreshMvvm.FreshNavigationContainer(loginPage,"LoginContainer");

            MainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
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

