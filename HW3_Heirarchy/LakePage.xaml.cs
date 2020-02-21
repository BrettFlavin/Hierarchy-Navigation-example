using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW3_Heirarchy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LakePage : ContentPage
    {
        // class to represent a picture of Lake Malawi
        public class MalawiPic
        {
            public string Title { get; set; }       // title of the pic
            public string Subtitle { get; set; }    // a descriptive subtitle
            public string ImageURL { get; set; }    // the url of a lake pic
            public string details { get; set; }     // extra details about the pic
        }

        // collection to hold lake pics - our ItemSource for the LakePage ListView
        public ObservableCollection<MalawiPic> LakePics { get; private set; }

        // the page that displays a ListView of lake pics when the homepage button is clicked
        public LakePage()
        {
            InitializeComponent();
            LakePics = new ObservableCollection<MalawiPic>();

            // add the pics to list
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 1",
                Subtitle = "Lake Malawi from Space",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Lake_Malawi%2C_Great_Rift_Valley_ESA205475.jpg",
                details = "Satellite image of Lake Malawi taken from space by the European Space Agency"
            });
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 2",
                Subtitle = "Malawi Sunset",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Lake_Malawi_%282490513524%29.jpg",
                details = "Beautiful sunset photo taken at Lake Malawi"
            });
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 3",
                Subtitle = "Malawi Shores",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/d/dc/Lake_Malawi_270406.jpg",
                details = "Rocky shores of Lake Malawi"
            });
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 4",
                Subtitle = "The Road to Chiweta",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/1/19/Chiweta%2C_Lake_Malawi%2C_Rumphi.jpg",
                details = "The road driving down to Chiweta, northern Lake Malawi"
            });
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 5",
                Subtitle = "View from Likoma Island",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/4/41/Lake_Malawi_from_Likoma.jpg",
                details = "Photo taken from Likoma Island, the larger of two inhibited islands of Lake Malawi"
            });
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 6",
                Subtitle = "Malawi Island",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/8/83/Lake_Malawi%2C_shore_island.jpg",
                details = "View from the shores of Malawi with a distant island in the background"
            });
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 7",
                Subtitle = "Otter Point",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/8/80/Otter_Point%2C_Cape_Maclear_%28Malawi%29.jpg",
                details = "Otter Point is a small rocky peninsula that's popular with snorkellers and even more so with fish."
            });
            LakePics.Add(new MalawiPic
            {
                Title = "Malawi Pic 8",
                Subtitle = "Likoma Island",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/5/53/Likoma_Island%2C_Lake_Malawi_0525.jpg",
                details = "Likoma Island is densely populated, with about 10,500 inhabitants dispersed in a dozen settlements"
            });

            BindingContext = this;
        }

        // initialize a new DetailPage when a lake item from the ListView is tapped
        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)        
        {
            // get the item's url and details properties for the DetailPage constructor
            var thisPic = ((MalawiPic)e.Item);
            string TheURL = thisPic.ImageURL;           
            string TheDetails = thisPic.details;

            // navigate to a newly created DetailPage
            await Navigation.PushAsync(new DetailPage(TheURL, TheDetails));            
        }
    }
}