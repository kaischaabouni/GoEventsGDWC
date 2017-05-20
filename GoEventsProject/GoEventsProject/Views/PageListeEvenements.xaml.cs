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
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public PageListeEvenements()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            // Remplissage à la main
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick" });
        }
    }
}