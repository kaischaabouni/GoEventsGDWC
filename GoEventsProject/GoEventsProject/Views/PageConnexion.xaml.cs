using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoEventsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageConnexion : ContentPage
    {
        public PageConnexion()
        {
            InitializeComponent();
        }

        async Task EnClicConnexion(object sender, EventArgs args)
        {


            HttpClient client = new HttpClient();

            try
            {
                var uri = "https://goeventservices.000webhostapp.com/connexion.php";
                //var response = await client.GetAsync(uri);
                Models.MConnexion modeleConnexion = new Models.MConnexion();

                // à modfier avec les coordonnees saisi dans formulaire
                modeleConnexion.login = "machin";
                modeleConnexion.motDePasse = "test";

                var json = JsonConvert.SerializeObject(modeleConnexion);
                var donneesAEnvoyer = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await client.PostAsync(uri, donneesAEnvoyer);
                


                if (response.IsSuccessStatusCode)
                {
                    var donneesRecues = await response.Content.ReadAsStringAsync();
                    Models.MReponseConnexion reponseConnexion = JsonConvert.DeserializeObject<Models.MReponseConnexion>(donneesRecues);
                    System.Diagnostics.Debug.WriteLine(reponseConnexion.messageErreur);

                    //var pageListeEvenements = new PageListeEvenements();
                    if (reponseConnexion.succesConnexion)
                    {
                        await Navigation.PushAsync(new PageListeEvenements());
                    } else
                    {
                        // à modifier après
                        await Navigation.PushAsync(new PageListeEvenements());
                    }
                }
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }




        }
    }
}