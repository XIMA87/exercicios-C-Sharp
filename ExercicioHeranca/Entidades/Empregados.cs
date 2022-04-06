namespace ExercicioHeranca.Entidades
{
    public class Empregados
    {
        public string Nome { get; set; }
        public int Horas { get; set; }

        public double ValorPorHora { get; set; }

        public Empregados()
        {

        }

        public Empregados(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento() //virtual permite uma posterior sobreposição
        {
            return Horas * ValorPorHora;
        }
    }
}