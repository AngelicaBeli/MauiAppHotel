namespace MauiAppHotel.Views;

public partial class NewPage1: ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

       private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage1());
    }

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new ContratacaoHospedagem());
    }
}