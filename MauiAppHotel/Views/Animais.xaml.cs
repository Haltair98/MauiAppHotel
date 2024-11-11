namespace MauiAppHotel.Views;

public partial class NewPage1 : ContentPage
{
	App PropriedadeAnima;
	public NewPage1()
	{
		InitializeComponent();

		PropriedadeAnima = (App)Application.Current;

        pck_animal.ItemsSource = PropriedadeAnima.lista_animais;
	}

    private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PopAsync();

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

}