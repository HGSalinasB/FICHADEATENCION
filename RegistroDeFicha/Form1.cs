using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeFicha
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //capturar datos 
            string paciente = txtPaciente.Text;
            string ci = txtCI.Text;
            string edad = txtEdad.Text;
            string genero = cbGenero.Text;
            string espe = cbEspe.Text;
            string medico = cbMedico.Text;

            //impresion de plantilla
            ListViewItem fila = new ListViewItem(paciente);
            fila.SubItems.Add(ci);
            fila.SubItems.Add(genero);
            fila.SubItems.Add(edad);
            fila.SubItems.Add(espe);
            fila.SubItems.Add(medico);
            fila.SubItems.Add(DateTime.Now.ToString("d"));
            lvPacientes.Items.Add(fila);

            //limpiar texbox
            txtPaciente.Clear();
            txtCI.Clear();
            txtEdad.Clear();
            cbEspe.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            cbMedico.SelectedIndex = -1;
            txtPaciente.Focus();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
