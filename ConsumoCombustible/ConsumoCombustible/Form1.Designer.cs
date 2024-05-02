namespace ConsumoCombustible
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
            txtD = new TextBox();
            txtC = new TextBox();
            txtG = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 25);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Distancia Recorrida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 110);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Consumo Km/Galón";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 249);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Galones Consumidos";
            // 
            // txtD
            // 
            txtD.Location = new Point(348, 60);
            txtD.Name = "txtD";
            txtD.Size = new Size(125, 27);
            txtD.TabIndex = 3;
            // 
            // txtC
            // 
            txtC.Location = new Point(348, 145);
            txtC.Name = "txtC";
            txtC.Size = new Size(125, 27);
            txtC.TabIndex = 4;
            // 
            // txtG
            // 
            txtG.Location = new Point(348, 284);
            txtG.Name = "txtG";
            txtG.Size = new Size(125, 27);
            txtG.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(360, 198);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtG);
            Controls.Add(txtC);
            Controls.Add(txtD);
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
        private TextBox txtD;
        private TextBox txtC;
        private TextBox txtG;
        private Button btnCalcular;
    }
}
