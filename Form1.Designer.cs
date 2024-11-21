namespace WinFormsSumaDosNumeros
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
            label4 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtR = new TextBox();
            Limpiar = new Button();
            Calcular = new Button();
            Salir = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 23);
            label1.Name = "label1";
            label1.Size = new Size(328, 35);
            label1.TabIndex = 0;
            label1.Text = "SUMA DE DOS NUMEROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orchid;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 107);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 1;
            label2.Text = "PRIMER NÚMERO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.HotPink;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 171);
            label3.Name = "label3";
            label3.Size = new Size(206, 24);
            label3.TabIndex = 2;
            label3.Text = "SEGUNDO NÚMERO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LimeGreen;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 228);
            label4.Name = "label4";
            label4.Size = new Size(132, 24);
            label4.TabIndex = 3;
            label4.Text = "RESULTADO";
            // 
            // txtN1
            // 
            txtN1.BackColor = Color.Plum;
            txtN1.Location = new Point(350, 107);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(189, 27);
            txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            txtN2.BackColor = Color.LightPink;
            txtN2.Location = new Point(350, 164);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(189, 27);
            txtN2.TabIndex = 5;
            // 
            // txtR
            // 
            txtR.BackColor = Color.LightGreen;
            txtR.Location = new Point(350, 225);
            txtR.Name = "txtR";
            txtR.Size = new Size(189, 27);
            txtR.TabIndex = 6;
            // 
            // Limpiar
            // 
            Limpiar.BackColor = Color.SandyBrown;
            Limpiar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Limpiar.Location = new Point(61, 319);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(104, 54);
            Limpiar.TabIndex = 7;
            Limpiar.Text = "LIMPIAR";
            Limpiar.UseVisualStyleBackColor = false;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.Khaki;
            Calcular.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calcular.Location = new Point(287, 319);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(117, 54);
            Calcular.TabIndex = 8;
            Calcular.Text = "CALCULAR";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // Salir
            // 
            Salir.BackColor = Color.LightCoral;
            Salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salir.Location = new Point(517, 319);
            Salir.Name = "Salir";
            Salir.Size = new Size(104, 54);
            Salir.TabIndex = 9;
            Salir.Text = "SALIR";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 409);
            label5.Name = "label5";
            label5.Size = new Size(514, 28);
            label5.TabIndex = 10;
            label5.Text = "VALERIA BERNAL SALCEDO ID:357658";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 450);
            Controls.Add(label5);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(Limpiar);
            Controls.Add(txtR);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtR;
        private Button Limpiar;
        private Button Calcular;
        private Button Salir;
        private Label label5;
    }
}
