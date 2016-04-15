using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Compi2_Proyecto2ClienteCS
{
    public partial class Form1 : Form
    {

        int contador_pestañas = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador_pestañas++;
            string titulo = "Lineas de Comando " + contador_pestañas.ToString();
            TabPage paginaNueva = new TabPage(titulo);
            TextBox texto = new TextBox();
            texto.Dock = DockStyle.Fill;
            texto.Multiline = true;
            texto.ScrollBars = ScrollBars.Vertical;
            texto.BackColor = Color.Gray;
            texto.Font = new Font("Microsoft Sans Serif", 11);
            texto.ForeColor = Color.White;
            paginaNueva.Controls.Add(texto);
            tabControlComandos.TabPages.Add(paginaNueva);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControlComandos.TabPages.Remove(tabControlComandos.SelectedTab);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}