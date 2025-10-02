namespace Library
{
    public abstract class Driver : User
    {
        public string Calificacion { get; set; }
        public string bio { get; set; }
        public string Vehiculo { get; set; }
        
        public Driver(string nombre, string apellido, int cedula, int Calificacion, string Vehiculo, string bio): base(nombre, apellido, cedula)
        {
           this.Calificacion = Calificacion;
           this.bio = bio;
           this.Vehiculo = Vehiculo;
        }
    }
}