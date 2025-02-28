namespace Parcial_MVC.Models
{
    public class Dado
    {
        private static Random random = new Random();
        public int NumeroGenerado { get; set; }
        public double Altura { get; set; }
        public double TiempoCaida { get; private set; }
    }
}
