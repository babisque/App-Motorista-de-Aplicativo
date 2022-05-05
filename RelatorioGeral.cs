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
    public partial class RelatorioGeral : Form
    {
        List<Motorista> motoristas;
        public RelatorioGeral(List<Motorista> motoristas)
        {
            InitializeComponent();
            this.motoristas = motoristas;
        }

        private void RelatorioGeral_Load(object sender, EventArgs e)
        {
            lblMot01.Text = motoristas[0].ToString();
            lblMot02.Text = motoristas[1].ToString();
            lblMot03.Text = motoristas[2].ToString();
            lblMot04.Text = motoristas[3].ToString();
        }
    }
}
