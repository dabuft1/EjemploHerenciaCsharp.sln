namespace EjemploHerenciaCsharo
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.btbCalcularFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie Fibonacci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.txtNumero.Location = new System.Drawing.Point(290, 91);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 46);
            this.txtNumero.TabIndex = 2;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(331, 146);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(100, 46);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver serie";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // ltbLista
            // 
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(650, 25);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(82, 303);
            this.ltbLista.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(523, 282);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 46);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblResultado.Location = new System.Drawing.Point(44, 235);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(249, 31);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado Factorial";
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFactorial.Location = new System.Drawing.Point(44, 282);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(137, 31);
            this.lblFactorial.TabIndex = 7;
            this.lblFactorial.Text = "Resultado";
            this.lblFactorial.Visible = false;
            // 
            // btbCalcularFactorial
            // 
            this.btbCalcularFactorial.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btbCalcularFactorial.Location = new System.Drawing.Point(181, 146);
            this.btbCalcularFactorial.Name = "btbCalcularFactorial";
            this.btbCalcularFactorial.Size = new System.Drawing.Size(143, 46);
            this.btbCalcularFactorial.TabIndex = 8;
            this.btbCalcularFactorial.Text = "Calcular Factorial";
            this.btbCalcularFactorial.UseVisualStyleBackColor = true;
            this.btbCalcularFactorial.Click += new System.EventHandler(this.btbCalcularFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 360);
            this.Controls.Add(this.btbCalcularFactorial);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.ltbLista);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ListBox ltbLista;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Button btbCalcularFactorial;
    }
}

