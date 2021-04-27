
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr)).BeginInit();
            this.SuspendLayout();
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
            this.grillaDatos.Location = new System.Drawing.Point(4, 204);
            this.grillaDatos.Name = "grillaDatos";
            this.grillaDatos.ReadOnly = true;
            this.grillaDatos.RowHeadersVisible = false;
            this.grillaDatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.grillaDatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grillaDatos.Size = new System.Drawing.Size(472, 331);
            this.grillaDatos.TabIndex = 13;
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
            this.Cacu.HeaderText = "Cacu";
            this.Cacu.Name = "Cacu";
            this.Cacu.ReadOnly = true;
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(308, 12);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(168, 160);
            this.lstNumeros.TabIndex = 12;
            // 
            // btonGenerar
            // 
            this.btonGenerar.Location = new System.Drawing.Point(12, 127);
            this.btonGenerar.Name = "btonGenerar";
            this.btonGenerar.Size = new System.Drawing.Size(126, 45);
            this.btonGenerar.TabIndex = 11;
            this.btonGenerar.Text = "Generar";
            this.btonGenerar.UseVisualStyleBackColor = true;
            this.btonGenerar.Click += new System.EventHandler(this.btonGenerar_Click_1);
            // 
            // TxtCantidadIntervalos
            // 
            this.TxtCantidadIntervalos.Location = new System.Drawing.Point(253, 73);
            this.TxtCantidadIntervalos.Name = "TxtCantidadIntervalos";
            this.TxtCantidadIntervalos.Size = new System.Drawing.Size(38, 22);
            this.TxtCantidadIntervalos.TabIndex = 10;
            // 
            // TxtTamañoMuestra
            // 
            this.TxtTamañoMuestra.Location = new System.Drawing.Point(253, 29);
            this.TxtTamañoMuestra.Name = "TxtTamañoMuestra";
            this.TxtTamañoMuestra.Size = new System.Drawing.Size(38, 22);
            this.TxtTamañoMuestra.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de intervalos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tamaño de muestra";
            // 
            // chr
            // 
            this.chr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chr.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chr.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chr.Legends.Add(legend1);
            this.chr.Location = new System.Drawing.Point(490, 12);
            this.chr.Name = "chr";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chr.Series.Add(series1);
            this.chr.Size = new System.Drawing.Size(468, 523);
            this.chr.TabIndex = 15;
            this.chr.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Limpiar Campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Punto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(970, 549);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chr);
            this.Controls.Add(this.grillaDatos);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btonGenerar);
            this.Controls.Add(this.TxtCantidadIntervalos);
            this.Controls.Add(this.TxtTamañoMuestra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Punto2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto2";
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cacu;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btonGenerar;
        private System.Windows.Forms.TextBox TxtCantidadIntervalos;
        private System.Windows.Forms.TextBox TxtTamañoMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr;
        private System.Windows.Forms.Button button2;
    }
}