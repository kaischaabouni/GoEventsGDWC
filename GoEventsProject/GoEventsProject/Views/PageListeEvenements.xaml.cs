using GoEventsProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoEventsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListeEvenements : ContentPage
    {
        ObservableCollection<Evenement> evenements = new ObservableCollection<Evenement>();

        public PageListeEvenements()
        {
            InitializeComponent();

            EvenementsView.ItemsSource = evenements;

            // Remplissage à la main
            evenements.Add(new Evenement { IdEvenement = 1, Titre = "Rob Finnerty", Description = "Finnerty", UrlImage = "iconfootball.png" });
            evenements.Add(new Evenement { IdEvenement = 2, Titre = "Rob Finnerty", Description = "Finnerty", UrlImage = "basketicon.png" });
            evenements.Add(new Evenement { IdEvenement = 3, Titre = "Rob Finnerty", Description = "Finnerty", UrlImage = "cardicon.png" });
            evenements.Add(new Evenement { IdEvenement = 4, Titre = "Rob Finnerty", Description = "Finnerty", UrlImage = "muscic_icon.png" });
            evenements.Add(new Evenement { IdEvenement = 5, Titre = "Rob Finnerty", Description = "Finnerty", UrlImage = "basketicon.png" });
            evenements.Add(new Evenement { IdEvenement = 6, Titre = "Rob Finnerty", Description = "Finnerty", UrlImage = "iconfootball.png" });
            evenements.Add(new Evenement { IdEvenement = 7, Titre = "Rob Finnerty", Description = "Finnerty", UrlImage = "jeux_video_icon.png" });

        }

        void enEvenementSelectionne(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }
    }
}