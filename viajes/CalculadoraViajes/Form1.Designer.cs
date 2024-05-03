namespace CalculadoraViajes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            label4 = new Label();
            txtA = new TextBox();
            txtTestimado = new TextBox();
            txtVelocidad = new TextBox();
            txtB = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Punto A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 119);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Punto B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 209);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Velocidad Constante";
            label3.Click += label3_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(328, 299);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(76, 36);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 350);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 4;
            label4.Text = "Tiempo Estimado";
            // 
            // txtA
            // 
            txtA.Location = new Point(296, 71);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 5;
            // 
            // txtTestimado
            // 
            txtTestimado.Location = new Point(296, 389);
            txtTestimado.Name = "txtTestimado";
            txtTestimado.Size = new Size(125, 27);
            txtTestimado.TabIndex = 6;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(296, 250);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(125, 27);
            txtVelocidad.TabIndex = 7;
            // 
            // txtB
            // 
            txtB.Location = new Point(296, 158);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtB);
            Controls.Add(txtVelocidad);
            Controls.Add(txtTestimado);
            Controls.Add(txtA);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label label4;
        private TextBox txtA;
        private TextBox txtTestimado;
        private TextBox txtVelocidad;
        private TextBox txtB;
    }
}
