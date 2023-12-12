namespace second_app.Views;

public partial class LoginPage : ContentPage
{

	public void BtnAlteraPage(object sender, EventArgs e )
	{
		Navigation.PushAsync(new HomePage());
	}
	public LoginPage()
	{
		InitializeComponent();
	}
}