using second_app.Service;
using second_app.View;


namespace second_app
{
    public partial class App : Application
    {
        public App(ILivroService livroService)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LivroView(livroService));
        }
    }
}
