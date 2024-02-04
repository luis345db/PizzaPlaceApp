
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace PizzaPlaceApp.Clases
{
    public class Estado
    {
        public Menu Menu { get; } = new Menu();
        public Carrito Carrito { get; } = new Carrito();
        public Interfaz UI { get; set; } = new Interfaz();

        public decimal PrecioTotal => Carrito.Ordenes.Sum(id => Menu.ObtenerPizza(id)!.Precio);
    }
}
