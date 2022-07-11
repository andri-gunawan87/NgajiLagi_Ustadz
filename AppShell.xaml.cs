using NgajiLagi_Ustadz.View;
using NgajiLagi_Ustadz.View.Menu;
using NgajiLagi_Ustadz;

namespace NgajiLagi_Ustadz;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(OnBoarding1), typeof(OnBoarding1));
        Routing.RegisterRoute(nameof(OnBoarding2), typeof(OnBoarding2));
        Routing.RegisterRoute(nameof(OnBoarding3), typeof(OnBoarding3));
        Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));
    }
}
