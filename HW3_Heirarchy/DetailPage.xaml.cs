using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW3_Heirarchy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public string theURL { get; set; }
        public string theDetails { get; set; }

        // a new page to display details when a fish pic or lake pic is clicked from the ListView
        // the constructor args are properties of the ListView item that is clicked
        public DetailPage(string url, string details)
        {
            InitializeComponent();
            theURL = url;
            theDetails = details;
            BindingContext = this;
        }

        // when user clicks the home button from details page - return to root page
        async void OnHomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}