using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMotorista
{
    public partial class Detalhes : Form
    {
        List<Motorista> motoristas;

        public Detalhes(List<Motorista> motoristas)
        {
            InitializeComponent();
            this.motoristas = motoristas;
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {
            foreach (Motorista motorista in motoristas)
            {
                cbxMotoristas.Items.Add(motorista.Nome);
            }
        }

        private void cbxMotoristas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motorista motorista = motoristas[cbxMotoristas.SelectedIndex];
            lblValor.Text = motorista.Viagens.ToString();
            lblValorTotal.Text = $"R$ {motorista.ValorTotal}";
        }
    }
}
