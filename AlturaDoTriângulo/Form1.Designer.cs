namespace AlturaDoTriângulo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.NumericUpDown();
            this.txbN2 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txbN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbN2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(51, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora De Triângulo";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(53, 77);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(37, 13);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Base :";
            this.lblN1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(53, 125);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(40, 13);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Altura :";
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(112, 75);
            this.txbN1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(120, 20);
            this.txbN1.TabIndex = 3;
            this.txbN1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(112, 123);
            this.txbN2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(120, 20);
            this.txbN2.TabIndex = 4;
            this.txbN2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(94, 261);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 352);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora De Triângulo";
            ((System.ComponentModel.ISupportInitialize)(this.txbN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.NumericUpDown txbN1;
        private System.Windows.Forms.NumericUpDown txbN2;
        private System.Windows.Forms.Button btnCalcular;
    }
}

