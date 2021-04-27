using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_simulacion
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            clearPanel();
            Punto1 pantActual = new Punto1() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearPanel();
            Punto22 pantActual = new Punto22() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearPanel();
            Punto3 pantActual = new Punto3() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void clearPanel()
        {
            for (int i = panelContainer.Controls.Count - 1; i >= 0; i--)
            {
                panelContainer.Controls[i].Dispose();
            }
        }

    }
}
