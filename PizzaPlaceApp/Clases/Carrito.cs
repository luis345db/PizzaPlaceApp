namespace PizzaPlaceApp.Clases
{
    public class Carrito
    {
        public Clientes Cliente { get; set; } = new Clientes();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool Pago { get; set; }

        public void Agregar(int pizzaId) => Ordenes.Add(pizzaId);

        public void Remover(int pos) => Ordenes.RemoveAt(pos);
    }
}
