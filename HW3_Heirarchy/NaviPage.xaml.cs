using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW3_Heirarchy
{
    [DesignTimeVisible(false)]
    public partial class NaviPage : ContentPage
    {
        // the home page of the app is a navigation page
        public NaviPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        // User clicks button to go to the FactsPage 
        async void FactsPageClick(object sender, System.EventArgs e)
        {                       
            await Navigation.PushAsync(new FactsPage());
        }

        // User clicks button to go to the LakePage  
        async void LakePageClick(object sender, System.EventArgs e)
        {                    
           await Navigation.PushAsync(new LakePage());
        }

        // User clicks button to go to the FishPage
        async void FishPageClick(object sender, System.EventArgs e)
        {           
            await Navigation.PushAsync(new FishPage());
        }

        // Called on home page being navigated to
        private void Page_Appearing(object sender, EventArgs e)
        {
            DisplayAlert("Well Hello There!", "Home Page is Appearing!", "OK");
        }

        // Called on home page being navigated from
        private void Page_Disappearing(object sender, EventArgs e)
        {
            DisplayAlert("Come Back Soon!", "Home Page is Disappearing!", "OK");
        }    
        
    }
}
