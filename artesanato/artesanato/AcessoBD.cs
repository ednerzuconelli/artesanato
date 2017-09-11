using System;
using SQLite.Net;
using System.Linq;
using System.IO;
using Xamarin.Forms;
using System.Collections.Generic;


namespace artesanato
{
    public class AcessoBD : IDisposable
    {
        private SQLiteConnection conexaoSQLite;

        
            public AcessoBD()
            {
                var config = DependencyService.Get<IConfig>();
                conexaoSQLite = new SQLiteConnection(config.Plataforma, Path.Combine(config.DiretorioSQLite, "Artes.db3"));
                conexaoSQLite.CreateTable<Cliente>();
                conexaoSQLite.CreateTable<Pedido>();
            }

            public void InserirCliente(Cliente cliente)
            {
                conexaoSQLite.Insert(cliente);
            }

            public void AtualizarCliente(Cliente cliente)
            {
                conexaoSQLite.Update(cliente);
            }

            public void DeletarCliente(Cliente cliente)
            {
                conexaoSQLite.Delete(cliente);
            }

            public Cliente GetCliente(int codigo)
            {
                return conexaoSQLite.Table<Cliente>().FirstOrDefault(c => c.Id == codigo);
            }

            public List<Cliente> GetClientes()
            {
                return conexaoSQLite.Table<Cliente>().OrderBy(c => c.Nome).ToList();
            }
    
           
    public void Dispose()
        {
            conexaoSQLite.Dispose();
        }
    }
}
