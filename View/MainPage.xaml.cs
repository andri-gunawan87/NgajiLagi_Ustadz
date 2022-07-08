namespace NgajiLagi_Ustadz;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
    }


    private void Login_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("OnBoarding1");
    }
}

