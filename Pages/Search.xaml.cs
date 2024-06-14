namespace RezeptRadar.Pages;

public partial class Search : ContentPage
{
	public Search()
	{
		InitializeComponent();
        int value = (int)Math.Round(timeSlider.Value / 5) * 5;
        timeSliderValue.Text = value.ToString() + " min";
    }

    private void search_Completed(object sender, EventArgs e)
    {

    }

    private void timeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int value = (int) Math.Round(timeSlider.Value/5)*5 ;
        timeSliderValue.Text = value.ToString()+ " min" ;
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        var mySwitch = sender as Switch;
        if (mySwitch != null)
        {
            if(mySwitch.IsToggled)
            {
                mySwitch.OnColor= (Color)Application.Current.Resources["success"];
                mySwitch.ThumbColor= (Color)Application.Current.Resources["success"];
            }
            else
            {
                mySwitch.OnColor = (Color)Application.Current.Resources["inactiveElement"];
                mySwitch.ThumbColor = (Color)Application.Current.Resources["inactiveElement"];

            }
        }

    }
}