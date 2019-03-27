namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 251);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(0, 199);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 7;
            this.Suma.Text = "Sumar";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(84, 199);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 8;
            this.Resta.Text = "Restar";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(165, 199);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(75, 23);
            this.Multiplicacion.TabIndex = 9;
            this.Multiplicacion.Text = "Multiplicar";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(246, 199);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 10;
            this.Division.Text = "Dividir";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Division;
    }
}

