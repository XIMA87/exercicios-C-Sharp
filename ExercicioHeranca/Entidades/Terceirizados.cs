namespace ExercicioHeranca.Entidades
{
    public class Terceirizados : Empregados //Herança
    {
        public double DespesaAdicional { get; set; }

        public Terceirizados()
        {

        }

        public Terceirizados(string nome, int horas, double valorPorHora, double despesaAdicional) : base(nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }
        public override double Pagamento() //sobreposição
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}