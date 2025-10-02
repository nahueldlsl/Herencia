namespace Library
{
    // Usamos 'abstract' porque no queremos crear 'Usuarios' genéricos,
// solo Pasajeros o Conductores.
    public abstract class User
    {
        // Estos son los atributos que ambos, Pasajero y Conductor, compartirán.
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }

        // Un constructor para inicializar los datos compartidos.
        public User(string nombre, string apellido, string cedula)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
        }
    }
}