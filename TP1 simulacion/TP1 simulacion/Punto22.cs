using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP1_simulacion
{
    public partial class Punto22 : Form
    {
        public Punto22()
        {
            InitializeComponent();
        }

        public VentanaPrincipal ventana { get; set; }






        private void btonGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCantidadIntervalos.Text.Equals("") || TxtTamañoMuestra.Text.Equals(""))
                {
                    MessageBox.Show("debe completar todos los campos");
                }
                else
                {
                    double acumulador = 0;
                    Random rnd = new Random();
                    for (int i = 0; i < Convert.ToInt32(TxtTamañoMuestra.Text); i++)
                    {
                        double numero = 0;
                        numero = rnd.NextDouble();
                        lstNumeros.Items.Add(Math.Round(numero, 4));

                    }

                    double valorMin = 0;
                    double valorMax = 0;
                    int FreqEs = 0;

                    for (int i = 0; i < Convert.ToInt32(TxtCantidadIntervalos.Text); i++)
                    {

                        int contador = 0;

                        DataGridViewRow fila = new DataGridViewRow();


                        // celda intervalo
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
                            celdaIntervalo.Value = Math.Round(valorMin,4) + "-" + Math.Round(valorMax,4);
                            fila.Cells.Add(celdaIntervalo);
                        }


                        // Celda Fo
                        DataGridViewTextBoxCell celdaFo = new DataGridViewTextBoxCell();
                        Convert.ToString(contador);
                        celdaFo.Value = contador;
                        fila.Cells.Add(celdaFo);

                        // celda Fe
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
                        celdaCacum.Value = Math.Round(acumulador,4);
                        fila.Cells.Add(celdaCacum);

                        //AgregarFila
                        grillaDatos.Rows.Add(fila);

                        // Grafico
                        string intervalo = Convert.ToString(valorMin) + "-" + Convert.ToString(valorMax);
                        Series serieGR = chr.Series.Add(intervalo);
                        serieGR.Points.AddXY("intervalos", contador);

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("debe limpiar los campos");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Controls.Clear();
            InitializeComponent();


        }


    }
}
