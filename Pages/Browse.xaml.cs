using RezeptRadar.Models;

namespace RezeptRadar.Pages;

public partial class Browse : ContentPage
{
	public Browse()
	{
		
		InitializeComponent();

        var itemsDaily = new List<CollectionItem>
        {

            new CollectionItem{Title="Tofu Edamame Bowl 1", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 2", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 3", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 4", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 5", Description= "Add 11 Ingredients", Image= "bowl.jpg"}
        };
        carouselViewDaily.ItemsSource = itemsDaily;
        var itemsSpring = new List<CollectionItem>
        {

            new CollectionItem{Title="Tofu Edamame Bowl 1", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 2", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 3", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 4", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 5", Description= "Add 11 Ingredients", Image= "bowl.jpg"}
        };
        carouselViewSpring.ItemsSource = itemsSpring;
    }
    async void OnTappedRecepie (object sender, EventArgs e)
    {
        indicatorViewSpring.IndicatorColor = Color.FromRgb(255,255,255);
        await Shell.Current.GoToAsync("RezeptSeite");
    }

}