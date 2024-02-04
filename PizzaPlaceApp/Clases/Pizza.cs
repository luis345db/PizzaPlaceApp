namespace PizzaPlaceApp.Clases
{
    public class Pizza
    {

        public int Id { get; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Picante Picantez { get; set; }
        public Pizza(int id, string nombre, decimal precio,
        Picante picantes)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Picantez = picantes;
        }

    }
}

