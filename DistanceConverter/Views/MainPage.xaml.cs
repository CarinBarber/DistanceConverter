using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class MainPage : ContentPage
{
    // private TabbedPage _tabbedPage;
    public MainPage()
    {
        InitializeComponent();

        /*
        _tabbedPage = new TabbedPage();
        
        _tabbedPage.Children.Add(new NavigationPage(new DistancePage { Title = "Distance", IconImageSource = "distance_tab" }));
        _tabbedPage.Children.Add(new NavigationPage(new WeightPage { Title = "Weight", IconImageSource = "weight_tab"}));
        */

    }
    /*
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Content = _tabbedPage;
    }
    */
}