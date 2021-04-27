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
    public partial class Punto2 : Form
    {

        public VentanaPrincipal ventana { get; set; }

        public Punto2(VentanaPrincipal ven)
        {
            InitializeComponent();
            ventana = ven;
            
        }

        public Punto2()
        {
        }

        private void btonGenerar_Click_1(object sender, EventArgs e)
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
                        lstNumeros.Items.Add(numero);

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
                            celdaIntervalo.Value = valorMin + "-" + valorMax;
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
                            celdaIntervalo.Value = valorMin + "-" + valorMax;
                            fila.Cells.Add(celdaIntervalo);
                        }


                        // Celda Fo
                        DataGridViewTextBoxCell celdaFo = new DataGridViewTextBoxCell();
                        Convert.ToString(contador);
                        celdaFo.Value = contador;
                        fila.Cells.Add(celdaFo);

                        // celda Fe
                        DataGridViewTextBoxCell celdaFe = new DataGridViewTextBoxCell();
                        celdaFe.Value = Convert.ToDecimal(TxtTamañoMuestra.Text) / Convert.ToDecimal(TxtCantidadIntervalos.Text);
                        fila.Cells.Add(celdaFe);

                        DataGridViewTextBoxCell celdaC = new DataGridViewTextBoxCell();
                        double Fe = Convert.ToDouble(TxtTamañoMuestra.Text) / Convert.ToDouble(TxtCantidadIntervalos.Text);
                        double Fo = Convert.ToDouble(contador);
                        double resta = Fo - Fe;
                        double c = Math.Pow(resta, 2) / Fe;
                        celdaC.Value = c;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ventana.Show();
            this.Close();    
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Punto2 ven = new Punto2(ventana);
            ven.Show();
            this.Close();
        }
    }
}
