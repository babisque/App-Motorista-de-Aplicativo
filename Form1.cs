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
    public partial class AppDeMotorista : Form
    {
        List<Motorista> repositorioMotorista = RepositorioMotorista.InicializadorMotorista();

        public AppDeMotorista()
        {
            InitializeComponent();
        }

        private void AppDeMotorista_Load(object sender, EventArgs e)
        {
            lblMot01.Text = repositorioMotorista[0].Nome;
            lblMot02.Text = repositorioMotorista[1].Nome;
            lblMot03.Text = repositorioMotorista[2].Nome;
            lblMot04.Text = repositorioMotorista[3].Nome;

            cbOn01.Checked = repositorioMotorista[0].StatusOn;
            cbOn02.Checked = repositorioMotorista[1].StatusOn;
            cbOn03.Checked = repositorioMotorista[2].StatusOn;
            cbOn04.Checked = repositorioMotorista[3].StatusOn;

            cbViajando01.Enabled = cbOn01.Checked;
            cbViajando02.Enabled = cbOn02.Checked;
            cbViajando03.Enabled = cbOn03.Checked;
            cbViajando04.Enabled = cbOn04.Checked;

            txtPreco01.Enabled = cbViajando01.Enabled;
            txtPreco02.Enabled = cbViajando02.Enabled;
            txtPreco03.Enabled = cbViajando03.Enabled;
            txtPreco04.Enabled = cbViajando04.Enabled;

            btnFinalizar01.Enabled = cbViajando01.Enabled;
            btnFinalizar02.Enabled = cbViajando02.Enabled;
            btnFinalizar03.Enabled = cbViajando03.Enabled;
            btnFinalizar04.Enabled = cbViajando04.Enabled;

        }

        private void cbxOn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbOn01_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOn01.Checked)
            {
                cbViajando01.Enabled = true;
                repositorioMotorista[0].StatusOn = true;
            } else
            {
                cbViajando01.Enabled = false;
                repositorioMotorista[0].StatusOn = false;
            }
        }

        private void cbOn02_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOn02.Checked)
            {
                cbViajando02.Enabled = true;
                repositorioMotorista[1].StatusOn = true;
            } else
            {
                cbViajando02.Enabled = false;
                repositorioMotorista[1].StatusOn = false;
            }
        }

        private void cbOn03_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOn03.Checked)
            {
                cbViajando03.Enabled = true;
                repositorioMotorista[2].StatusOn = true;
            } else
            {
                cbViajando03.Enabled = false;
                repositorioMotorista[2].StatusOn = false;
            }
        }

        private void cbOn04_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOn04.Checked)
            {
                cbViajando04.Enabled = true;
                repositorioMotorista[3].StatusOn = true;
            } else
            {
                cbViajando04.Enabled = false;
                repositorioMotorista[3].StatusOn = false;
            }
        }

        private void cbViajando01_CheckedChanged(object sender, EventArgs e)
        {
            txtPreco01.Enabled = true;
            btnFinalizar01.Enabled = true;
            repositorioMotorista[0].StatusViagem = true;
        }

        private void cbViajando02_CheckedChanged(object sender, EventArgs e)
        {
            txtPreco02.Enabled = true;
            btnFinalizar02.Enabled = true;
            repositorioMotorista[1].StatusViagem = true;
        }

        private void cbViajando03_CheckedChanged(object sender, EventArgs e)
        {
            txtPreco03.Enabled = true;
            btnFinalizar03.Enabled = true;
            repositorioMotorista[2].StatusViagem = true;
        }

        private void cbViajando04_CheckedChanged(object sender, EventArgs e)
        {
            txtPreco04.Enabled = true;
            btnFinalizar04.Enabled = true;
            repositorioMotorista[3].StatusViagem = true;
        }

        private void btnFinalizar01_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(txtPreco01.Text);
            repositorioMotorista[0].FinalizarViagem(valor);
            cbViajando01.Checked = false;
            txtPreco01.Clear();
            txtPreco01.Enabled = false;
            btnFinalizar01.Enabled = false;
        }

        private void btnFinalizar02_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(txtPreco02.Text);
            repositorioMotorista[1].FinalizarViagem(valor);
            cbViajando02.Checked = false;
            txtPreco02.Clear();
            txtPreco02.Enabled = false;
            btnFinalizar02.Enabled = false;
        }

        private void btnFinalizar03_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(txtPreco03.Text);
            repositorioMotorista[2].FinalizarViagem(valor);
            cbViajando03.Checked = false;
            txtPreco03.Clear();
            txtPreco03.Enabled = false;
            btnFinalizar03.Enabled = false;
        }

        private void btnFinalizar04_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(txtPreco04.Text);
            repositorioMotorista[3].FinalizarViagem(valor);
            cbViajando04.Checked = false;
            txtPreco04.Clear();
            txtPreco04.Enabled = false;
            btnFinalizar04.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detalhes detalhes = new Detalhes(repositorioMotorista);
            detalhes.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioGeral relatorio = new RelatorioGeral(repositorioMotorista);
            relatorio.ShowDialog();
        }
    }
}
