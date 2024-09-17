namespace PAM_Astronomy.Views;

public partial class AstronomicalBodiesView : ContentPage
{
	public AstronomicalBodiesView()
	{
		InitializeComponent();
        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");

    }
}