using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen_Taller
{
    public partial class titulo : Form
    {
        public titulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void v_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void saldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void titulo_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            direccion.Text = "";
            masculino.Checked = true;
            personales.Enabled = false;

            cantidad.Text = "";
            consulta.Checked = true;
            bancarios.Enabled = false;
        }

        private void edicion_Click(object sender, EventArgs e)
        {
            personales.Enabled = true;
            bancarios.Enabled = true;
            saldo.Enabled = false;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            direccion.Text = "";
            masculino.Checked = true;

            cantidad.Text = "";
            consulta.Checked = true;

        }

        private void ejecutar_Click(object sender, EventArgs e)
        {
            String[] lineas = { nombre.Text, apellido.Text, nacimiento.CustomFormat, sexo.Text, cantidad.Text, ejecucion.CustomFormat, operacion.Text };

            //System.IO.File.WriteAllLines(@"C:\RutaArchivos\EscribeLineas.txt", lineas);

            string path = @"c:\temp\datos.txt";
        }
    }
}
