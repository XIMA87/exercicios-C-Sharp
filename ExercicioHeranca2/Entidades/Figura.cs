using ExercicioHeranca2.Entidades.Enums;

namespace ExercicioHeranca2.Entidades
{
    public abstract class Figura //classe abstrata
    {
        public Cores Cores { get; set; }

        public Figura(Cores cores)
        {
            Cores = cores;
        }

        public abstract double Area(); //método abstrato
    }
}