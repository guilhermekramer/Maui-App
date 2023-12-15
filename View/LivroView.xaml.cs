using second_app.Service;
using second_app.ViewModel;

namespace second_app.View;

public partial class LivroView : ContentPage
{
	public LivroView(ILivroService service)
	{
		InitializeComponent();
		BindingContext = new LivroViewModel(service);
	}
}