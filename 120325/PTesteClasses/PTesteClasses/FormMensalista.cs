using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasses
{
    public partial class FormMensalista : Form
    {
        public FormMensalista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);

            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado + "\n" + 
                "Matricula=" + objMensalista.Matricula + "\n" + 
                "Tempo Trabalho:" + objMensalista.TempoTrabalho() + "\n" + 
                "Salário Final =" + objMensalista.SalarioBruto().ToString("N2"));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
