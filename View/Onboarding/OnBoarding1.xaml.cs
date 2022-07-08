namespace NgajiLagi_Ustadz.View;

public partial class OnBoarding1 : ContentPage
{
	public OnBoarding1()
	{
		InitializeComponent();
	}

    private void Next_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("OnBoarding2");
    }
}