namespace NgajiLagi_Ustadz.View;

public partial class OnBoarding3 : ContentPage
{
	public OnBoarding3()
	{
		InitializeComponent();
	}
    private void Next_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("MainPage");
    }

    private void Previous_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}