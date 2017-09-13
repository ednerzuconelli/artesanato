using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace artesanato
{
    public class MenuPage : CustomTabbedPage
    {
        public MenuPage()
        {
            Title = "Menu";
            Children.Add(new ClientesPage()
            {
                Title = "Pedido",
                Icon = ""
            });
            Children.Add(new MapasPage()
            {
                Title = "Mapa",
                Icon = ""
            });
        }
    }
}