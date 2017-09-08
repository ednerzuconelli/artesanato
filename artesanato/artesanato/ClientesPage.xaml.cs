using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: Dependency(typeof(Arte.AcessoBD))]
namespace Arte
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientesPage : ContentPage
    {
        public ClientesPage()
        {
            InitializeComponent();
            using (var dados = new AcessoBD())

            {
                this.ListaCliente.ItemsSource = dados.GetClientes();
            }
        }
        protected void SalvarClicked(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nome = this.NomeCliente.Text,
                Email = this.EmailCliente.Text,
                Fone = this.FoneCliente.Text,
            };

            using (var dados = new AcessoBD())
            {
                dados.InserirCliente(cliente);
                this.ListaCliente.ItemsSource = dados.GetClientes();
            }
        }
    }
}