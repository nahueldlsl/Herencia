namespace Library
{
    // Heredamos de User, como bien dijiste.
    public class Pasajero : User
    {
        // 1. Añadimos la propiedad específica de Pasajero.
        public int Calificacion { get; set; }

        // 2. Creamos el constructor.
        // Fíjate que pide TODOS los datos: los de User y los de Pasajero.
        public Pasajero(string nombre, string apellido, string cedula, int calificacion)
            : base(nombre, apellido, cedula) // 3. ¡Esta es la parte clave!
        {
            // 4. Finalmente, asignamos el valor a la propiedad de Pasajero.
            this.Calificacion = calificacion;
        }
    }
}