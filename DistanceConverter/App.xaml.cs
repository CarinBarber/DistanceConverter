using DistanceConverter.Views;

namespace DistanceConverter;

public partial class App : Application
{
    private TabbedPage _tabbedPage;
    
    public App()
    {
        InitializeComponent();

        _tabbedPage = new TabbedPage();
        _tabbedPage.Children.Add(new NavigationPage(new DistancePage()){ Title = "Distance", IconImageSource = "distance_tab" });
        _tabbedPage.Children.Add(new NavigationPage(new WeightPage()){ Title = "Weight", IconImageSource = "weight_tab"});

        
        //MainPage = new NavigationPage(new DistancePage());
        MainPage = _tabbedPage;
    }
    
}