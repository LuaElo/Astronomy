using PAM_Astronomy.Models;

namespace PAM_Astronomy.Views;
[QueryProperty(nameof(AstroName), "astroName")]

public partial class AstronomicalBodyView : ContentPage
{
    public AstronomicalBodyView()
    {
        InitializeComponent();
        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");


    }
    string astroName;

    public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;
            UpdateAstroBodyUI(astroName);
        }
    }
    void UpdateAstroBodyUI(string astroName)
    {
        AstronomicalBody body = FindAstroData(astroName);
        Title = body.Name;
        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }
    AstronomicalBody FindAstroData(string astronomicalBodyName)
    {

        return astronomicalBodyName switch
        {
            "comet" => SolarSystemData.HalleysComet,
            "earth" => SolarSystemData.Earth,
            "moon" => SolarSystemData.Moon,
            "sun" => SolarSystemData.Sun,
            _ => throw new ArgumentException()


        };

    }
    
}