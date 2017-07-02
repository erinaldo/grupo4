namespace Bancos_Contabilidad
{
    partial class frmEstadosFinancieros
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.comboBox1.Location = new System.Drawing.Point(15, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // rbBalance
            // 
            this.rbBalance.AutoSize = true;
            this.rbBalance.Location = new System.Drawing.Point(228, 17);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.Size = new System.Drawing.Size(104, 17);
            this.rbBalance.TabIndex = 2;
            this.rbBalance.TabStop = true;
            this.rbBalance.Text = "Balance General";
            this.rbBalance.UseVisualStyleBackColor = true;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Location = new System.Drawing.Point(228, 41);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(124, 17);
            this.rbEstado.TabIndex = 3;
            this.rbEstado.TabStop = true;
            this.rbEstado.Text = "Estado de Resultado";
            this.rbEstado.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(115, 75);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEstadosFinancieros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(358, 110);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.rbEstado);
            this.Controls.Add(this.rbBalance);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadosFinancieros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstadosFinancieros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.Button btnGenerar;
    }
}