using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GoEventsProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            // Ouvrir la page d'Accueil
            NavigationPage navigationAppli = new NavigationPage(new GoEventsProject.Views.PageConnexion());
            MainPage = navigationAppli;
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
