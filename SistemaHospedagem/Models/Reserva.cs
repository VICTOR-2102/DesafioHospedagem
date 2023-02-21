using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(this.Suite.Capacidade >= hospedes.Count)
            {
                this.Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes está excedendo a Capacidade da Suíte");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return this.Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        {
            decimal valorCalculado;
            if (this.DiasReservados >= 10)
            {
                var valor = this.Suite.ValorDiaria * this.DiasReservados;
                
                var desconto = 0.1 * Convert.ToDouble(valor);
                valorCalculado = valor - Convert.ToDecimal(desconto);
            }
            else
            {
                valorCalculado = this.Suite.ValorDiaria * this.DiasReservados;
            }
            return valorCalculado;
        }
    }
}
