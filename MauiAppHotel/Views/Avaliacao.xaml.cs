namespace MauiAppHotel.Views;

public partial class Avaliacao : ContentPage
{
	public Avaliacao()
	{
		InitializeComponent();
	}

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new ContratacaoHospedagem());
    }
}