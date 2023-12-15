using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.ApplicationModel.Communication;
using second_app.Model;
using second_app.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace second_app.ViewModel
{
    public partial class LivroViewModel: ObservableObject
    {
        [ObservableProperty]
        private List<Livro> _livros;

        [ObservableProperty]
        private Livro _livro;

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand DisplayCommand { get; set; }


        public LivroViewModel(ILivroService repository)
        {
            _livro = new Livro();

            AddCommand = new Command(async () =>
            {
                await repository.InitializeAsync();
                await repository.AddLivro(_livro);
                Console.Write("erro adicionando ");
                await Refresh(repository);
                
            });

            UpdateCommand = new Command(async () =>
            {
                await repository.InitializeAsync();
                await repository.UpdateLivro(_livro);
                await Refresh(repository);
            });


            DisplayCommand = new Command(async () =>
            {
                await repository.InitializeAsync();
                await Refresh(repository);
            });
        }
        private async Task Refresh(ILivroService service)
        {
            Livros = await service.GetLivros();
        }
    }
    
}
