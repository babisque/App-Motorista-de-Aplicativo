using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMotorista
{
    public class Motorista
    {
        public string Nome { get; set; }
        public bool StatusOn { get; set; }
        public bool StatusViagem { get; set; }
        public decimal ValorTotal { get; set; }
        public int Viagens { get; set; }

        public Motorista(string nome)
        {
            Nome = nome;
            StatusOn = false;
            StatusViagem = false;
            ValorTotal = 0;
            Viagens = 0;
        }

        public void FinalizarViagem(decimal valor)
        {
            Viagens++;
            ValorTotal += valor;
        }

        public override string ToString() => $"Motorista: {Nome} fez {Viagens} viagens, ganhou o total de R$ {ValorTotal}";
    }
}
