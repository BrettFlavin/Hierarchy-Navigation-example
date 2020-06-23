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
    public partial class FishPage : ContentPage
    {
        // a class to represent a fish of Lake Malawi
        public class MalawiFish
        {
            public string Scientificname { get; set; }      // the fish's scientific name
            public string Nickname { get; set; }            // the fish's common nickname
            public string ImageURL { get; set; }            // the url of a fish pic
            public string details { get; set; }             // extra details about the pic
        }

        // collection to hold fish pics - our ItemSource for the FishPage ListView
        public ObservableCollection<MalawiFish> FishPics { get; private set; }

        // the page that displays a ListView of fish pics when the homepage button is clicked
        public FishPage()
        {
            InitializeComponent();
            FishPics = new ObservableCollection<MalawiFish>();

            // add the pics to list
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Aulonocara Maulana",
                Nickname = "Bi-Color 500",
                ImageURL = "bi_color.jpg",
                details = "This is a smaller sized cichlid that reaches only about 2 - 4 inches (9 -10 cm) in length and is collected along the west coast of Lake Malawi in the area of Chitimba Bay. The Maulana Bicolor Peacock is found in shallower waters at about 16 feet (5 m)."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Buccochromis Nototaenia",
                Nickname = "Stripeback Hap",
                ImageURL = "bucco_noto.jpg", 
                details = "The nototaenia is a mild tempered fish reaching a maximum size of over 14 inches. A predator hap, they are found throughout the lake and especially along the shoreline where there are sandy substrates teeming with juveniles of other species. The Buccochromis prey on these, often driving them into shallower water where they are more easily picked off."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Protomelas sp. Hertae",
                Nickname = "No Known Nickname",
                ImageURL = "hertae.jpg",
                details = "The Hertae hunts for invertebrates, insect larvae and nymphs in the substrate that it sucks out of small holes between the rocks It uses its enlargened lips to both block the holes and absorb the shock of impacting the substrate. Males defend their territories against all comers, and will build conical pits inside caves for spawning."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Aulonocara sp. Lwanda",
                Nickname = "Red Top Peacock",
                ImageURL = "lwanda.jpg", 
                details = "The Red Top Lwanda peacock hails from the intermediate zones of Hai Reef in Tanzania and from Chiwindi in Mozambique. In the wild, Aulonocara lwanda feeds on invertebrates found in the sand."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Aulonocara Stuartgranti (Mdoka)",
                Nickname = "Mdoka Flametail",
                ImageURL = "mdoka_flametail.jpg", 
                details = "This variant of the stuartgranti is found near Mdoka, Lake Malawi. Each Flametail, whether from Ngara or Mdoka, is unique in that no two seem to dispaly the same degree of red or orange. Sometimes it only extends half way up the body and sometimes it will reach as far as the collar."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Aulonocara Peacock hybrid",
                Nickname = "OB Peacock",
                ImageURL = "pink_ob.jpg",
                details = "The OB Peacock is not found in Lake Malawi but rather is a man-made cichlid species. It was engineered by crossing a male Aulonocara species with an OB female mbuna cichlid."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Protomelas Taeniolatus",
                Nickname = "Red Empress",
                ImageURL = "red_empress.jpg",
                details = "The red empress is endemic to Lake Malawi and occurs in sediment free, rocky habitats in relatively shallow waters. It mainly feeds on algae growing on the rock surfaces, but also on a variety of small invertebrates. Males can reach a size of up to 6 inches"
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Placidochromis sp. Phenochilus Tanzania",
                Nickname = "Star Sapphire",
                ImageURL = "star_sapphire.jpg",
                details = "One of the most interesting fish to watch mature, the star sapphire male's colors will change from all blue to having white and light blue spots all over it’s body. Within Lake Malawi there are two variants of this species - those from Mdoka are solid blue with white lips and those from Tanzania which are blue with these white and light blue spots."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Dimidiochromis Strigatus",
                Nickname = "Sunset Hap",
                ImageURL = "strigatus.jpg",
                details = "The strigatus is a predator hap found in Lake Malawi, Lake Malombe, and the upper and mid Shire River. It is normally found in shallower areas with a mixture of weedy and sandy habitats. It preys on small fishes such as utaka and larger invertebrates and can grow up to 12 inches long."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Aulonocara sp. Stuartgranti Maleri",
                Nickname = "Sunshine Peacock",
                ImageURL = "sunshine.jpg",
                details = "This cichlid is a member of a very small group of fish from Lake Malawi, Africa known as the Peacock Cichlids. The Peacock Cichlids are placed in the Aulonocara genus which contains only about 28 species, but with many subspecies. It is the brilliant colorations of blues, reds and yellows that give this group the well deserved name of Peacock."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Otopharynx Tetrastigma",
                Nickname = "No Known Nickname",
                ImageURL = "tetrastigma.jpg",
                details = "The tetrastigma prefers shallow, warm water and can grow to be up 6+ inches long. Males develop bright colors, including iridescent green on the upper body and bright yellow on the lower body. The fins have bright pink tips, and the rest of the body is blue. Females are less colorful and stay dull for survival purposes. They are grey and brown with three black spots around the fins, and grow to be slightly larger than males."
            });
            FishPics.Add(new MalawiFish
            {
                Scientificname = "Nimbochromis Venustus",
                Nickname = "Giraffe Cichlid",
                ImageURL = "venustus.jpg",
                details = "The venustus (meaning refined or elegant), is an ambush predator that will partially bury itself in the sand and hold very still for up to several minutes waiting for an unsuspecting small fish to swim by. Once its prey is within reach, it will quickly dart out of the sand to snatch it. Its blotches resemble the coat pattern of a giraffe, which has led to common name of Giraffe Cichlid "
            });

            BindingContext = this;
        }

        // initialize a new DetailPage when a fish item from the ListView is tapped
        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // get the item's url and details properties for the DetailPage constructor
            var thisPic = ((MalawiFish)e.Item);     
            string TheURL = thisPic.ImageURL;
            string TheDetails = thisPic.details;
            
            // navigate to a newly created DetailPage
            await Navigation.PushAsync(new DetailPage(TheURL, TheDetails));
        }
    }
}