using ExercicioHeranca2.Entidades.Enums;

namespace ExercicioHeranca2.Entidades
{
    public class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cores cores) : base(cores)
        {
            Raio = raio;
        }

        public override double Area() //sobrescrita/implementação do método abstrato
        {
            return Math.PI * Raio * Raio;
        }
    }
}