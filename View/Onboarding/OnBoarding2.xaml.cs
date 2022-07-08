namespace NgajiLagi_Ustadz.View;

public partial class OnBoarding2 : ContentPage
{
	public OnBoarding2()
	{
        InitializeComponent();
	}
    private void Next_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("OnBoarding3");
    }

    private void Previous_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}