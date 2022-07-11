namespace NgajiLagi_Ustadz.View.Menu;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
		bool login = true;
		if (login)
        {
			login = false;
            Shell.Current.GoToAsync("OnBoarding1");
        }
	}
}