using ExercicioComposição.Entidades.Enums;

namespace ExercicioComposição.Entidades
{
    public class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; } //composição de objetos ! Associação entre Trabalhador e Departamento
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        public Trabalhador()
        {

        }
        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoverContrato(HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Receita(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (HoraContrato contrato in Contratos)
            {
              if (contrato.Data.Year == ano && contrato.Data.Month == mes)
              {
                  soma += contrato.ValorTotal();
              }
            }
            return soma;
        }
    }
}