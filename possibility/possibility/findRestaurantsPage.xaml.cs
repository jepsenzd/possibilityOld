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
                restaurantName = "Tea n Bowl Asian Food and Bubble Tea",
                Location = "211 W McMillan St",
                ImageUrl = "mcdonalds.jpg"
            });
            restaurants.Add(new restaurant
            {
                restaurantName = "Burger King",
                Location = "2701 Bearcat Way",
                ImageUrl = "mcdonalds.jpg"
            });
            restaurants.Add(new restaurant
            {
                restaurantName = "Raising Cane's Chicken Fingers",
                Location = "237 Calhoun St",
                ImageUrl = "mcdonalds.jpg"
            });
            restaurants.Add(new restaurant
            {
                restaurantName = "Taco Bell",
                Location = "2701 Bearcat Way",
                ImageUrl = "mcdonalds.jpg"
            });
            restaurants.Add(new restaurant
            {
                restaurantName = "Fortune Noodle House",
                Location = "349 Calhoun St #1332",
                ImageUrl = "mcdonalds.jpg"
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