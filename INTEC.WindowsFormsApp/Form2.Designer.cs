namespace INTEC.WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRentaTotal = new System.Windows.Forms.TextBox();
            this.txtSeguroTotal = new System.Windows.Forms.TextBox();
            this.txtAFPTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULO DE IMPUESTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(16, 45);
            this.txtSeguro.MaxLength = 3;
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(133, 30);
            this.txtSeguro.TabIndex = 4;
            this.txtSeguro.Text = "9";
            this.txtSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "% Seguro:";
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBruto.Location = new System.Drawing.Point(70, 114);
            this.txtSueldoBruto.MaxLength = 3;
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(232, 30);
            this.txtSueldoBruto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sueldo Bruto:";
            // 
            // txtAFP
            // 
            this.txtAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFP.Location = new System.Drawing.Point(262, 45);
            this.txtAFP.MaxLength = 3;
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(133, 30);
            this.txtAFP.TabIndex = 10;
            this.txtAFP.Text = "7";
            this.txtAFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "% AFP:";
            // 
            // txtRenta
            // 
            this.txtRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenta.Location = new System.Drawing.Point(472, 45);
            this.txtRenta.MaxLength = 3;
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(131, 30);
            this.txtRenta.TabIndex = 12;
            this.txtRenta.Text = "10";
            this.txtRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "% Renta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRentaTotal);
            this.groupBox1.Controls.Add(this.txtSeguroTotal);
            this.groupBox1.Controls.Add(this.txtAFPTotal);
            this.groupBox1.Controls.Add(this.txtRenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSeguro);
            this.groupBox1.Controls.Add(this.txtAFP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(70, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 142);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deducciones:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRentaTotal
            // 
            this.txtRentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentaTotal.Location = new System.Drawing.Point(472, 81);
            this.txtRentaTotal.MaxLength = 3;
            this.txtRentaTotal.Name = "txtRentaTotal";
            this.txtRentaTotal.ReadOnly = true;
            this.txtRentaTotal.Size = new System.Drawing.Size(131, 30);
            this.txtRentaTotal.TabIndex = 15;
            this.txtRentaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSeguroTotal
            // 
            this.txtSeguroTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguroTotal.Location = new System.Drawing.Point(16, 81);
            this.txtSeguroTotal.MaxLength = 3;
            this.txtSeguroTotal.Name = "txtSeguroTotal";
            this.txtSeguroTotal.ReadOnly = true;
            this.txtSeguroTotal.Size = new System.Drawing.Size(133, 30);
            this.txtSeguroTotal.TabIndex = 13;
            this.txtSeguroTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAFPTotal
            // 
            this.txtAFPTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFPTotal.Location = new System.Drawing.Point(262, 81);
            this.txtAFPTotal.MaxLength = 3;
            this.txtAFPTotal.Name = "txtAFPTotal";
            this.txtAFPTotal.ReadOnly = true;
            this.txtAFPTotal.Size = new System.Drawing.Size(133, 30);
            this.txtAFPTotal.TabIndex = 14;
            this.txtAFPTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(130, 325);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(496, 71);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.ForeColor = System.Drawing.Color.Crimson;
            this.lblSueldoNeto.Location = new System.Drawing.Point(606, 87);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSueldoNeto.Size = new System.Drawing.Size(106, 76);
            this.lblSueldoNeto.TabIndex = 15;
            this.lblSueldoNeto.Text = "00";
            this.lblSueldoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSueldoBruto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRentaTotal;
        private System.Windows.Forms.TextBox txtSeguroTotal;
        private System.Windows.Forms.TextBox txtAFPTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblSueldoNeto;
    }
}