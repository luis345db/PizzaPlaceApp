namespace PizzaPlaceApp.Clases
{
    public class Pizza
    {

        public int Id { get; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Picante Picantes { get; set; }
        public Pizza(int id, string nombre, decimal precio,
        Picante picantes)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Picantes = picantes;
        }

    }
}

