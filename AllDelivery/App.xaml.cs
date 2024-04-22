using AllDelivery.Pages;

namespace AllDelivery;

public partial class App : Application
{
     public App()
     {
          InitializeComponent();
          MainPage = new NavigationPage(new HomePage());
     }
}
