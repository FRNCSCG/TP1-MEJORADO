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
    public partial class Punto3 : Form
    {
        public Punto3()
        {
            InitializeComponent();
        }

        private void Punto3_Load(object sender, EventArgs e)
        {

        }

        private void btonGenerar_Click(object sender, EventArgs e)
        {
            // variables

            double acumulador = 0;
            int Xo = Convert.ToInt32( txtXo.Text);
            double g = Convert.ToDouble(txtg.Text);
            Double k = Convert.ToDouble(txtK.Text);
            int Ce= Convert.ToInt32(txtC.Text);
            double a = 0;
            double m = 0;
            double Xi = 0;

            if (txtM.Text.Equals(""))
            {
                m = Math.Pow(2.0,g);
                MessageBox.Show("anda"+ m);
            }
            else
            {
                m = Convert.ToInt32(txtM.Text);
            }

            if (txtA.Text.Equals(""))
            {
                a = 1 + 4 * k;
            }
            else
            {
                a = Convert.ToInt32(txtA.Text);
            }

            // Random con metodo congruencial
            double Colum = 0;
            for (int i = 0; i < Convert.ToInt32(TxtTamañoMuestra.Text); i++)
            {
                double numero = 0;
                if (i == 0)
                {
                    Colum = a * Xo + Ce;
                }

                else
                {
                    Colum = a * Xi + Ce; 
                }

                Xi = Colum % m;
                numero = Xi / (m); //no incluye 1

                //numero = Xi / (m-1); incluyendo 1
                lstNumeros.Items.Add(Math.Round(numero,4));
            }

            double valorMin = 0;
            double valorMax = 0;

            // llenar grilla

            for (int i = 0; i < Convert.ToInt32(TxtCantidadIntervalos.Text); i++)
            {
                int contador = 0;

                DataGridViewRow fila = new DataGridViewRow();

                DataGridViewTextBoxCell celdaIntervalo = new DataGridViewTextBoxCell();


                if (i == 0)
                {
                    valorMax = (double)1 / (double)Convert.ToDecimal(TxtCantidadIntervalos.Text);
                    foreach (double item in lstNumeros.Items)
                    {
                        if (item > valorMin && item < valorMax)
                        {
                            contador = contador + 1;
                        }

                    }
                    celdaIntervalo.Value = Math.Round(valorMin,4) + "-" + Math.Round(valorMax,4);
                    fila.Cells.Add(celdaIntervalo);
                }
                else
                {
                    valorMin = valorMin + ((double)1 / (double)Convert.ToDecimal(TxtCantidadIntervalos.Text));
                    valorMax = valorMax + ((double)1 / (double)Convert.ToDecimal(TxtCantidadIntervalos.Text));
                    foreach (double item in lstNumeros.Items)
                    {
                        if (item > valorMin && item < valorMax)
                        {
                            contador = contador + 1;
                        }
                    }
                    celdaIntervalo.Value = Math.Round(valorMin) + "-" + Math.Round(valorMax);
                    fila.Cells.Add(celdaIntervalo);
                }

                DataGridViewTextBoxCell celdaFo = new DataGridViewTextBoxCell();
                Convert.ToString(contador);
                celdaFo.Value = contador;
                fila.Cells.Add(celdaFo);

                DataGridViewTextBoxCell celdaFe = new DataGridViewTextBoxCell();
                celdaFe.Value = Math.Round(Convert.ToDecimal(TxtTamañoMuestra.Text) / Convert.ToDecimal(TxtCantidadIntervalos.Text),4);
                fila.Cells.Add(celdaFe);

                DataGridViewTextBoxCell celdaC = new DataGridViewTextBoxCell();
                double Fe = Convert.ToDouble(TxtTamañoMuestra.Text) / Convert.ToDouble(TxtCantidadIntervalos.Text);
                double Fo = Convert.ToDouble(contador);
                double resta = Fo - Fe;
                double c = Math.Pow(resta, 2) / Fe;
                celdaC.Value = Math.Round(c,4);
                fila.Cells.Add(celdaC);

                DataGridViewTextBoxCell celdaCacum = new DataGridViewTextBoxCell();
                if (i == 0)
                {

                    acumulador = c;
                }
                else
                {
                    acumulador = acumulador + c;
                }
                celdaCacum.Value = acumulador;
                fila.Cells.Add(celdaCacum);

                grillaDatos.Rows.Add(fila);
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana = new VentanaPrincipal();

            this.Close();
            ventana.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
