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
    public partial class FactsPage : ContentPage
    {
        // class to represent a fact about Lake Malawi
        public class MalawiFact
        {
            public string Fact { get; set; }                            // a string to hold a single fact
            public override string ToString() { return Fact; }          // override ToString() method to return the Fact property
        }

        public ObservableCollection<MalawiFact> Facts { get; set; }    // collection to hold all of the fun facts
        static Random rnd = new Random();                              // Random class used to get a random fact from list

        // the page that displays facts about Lake Malawi when the button is clicked from the home page
        public FactsPage()
        {
            InitializeComponent();
            Facts = new ObservableCollection<MalawiFact>();

            // add the facts to list
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is an African Great Rift Lake, located between Malawi, Mozambique, and Tanzania!"});
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is the 9th largest lake in the world and the 3rd largest lake in Africa!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is about 360 miles long and 47 miles wide at its widest point!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is the 5th largest lake in the world by volume with 8,400 cubic kilometers!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi has about 930 miles of shoreline!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi has 2 inhibited islands - Likoma Island and Chizumulu Island!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi National Park is located at the southern end of the lake, and was designated a UNESCO World Heritage Site in 1984!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is home to more species of fish then any other body of freshwater in the world, including about 1000 different species of cichlids!" });
            Facts.Add(new MalawiFact { Fact = "The mean annual temp around Lake Malawi is 72 degrees, and average rainfall is 30 inches!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is noted for being the site of evolutionary radiations among several groups of animals, most notably cichlid fish!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi was discovered by Dr. David Livingstone around 1859, who named it the 'Lake of Stars' because of its stunning sparkles under the rising sun!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi was formed by the opening of the East African Rift, where the African tectonic plate is splitting into two pieces!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi has a total surface area of about 29,600 square kilometers!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is also called Nyasa meaning “lake”, and is fed by 14 perennial rivers. The largest of these is the Ruhuhu and its only outlet is the Shire River, a tributary of the Zambezi river!" });
            Facts.Add(new MalawiFact { Fact = "There are more species of fish in Lake Malawi then in all of the freshwater bodies of Europe combined!" });
            Facts.Add(new MalawiFact { Fact = "Malawi is known as 'The Warm Heart of Africa' because of the friendly, courteous, and hospitable locals. Forbes magazine lists the people of Malawi as the happiest people in Africa!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is meromictic, which means that its layers of water do not mix. There is permanent stratification in the lake, which is maintained by chemical and thermal gradients!" });
            Facts.Add(new MalawiFact { Fact = "Age estimates for Lake Malawi vary greatly, from 40,000 years old to 1-2 million years old!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi was the scene of a naval battle on August 16th, 1914 when British gunboat SS Gwendolen disabled the German Empire’s Hermann von Wissmann with a single cannon shot from about 1.8 kilometers. It was hailed as the British Empire’s first naval victory in World War I!" });
            Facts.Add(new MalawiFact { Fact = "Some of the most important wildlife found in and around Lake Malawi include hippopotamus, Nile crocodiles, monkeys, and fish eagles.Important bird species include herons, kingfishers, and cormorants. Other animals from around the lake include baboons, antelopes, and hyrax!" });
            Facts.Add(new MalawiFact { Fact = "The cichlids of Lake Malawi are divided into 2 major groups - the haplochromines and the tilapiines!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi is extremely important for the population living around it. The lake is an important provider of drinking water, irrigation and hydroelectricity!" });
            Facts.Add(new MalawiFact { Fact = "Lake Malawi sits at 1500 feet above sea level, and plunges to 2300 feet below sea level!" });
        }

        // event triggered when user clicks fact button
        private void FactButton_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(Facts.Count);          // generate random int based on size of Facts collection
            FactsLabel.Text = Facts[r].ToString();  // ToString() overriden in MalawiFact class to return Fact property here
        }

    }
}