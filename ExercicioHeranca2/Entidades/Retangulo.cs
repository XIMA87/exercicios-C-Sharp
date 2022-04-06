using ExercicioHeranca2.Entidades.Enums;

namespace ExercicioHeranca2.Entidades
{
    public class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cores cores) : base(cores)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area() //sobrescrita/implementação do método abstrato
        {
            return Largura * Altura;
        }
    }
}