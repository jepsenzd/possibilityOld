using possibility.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace possibility
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList
        {
            get;
            set;
        }
        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MasterPageItem()
            {
                Title = "Dashboard",
                Icon = "dashboard.png",
                TargetType = typeof(dashboardPage)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Find Restaurants",
                Icon = "restaurant.png",
                TargetType = typeof(findRestaurantsPage)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "My Profile",
                Icon = "profile.png",
                TargetType = typeof(profilePage)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Settings",
                Icon = "settings.png",
                TargetType = typeof(settingsPage)
            });
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(dashboardPage)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}