
namespace TP1_simulacion
{
    partial class Punto1
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dgTabla = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.labbb = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.cbEntManual = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMultiplicativo = new System.Windows.Forms.RadioButton();
            this.btnMixto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSiguiente.Location = new System.Drawing.Point(700, 485);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 38);
            this.btnSiguiente.TabIndex = 30;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // dgTabla
            // 
            this.dgTabla.AllowUserToAddRows = false;
            this.dgTabla.AllowUserToDeleteRows = false;
            this.dgTabla.AllowUserToResizeRows = false;
            this.dgTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.dgTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Rand});
            this.dgTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.dgTabla.Location = new System.Drawing.Point(143, 180);
            this.dgTabla.Name = "dgTabla";
            this.dgTabla.ReadOnly = true;
            this.dgTabla.RowHeadersVisible = false;
            this.dgTabla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.dgTabla.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgTabla.Size = new System.Drawing.Size(540, 343);
            this.dgTabla.TabIndex = 29;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            // 
            // Rand
            // 
            this.Rand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rand.HeaderText = "Rand";
            this.Rand.Name = "Rand";
            this.Rand.ReadOnly = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBorrar.Location = new System.Drawing.Point(583, 125);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 38);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerar.Location = new System.Drawing.Point(460, 125);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(104, 38);
            this.btnGenerar.TabIndex = 27;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.txtC);
            this.panel2.Controls.Add(this.lblC);
            this.panel2.Controls.Add(this.txtG);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtK);
            this.panel2.Controls.Add(this.labbb);
            this.panel2.Controls.Add(this.txtX0);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(354, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 68);
            this.panel2.TabIndex = 32;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtC.Location = new System.Drawing.Point(254, 14);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(36, 22);
            this.txtC.TabIndex = 17;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblC.Location = new System.Drawing.Point(235, 17);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(12, 13);
            this.lblC.TabIndex = 16;
            this.lblC.Text = "c";
            // 
            // txtG
            // 
            this.txtG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtG.Location = new System.Drawing.Point(183, 14);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(36, 22);
            this.txtG.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(164, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "g";
            // 
            // txtK
            // 
            this.txtK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtK.Location = new System.Drawing.Point(111, 14);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(36, 22);
            this.txtK.TabIndex = 13;
            // 
            // labbb
            // 
            this.labbb.AutoSize = true;
            this.labbb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labbb.Location = new System.Drawing.Point(92, 17);
            this.labbb.Name = "labbb";
            this.labbb.Size = new System.Drawing.Size(13, 13);
            this.labbb.TabIndex = 12;
            this.labbb.Text = "k";
            // 
            // txtX0
            // 
            this.txtX0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtX0.Location = new System.Drawing.Point(36, 14);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(36, 22);
            this.txtX0.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.txtM);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtA);
            this.panel3.Controls.Add(this.cbEntManual);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(668, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 68);
            this.panel3.TabIndex = 32;
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtM.Location = new System.Drawing.Point(96, 14);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(36, 22);
            this.txtM.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(75, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "m";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtA.Location = new System.Drawing.Point(31, 14);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(36, 22);
            this.txtA.TabIndex = 19;
            // 
            // cbEntManual
            // 
            this.cbEntManual.AutoSize = true;
            this.cbEntManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.cbEntManual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbEntManual.Location = new System.Drawing.Point(24, 43);
            this.cbEntManual.Name = "cbEntManual";
            this.cbEntManual.Size = new System.Drawing.Size(108, 17);
            this.cbEntManual.TabIndex = 22;
            this.cbEntManual.Text = "Entrada Manual";
            this.cbEntManual.UseVisualStyleBackColor = false;
            this.cbEntManual.CheckedChanged += new System.EventHandler(this.cbEntManual_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "a";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnMultiplicativo);
            this.panel1.Controls.Add(this.btnMixto);
            this.panel1.Location = new System.Drawing.Point(143, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 68);
            this.panel1.TabIndex = 31;
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.AutoSize = true;
            this.btnMultiplicativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiplicativo.Location = new System.Drawing.Point(97, 19);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(95, 17);
            this.btnMultiplicativo.TabIndex = 2;
            this.btnMultiplicativo.TabStop = true;
            this.btnMultiplicativo.Text = "Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.CheckedChanged += new System.EventHandler(this.btnMultiplicativo_CheckedChanged_1);
            // 
            // btnMixto
            // 
            this.btnMixto.AutoSize = true;
            this.btnMixto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMixto.Location = new System.Drawing.Point(22, 19);
            this.btnMixto.Name = "btnMixto";
            this.btnMixto.Size = new System.Drawing.Size(54, 17);
            this.btnMixto.TabIndex = 1;
            this.btnMixto.TabStop = true;
            this.btnMixto.Text = "Mixto";
            this.btnMixto.UseVisualStyleBackColor = true;
            this.btnMixto.CheckedChanged += new System.EventHandler(this.btnMixto_CheckedChanged_1);
            // 
            // Punto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(970, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dgTabla);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Punto1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto_1";
            this.Load += new System.EventHandler(this.Punto_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rand;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label labbb;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnMultiplicativo;
        private System.Windows.Forms.RadioButton btnMixto;
        private System.Windows.Forms.CheckBox cbEntManual;
        private System.Windows.Forms.Panel panel3;
    }
}