namespace Laboratorio122
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nota1 = new System.Windows.Forms.TextBox();
            this.tb_nota2 = new System.Windows.Forms.TextBox();
            this.tb_nota3 = new System.Windows.Forms.TextBox();
            this.tb_promedio = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(266, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Nota Promedio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(211, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(211, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(211, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(134, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota Promedio";
            // 
            // tb_nota1
            // 
            this.tb_nota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_nota1.Location = new System.Drawing.Point(281, 78);
            this.tb_nota1.Name = "tb_nota1";
            this.tb_nota1.Size = new System.Drawing.Size(190, 30);
            this.tb_nota1.TabIndex = 5;
            // 
            // tb_nota2
            // 
            this.tb_nota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_nota2.Location = new System.Drawing.Point(281, 131);
            this.tb_nota2.Name = "tb_nota2";
            this.tb_nota2.Size = new System.Drawing.Size(190, 30);
            this.tb_nota2.TabIndex = 6;
            // 
            // tb_nota3
            // 
            this.tb_nota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_nota3.Location = new System.Drawing.Point(281, 186);
            this.tb_nota3.Name = "tb_nota3";
            this.tb_nota3.Size = new System.Drawing.Size(190, 30);
            this.tb_nota3.TabIndex = 7;
            // 
            // tb_promedio
            // 
            this.tb_promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_promedio.Location = new System.Drawing.Point(281, 323);
            this.tb_promedio.Name = "tb_promedio";
            this.tb_promedio.Size = new System.Drawing.Size(190, 30);
            this.tb_promedio.TabIndex = 8;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_calcular.Location = new System.Drawing.Point(166, 247);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(135, 44);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_limpiar.Location = new System.Drawing.Point(318, 247);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(135, 44);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_salir.Location = new System.Drawing.Point(470, 247);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(135, 44);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tb_promedio);
            this.Controls.Add(this.tb_nota3);
            this.Controls.Add(this.tb_nota2);
            this.Controls.Add(this.tb_nota1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nota1;
        private System.Windows.Forms.TextBox tb_nota2;
        private System.Windows.Forms.TextBox tb_nota3;
        private System.Windows.Forms.TextBox tb_promedio;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

