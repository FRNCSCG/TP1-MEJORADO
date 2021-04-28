
namespace TP1_simulacion
{
    partial class Punto2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.grillaDatos = new System.Windows.Forms.DataGridView();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cacu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btonGenerar = new System.Windows.Forms.Button();
            this.TxtCantidadIntervalos = new System.Windows.Forms.TextBox();
            this.TxtTamañoMuestra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // chr
            // 
            this.chr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chr.BackImageTransparentColor = System.Drawing.Color.White;
            this.chr.BackSecondaryColor = System.Drawing.Color.White;
            this.chr.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chr.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chr.Legends.Add(legend1);
            this.chr.Location = new System.Drawing.Point(508, 18);
            this.chr.Name = "chr";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chr.Series.Add(series1);
            this.chr.Size = new System.Drawing.Size(403, 506);
            this.chr.TabIndex = 16;
            this.chr.Text = "chart1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(207, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 25;
            this.button2.Text = "Limpiar Campos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // grillaDatos
            // 
            this.grillaDatos.AllowUserToAddRows = false;
            this.grillaDatos.AllowUserToDeleteRows = false;
            this.grillaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.grillaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.Fo,
            this.Fe,
            this.C,
            this.Cacu});
            this.grillaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.grillaDatos.Location = new System.Drawing.Point(27, 193);
            this.grillaDatos.Name = "grillaDatos";
            this.grillaDatos.ReadOnly = true;
            this.grillaDatos.RowHeadersVisible = false;
            this.grillaDatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.grillaDatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grillaDatos.Size = new System.Drawing.Size(465, 331);
            this.grillaDatos.TabIndex = 24;
            // 
            // Intervalo
            // 
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.ReadOnly = true;
            // 
            // Fo
            // 
            this.Fo.HeaderText = "Fo";
            this.Fo.Name = "Fo";
            this.Fo.ReadOnly = true;
            // 
            // Fe
            // 
            this.Fe.HeaderText = "Fe";
            this.Fe.Name = "Fe";
            this.Fe.ReadOnly = true;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // Cacu
            // 
            this.Cacu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cacu.HeaderText = "Cacu";
            this.Cacu.Name = "Cacu";
            this.Cacu.ReadOnly = true;
            // 
            // lstNumeros
            // 
            this.lstNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.lstNumeros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(324, 18);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(168, 160);
            this.lstNumeros.TabIndex = 23;
            // 
            // btonGenerar
            // 
            this.btonGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btonGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btonGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonGenerar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btonGenerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btonGenerar.Location = new System.Drawing.Point(45, 140);
            this.btonGenerar.Name = "btonGenerar";
            this.btonGenerar.Size = new System.Drawing.Size(100, 38);
            this.btonGenerar.TabIndex = 22;
            this.btonGenerar.Text = "Generar";
            this.btonGenerar.UseVisualStyleBackColor = false;
            this.btonGenerar.Click += new System.EventHandler(this.btonGenerar_Click);
            // 
            // TxtCantidadIntervalos
            // 
            this.TxtCantidadIntervalos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.TxtCantidadIntervalos.Location = new System.Drawing.Point(269, 64);
            this.TxtCantidadIntervalos.Name = "TxtCantidadIntervalos";
            this.TxtCantidadIntervalos.Size = new System.Drawing.Size(38, 22);
            this.TxtCantidadIntervalos.TabIndex = 21;
            // 
            // TxtTamañoMuestra
            // 
            this.TxtTamañoMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.TxtTamañoMuestra.Location = new System.Drawing.Point(269, 20);
            this.TxtTamañoMuestra.Name = "TxtTamañoMuestra";
            this.TxtTamañoMuestra.Size = new System.Drawing.Size(38, 22);
            this.TxtTamañoMuestra.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad de intervalos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tamaño de muestra";
            // 
            // Punto22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(923, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grillaDatos);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btonGenerar);
            this.Controls.Add(this.TxtCantidadIntervalos);
            this.Controls.Add(this.TxtTamañoMuestra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chr);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Punto22";
            this.Text = "Punto22";
            ((System.ComponentModel.ISupportInitialize)(this.chr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grillaDatos;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btonGenerar;
        private System.Windows.Forms.TextBox TxtCantidadIntervalos;
        private System.Windows.Forms.TextBox TxtTamañoMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cacu;
    }
}