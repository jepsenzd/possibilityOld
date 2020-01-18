using possibility.Views.Forms;
using possibility.Views.Profile;
using possibility.Views.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace possibility
{
    public class MasterViewModel
    {
        public ICommand NavigationCommand
        {
            get
            {
                return new Command((value) =>
                {
                    var mdp = (Application.Current.MainPage as MasterDetailPage);
                    var navPage = mdp.Detail as NavigationPage;
                    //test

                    // Hide the Master page
                    mdp.IsPresented = false;

                    switch (value)
                    {
                        case "1":
                            navPage.PushAsync(new dashboardPage());
                            break;
                        case "2":
                            navPage.PushAsync(new findRestaurantsPage());
                            break;
                        case "3":
                            navPage.PushAsync(new ProfilePage());
                            break;
                        case "4":
                            navPage.PushAsync(new SettingPage());
                            break;
                        case "5":
                            navPage.PushAsync(new SimpleLoginPage());
                            break;
                    }

                });
            }
        }
    }
}
