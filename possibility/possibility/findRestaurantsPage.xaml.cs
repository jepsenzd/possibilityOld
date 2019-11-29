using possibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace possibility
{
    
    public partial class findRestaurantsPage : ContentPage
    {
        public IList<restaurant> restaurants { get; private set; }
        public findRestaurantsPage()
        {
            InitializeComponent();

            restaurants = new List<restaurant>();
            restaurants.Add(new restaurant
            {
                restaurantName = "Mc'Donalds",
                Location = "123 America Ave",
                ImageUrl = "mcdonalds.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Capuchin Monkey",
                Location = "Central & South America",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Blue Monkey",
                Location = "Central and East Africa",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Squirrel Monkey",
                Location = "Central & South America",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Golden Lion Tamarin",
                Location = "Brazil",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Howler Monkey",
                Location = "South America",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Japanese Macaque",
                Location = "Japan",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Proboscis Monkey",
                Location = "Borneo",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Red-shanked Douc",
                Location = "Vietnam, Laos",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Gray-shanked Douc",
                Location = "Vietnam",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Golden Snub-nosed Monkey",
                Location = "China",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Black Snub-nosed Monkey",
                Location = "China",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Tonkin Snub-nosed Monkey",
                Location = "Vietnam",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Thomas's Langur",
                Location = "Indonesia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Purple-faced Langur",
                Location = "Sri Lanka",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
            });

            restaurants.Add(new restaurant
            {
                restaurantName = "Gelada",
                Location = "Ethiopia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
            });

            BindingContext = this;
        }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            restaurant selectedItem = e.SelectedItem as restaurant;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            restaurant tappedItem = e.Item as restaurant;
        }
    }
      
}