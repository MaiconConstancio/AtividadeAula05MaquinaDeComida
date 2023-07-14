
namespace AtividadeAula05MaquinaDeComida
{
    partial class Form2
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
            this.txtParaAdicionarSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarSaldoDigitado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParaAdicionarSaldo
            // 
            this.txtParaAdicionarSaldo.BackColor = System.Drawing.Color.MediumPurple;
            this.txtParaAdicionarSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParaAdicionarSaldo.ForeColor = System.Drawing.Color.Indigo;
            this.txtParaAdicionarSaldo.Location = new System.Drawing.Point(38, 49);
            this.txtParaAdicionarSaldo.Name = "txtParaAdicionarSaldo";
            this.txtParaAdicionarSaldo.Size = new System.Drawing.Size(258, 20);
            this.txtParaAdicionarSaldo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(62, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira o valor desejado!";
            // 
            // btnSalvarSaldoDigitado
            // 
            this.btnSalvarSaldoDigitado.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSalvarSaldoDigitado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarSaldoDigitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarSaldoDigitado.Location = new System.Drawing.Point(38, 84);
            this.btnSalvarSaldoDigitado.Name = "btnSalvarSaldoDigitado";
            this.btnSalvarSaldoDigitado.Size = new System.Drawing.Size(258, 32);
            this.btnSalvarSaldoDigitado.TabIndex = 4;
            this.btnSalvarSaldoDigitado.Text = "Salvar valor!";
            this.btnSalvarSaldoDigitado.UseVisualStyleBackColor = false;
            this.btnSalvarSaldoDigitado.Click += new System.EventHandler(this.btnSalvarSaldoDigitado_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(337, 132);
            this.Controls.Add(this.btnSalvarSaldoDigitado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParaAdicionarSaldo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParaAdicionarSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarSaldoDigitado;
    }
}