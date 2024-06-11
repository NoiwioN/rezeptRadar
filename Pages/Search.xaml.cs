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
}