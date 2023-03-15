using IoT_Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IoT_Xamarin.Models
{

    //I was hoping this would display all the strings as separate items but I can't seem to get it right 
    
    public class Home_Page : HomePage
    {
        string[] assets = { "Car", "Truck", "Generator", "Fridge" };
        AssetListView.ItemsSource = assets;
    }
}
