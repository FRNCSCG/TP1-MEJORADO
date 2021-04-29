
namespace TP1_simulacion
{
    partial class Punto3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblChi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDatos
            // 
            this.grillaDatos.AllowUserToAddRows = false;
            this.grillaDatos.AllowUserToDeleteRows = false;
            this.grillaDatos.AllowUserToResizeRows = false;
            this.grillaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.grillaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.Fo,
            this.Fe,
            this.C,
            this.Cacu});
            this.grillaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.grillaDatos.Location = new System.Drawing.Point(379, 192);
            this.grillaDatos.Name = "grillaDatos";
            this.grillaDatos.ReadOnly = true;
            this.grillaDatos.RowHeadersVisible = false;
            this.grillaDatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.grillaDatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grillaDatos.Size = new System.Drawing.Size(505, 329);
            this.grillaDatos.TabIndex = 21;
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
            this.lstNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.lstNumeros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(51, 192);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(255, 329);
            this.lstNumeros.TabIndex = 20;
            // 
            // btonGenerar
            // 
            this.btonGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btonGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btonGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonGenerar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btonGenerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btonGenerar.Location = new System.Drawing.Point(51, 128);
            this.btonGenerar.Name = "btonGenerar";
            this.btonGenerar.Size = new System.Drawing.Size(100, 38);
            this.btonGenerar.TabIndex = 19;
            this.btonGenerar.Text = "Generar";
            this.btonGenerar.UseVisualStyleBackColor = false;
            this.btonGenerar.Click += new System.EventHandler(this.btonGenerar_Click);
            // 
            // TxtCantidadIntervalos
            // 
            this.TxtCantidadIntervalos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.TxtCantidadIntervalos.Location = new System.Drawing.Point(268, 63);
            this.TxtCantidadIntervalos.Name = "TxtCantidadIntervalos";
            this.TxtCantidadIntervalos.Size = new System.Drawing.Size(38, 20);
            this.TxtCantidadIntervalos.TabIndex = 18;
            // 
            // TxtTamañoMuestra
            // 
            this.TxtTamañoMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.TxtTamañoMuestra.Location = new System.Drawing.Point(268, 18);
            this.TxtTamañoMuestra.Name = "TxtTamañoMuestra";
            this.TxtTamañoMuestra.Size = new System.Drawing.Size(38, 20);
            this.TxtTamañoMuestra.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad de intervalos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tamaño de muestra";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(206, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 35;
            this.button2.Text = "Limpiar Campos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(532, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "c";
            // 
            // txtg
            // 
            this.txtg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtg.Location = new System.Drawing.Point(418, 76);
            this.txtg.Name = "txtg";
            this.txtg.Size = new System.Drawing.Size(38, 20);
            this.txtg.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(376, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "k";
            // 
            // txtK
            // 
            this.txtK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtK.Location = new System.Drawing.Point(418, 127);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(38, 20);
            this.txtK.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(532, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(376, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "g";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtC.Location = new System.Drawing.Point(570, 20);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(38, 20);
            this.txtC.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(376, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Xo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(532, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "m";
            // 
            // txtXo
            // 
            this.txtXo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtXo.Location = new System.Drawing.Point(418, 21);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(38, 20);
            this.txtXo.TabIndex = 23;
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtM.Location = new System.Drawing.Point(570, 128);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(38, 20);
            this.txtM.TabIndex = 34;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtA.Location = new System.Drawing.Point(570, 76);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(38, 20);
            this.txtA.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(684, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Chi Tabulado";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(727, 141);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(0, 13);
            this.lblConclusion.TabIndex = 37;
            // 
            // lblChi
            // 
            this.lblChi.AutoSize = true;
            this.lblChi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChi.Location = new System.Drawing.Point(788, 165);
            this.lblChi.Name = "lblChi";
            this.lblChi.Size = new System.Drawing.Size(0, 13);
            this.lblChi.TabIndex = 36;
            // 
            // Punto3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(970, 573);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblChi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXo);
            this.Controls.Add(this.grillaDatos);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btonGenerar);
            this.Controls.Add(this.TxtCantidadIntervalos);
            this.Controls.Add(this.TxtTamañoMuestra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Punto3";
            this.Text = "Punto3";
            this.Load += new System.EventHandler(this.Punto3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblChi;
    }
}