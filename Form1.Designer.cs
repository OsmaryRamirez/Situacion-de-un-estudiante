namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nota4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_situacion = new System.Windows.Forms.TextBox();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.txt_nota4 = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(95, 363);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(139, 37);
            this.labe.TabIndex = 2;
            this.labe.Text = "Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Situacion";
            // 
            // nota4
            // 
            this.nota4.AutoSize = true;
            this.nota4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota4.Location = new System.Drawing.Point(95, 268);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(103, 37);
            this.nota4.TabIndex = 4;
            this.nota4.Text = "Nota 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nota 3";
            // 
            // txt_nota2
            // 
            this.txt_nota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota2.Location = new System.Drawing.Point(215, 191);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(145, 38);
            this.txt_nota2.TabIndex = 6;
            this.txt_nota2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_situacion
            // 
            this.txt_situacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_situacion.Location = new System.Drawing.Point(239, 402);
            this.txt_situacion.Name = "txt_situacion";
            this.txt_situacion.Size = new System.Drawing.Size(291, 38);
            this.txt_situacion.TabIndex = 7;
            // 
            // txt_promedio
            // 
            this.txt_promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_promedio.Location = new System.Drawing.Point(241, 360);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(145, 38);
            this.txt_promedio.TabIndex = 8;
            // 
            // txt_nota3
            // 
            this.txt_nota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota3.Location = new System.Drawing.Point(215, 235);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(145, 38);
            this.txt_nota3.TabIndex = 9;
            // 
            // txt_nota4
            // 
            this.txt_nota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota4.Location = new System.Drawing.Point(215, 279);
            this.txt_nota4.Name = "txt_nota4";
            this.txt_nota4.Size = new System.Drawing.Size(145, 38);
            this.txt_nota4.TabIndex = 10;
            // 
            // txt_nota1
            // 
            this.txt_nota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota1.Location = new System.Drawing.Point(215, 147);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(145, 38);
            this.txt_nota1.TabIndex = 11;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(604, 474);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(153, 46);
            this.btn_calcular.TabIndex = 12;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(622, 31);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(135, 46);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(36, 474);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(135, 49);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 50);
            this.label3.TabIndex = 15;
            this.label3.Text = "Situacion del estudiante";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 141);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(586, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 150);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(793, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.txt_nota4);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.txt_promedio);
            this.Controls.Add(this.txt_situacion);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nota4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_situacion;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.TextBox txt_nota4;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

