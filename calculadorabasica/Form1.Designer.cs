namespace calculadorabasica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtNum1
            this.txtNum1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtNum1.Location = new System.Drawing.Point(20, 30);
            this.txtNum1.Size = new System.Drawing.Size(200, 36);
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // txtNum2
            this.txtNum2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtNum2.Location = new System.Drawing.Point(240, 30);
            this.txtNum2.Size = new System.Drawing.Size(200, 36);
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // txtResultado
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtResultado.Location = new System.Drawing.Point(20, 80);
            this.txtResultado.Size = new System.Drawing.Size(420, 40);
            this.txtResultado.ReadOnly = true;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // btnSuma
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnSuma.Location = new System.Drawing.Point(20, 140);
            this.btnSuma.Size = new System.Drawing.Size(80, 60);
            this.btnSuma.Text = "+";
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);

            // btnResta
            this.btnResta.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnResta.Location = new System.Drawing.Point(110, 140);
            this.btnResta.Size = new System.Drawing.Size(80, 60);
            this.btnResta.Text = "-";
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);

            // btnMultiplicar
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnMultiplicar.Location = new System.Drawing.Point(200, 140);
            this.btnMultiplicar.Size = new System.Drawing.Size(80, 60);
            this.btnMultiplicar.Text = "×";
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);

            // btnDividir
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnDividir.Location = new System.Drawing.Point(290, 140);
            this.btnDividir.Size = new System.Drawing.Size(80, 60);
            this.btnDividir.Text = "÷";
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);

            // btnClear
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnClear.Location = new System.Drawing.Point(380, 140);
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(460, 230);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
