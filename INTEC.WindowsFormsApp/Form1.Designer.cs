namespace INTEC.WindowsFormsApp
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
            this.txtPrimerParcial = new System.Windows.Forms.TextBox();
            this.txtSegundoParcial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTercerParcial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DE NOTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Parcial:";
            // 
            // txtPrimerParcial
            // 
            this.txtPrimerParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerParcial.Location = new System.Drawing.Point(33, 129);
            this.txtPrimerParcial.MaxLength = 3;
            this.txtPrimerParcial.Name = "txtPrimerParcial";
            this.txtPrimerParcial.Size = new System.Drawing.Size(232, 30);
            this.txtPrimerParcial.TabIndex = 2;
            this.txtPrimerParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerParcial_KeyPress);
            // 
            // txtSegundoParcial
            // 
            this.txtSegundoParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoParcial.Location = new System.Drawing.Point(33, 192);
            this.txtSegundoParcial.MaxLength = 3;
            this.txtSegundoParcial.Name = "txtSegundoParcial";
            this.txtSegundoParcial.Size = new System.Drawing.Size(232, 30);
            this.txtSegundoParcial.TabIndex = 4;
            this.txtSegundoParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerParcial_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundo Parcial:";
            // 
            // txtTercerParcial
            // 
            this.txtTercerParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTercerParcial.Location = new System.Drawing.Point(33, 254);
            this.txtTercerParcial.MaxLength = 3;
            this.txtTercerParcial.Name = "txtTercerParcial";
            this.txtTercerParcial.Size = new System.Drawing.Size(232, 30);
            this.txtTercerParcial.TabIndex = 6;
            this.txtTercerParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerParcial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tercer Parcial:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.ForeColor = System.Drawing.Color.Crimson;
            this.lblPromedio.Location = new System.Drawing.Point(283, 110);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(238, 170);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "00";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(33, 309);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(496, 71);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 408);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.txtTercerParcial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSegundoParcial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrimerParcial);
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
        private System.Windows.Forms.TextBox txtPrimerParcial;
        private System.Windows.Forms.TextBox txtSegundoParcial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTercerParcial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnCalc;
    }
}

