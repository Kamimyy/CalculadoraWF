namespace CalculadoraWF
{
    partial class Calculadora
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
            Pantalla = new TextBox();
            BotonCE = new Button();
            BotonDiv = new Button();
            BotonMult = new Button();
            BotonRestar = new Button();
            BotonSumar = new Button();
            Boton9 = new Button();
            Boton8 = new Button();
            Boton7 = new Button();
            BotonPotencia = new Button();
            Boton6 = new Button();
            Boton5 = new Button();
            Boton4 = new Button();
            BotonIgual = new Button();
            Boton3 = new Button();
            Boton2 = new Button();
            Boton1 = new Button();
            BotonComa = new Button();
            Boton0 = new Button();
            SuspendLayout();
            // 
            // Pantalla
            // 
            Pantalla.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Pantalla.Location = new Point(9, 12);
            Pantalla.Multiline = true;
            Pantalla.Name = "Pantalla";
            Pantalla.ReadOnly = true;
            Pantalla.Size = new Size(230, 35);
            Pantalla.TabIndex = 1;
            Pantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // BotonCE
            // 
            BotonCE.BackColor = Color.FromArgb(255, 192, 192);
            BotonCE.Location = new Point(9, 53);
            BotonCE.Name = "BotonCE";
            BotonCE.Size = new Size(53, 38);
            BotonCE.TabIndex = 2;
            BotonCE.Text = "CE";
            BotonCE.UseVisualStyleBackColor = false;
            BotonCE.Click += BotonCE_Click;
            // 
            // BotonDiv
            // 
            BotonDiv.BackColor = Color.FromArgb(255, 224, 192);
            BotonDiv.Location = new Point(68, 53);
            BotonDiv.Name = "BotonDiv";
            BotonDiv.Size = new Size(53, 38);
            BotonDiv.TabIndex = 3;
            BotonDiv.Text = "/";
            BotonDiv.UseVisualStyleBackColor = false;
            BotonDiv.Click += BotonDiv_Click;
            // 
            // BotonMult
            // 
            BotonMult.BackColor = Color.FromArgb(255, 224, 192);
            BotonMult.Location = new Point(127, 53);
            BotonMult.Name = "BotonMult";
            BotonMult.Size = new Size(53, 38);
            BotonMult.TabIndex = 4;
            BotonMult.Text = "*";
            BotonMult.UseVisualStyleBackColor = false;
            BotonMult.Click += BotonMult_Click;
            // 
            // BotonRestar
            // 
            BotonRestar.BackColor = Color.FromArgb(255, 224, 192);
            BotonRestar.Location = new Point(186, 53);
            BotonRestar.Name = "BotonRestar";
            BotonRestar.Size = new Size(53, 38);
            BotonRestar.TabIndex = 5;
            BotonRestar.Text = "-";
            BotonRestar.UseVisualStyleBackColor = false;
            BotonRestar.Click += BotonRestar_Click;
            // 
            // BotonSumar
            // 
            BotonSumar.BackColor = Color.FromArgb(255, 224, 192);
            BotonSumar.Location = new Point(186, 97);
            BotonSumar.Name = "BotonSumar";
            BotonSumar.Size = new Size(53, 38);
            BotonSumar.TabIndex = 9;
            BotonSumar.Text = "+";
            BotonSumar.UseVisualStyleBackColor = false;
            BotonSumar.Click += BotonSumar_Click;
            // 
            // Boton9
            // 
            Boton9.BackColor = Color.FromArgb(192, 255, 255);
            Boton9.Location = new Point(127, 97);
            Boton9.Name = "Boton9";
            Boton9.Size = new Size(53, 38);
            Boton9.TabIndex = 8;
            Boton9.Text = "9";
            Boton9.UseVisualStyleBackColor = false;
            Boton9.Click += Boton9_Click;
            // 
            // Boton8
            // 
            Boton8.BackColor = Color.FromArgb(192, 255, 255);
            Boton8.Location = new Point(68, 97);
            Boton8.Name = "Boton8";
            Boton8.Size = new Size(53, 38);
            Boton8.TabIndex = 7;
            Boton8.Text = "8";
            Boton8.UseVisualStyleBackColor = false;
            Boton8.Click += Boton8_Click;
            // 
            // Boton7
            // 
            Boton7.BackColor = Color.FromArgb(192, 255, 255);
            Boton7.Location = new Point(9, 97);
            Boton7.Name = "Boton7";
            Boton7.Size = new Size(53, 38);
            Boton7.TabIndex = 6;
            Boton7.Text = " 7";
            Boton7.UseVisualStyleBackColor = false;
            Boton7.Click += Boton7_Click;
            // 
            // BotonPotencia
            // 
            BotonPotencia.BackColor = Color.FromArgb(255, 224, 192);
            BotonPotencia.Location = new Point(186, 141);
            BotonPotencia.Name = "BotonPotencia";
            BotonPotencia.Size = new Size(53, 38);
            BotonPotencia.TabIndex = 13;
            BotonPotencia.Text = "^";
            BotonPotencia.UseVisualStyleBackColor = false;
            BotonPotencia.Click += BotonPotencia_Click;
            // 
            // Boton6
            // 
            Boton6.BackColor = Color.FromArgb(192, 255, 255);
            Boton6.Location = new Point(127, 141);
            Boton6.Name = "Boton6";
            Boton6.Size = new Size(53, 38);
            Boton6.TabIndex = 12;
            Boton6.Text = "6";
            Boton6.UseVisualStyleBackColor = false;
            Boton6.Click += Boton6_Click;
            // 
            // Boton5
            // 
            Boton5.BackColor = Color.FromArgb(192, 255, 255);
            Boton5.Location = new Point(68, 141);
            Boton5.Name = "Boton5";
            Boton5.Size = new Size(53, 38);
            Boton5.TabIndex = 11;
            Boton5.Text = "5";
            Boton5.UseVisualStyleBackColor = false;
            Boton5.Click += Boton5_Click;
            // 
            // Boton4
            // 
            Boton4.BackColor = Color.FromArgb(192, 255, 255);
            Boton4.Location = new Point(9, 141);
            Boton4.Name = "Boton4";
            Boton4.Size = new Size(53, 38);
            Boton4.TabIndex = 10;
            Boton4.Text = "4";
            Boton4.UseVisualStyleBackColor = false;
            Boton4.Click += Boton4_Click;
            // 
            // BotonIgual
            // 
            BotonIgual.BackColor = Color.FromArgb(255, 255, 192);
            BotonIgual.Location = new Point(186, 185);
            BotonIgual.Name = "BotonIgual";
            BotonIgual.Size = new Size(53, 82);
            BotonIgual.TabIndex = 17;
            BotonIgual.Text = "=";
            BotonIgual.UseVisualStyleBackColor = false;
            BotonIgual.Click += BotonIgual_Click;
            // 
            // Boton3
            // 
            Boton3.BackColor = Color.FromArgb(192, 255, 255);
            Boton3.Location = new Point(127, 185);
            Boton3.Name = "Boton3";
            Boton3.Size = new Size(53, 38);
            Boton3.TabIndex = 16;
            Boton3.Text = "3";
            Boton3.UseVisualStyleBackColor = false;
            Boton3.Click += Boton3_Click;
            // 
            // Boton2
            // 
            Boton2.BackColor = Color.FromArgb(192, 255, 255);
            Boton2.Location = new Point(68, 185);
            Boton2.Name = "Boton2";
            Boton2.Size = new Size(53, 38);
            Boton2.TabIndex = 15;
            Boton2.Text = "2";
            Boton2.UseVisualStyleBackColor = false;
            Boton2.Click += Boton2_Click;
            // 
            // Boton1
            // 
            Boton1.BackColor = Color.FromArgb(192, 255, 255);
            Boton1.Location = new Point(9, 185);
            Boton1.Name = "Boton1";
            Boton1.Size = new Size(53, 38);
            Boton1.TabIndex = 14;
            Boton1.Text = "1";
            Boton1.UseVisualStyleBackColor = false;
            Boton1.Click += Boton1_Click;
            // 
            // BotonComa
            // 
            BotonComa.BackColor = Color.FromArgb(255, 224, 192);
            BotonComa.Location = new Point(127, 229);
            BotonComa.Name = "BotonComa";
            BotonComa.Size = new Size(53, 38);
            BotonComa.TabIndex = 20;
            BotonComa.Text = ",";
            BotonComa.UseVisualStyleBackColor = false;
            BotonComa.Click += BotonComa_Click;
            // 
            // Boton0
            // 
            Boton0.BackColor = Color.FromArgb(192, 255, 255);
            Boton0.Location = new Point(9, 229);
            Boton0.Name = "Boton0";
            Boton0.Size = new Size(112, 38);
            Boton0.TabIndex = 19;
            Boton0.Text = "0";
            Boton0.UseVisualStyleBackColor = false;
            Boton0.Click += Boton0_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(252, 271);
            Controls.Add(BotonComa);
            Controls.Add(Boton0);
            Controls.Add(BotonIgual);
            Controls.Add(Boton3);
            Controls.Add(Boton2);
            Controls.Add(Boton1);
            Controls.Add(BotonPotencia);
            Controls.Add(Boton6);
            Controls.Add(Boton5);
            Controls.Add(Boton4);
            Controls.Add(BotonSumar);
            Controls.Add(Boton9);
            Controls.Add(Boton8);
            Controls.Add(Boton7);
            Controls.Add(BotonRestar);
            Controls.Add(BotonMult);
            Controls.Add(BotonDiv);
            Controls.Add(BotonCE);
            Controls.Add(Pantalla);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Pantalla;
        private Button BotonCE;
        private Button BotonDiv;
        private Button BotonMult;
        private Button BotonRestar;
        private Button BotonSumar;
        private Button Boton9;
        private Button Boton8;
        private Button Boton7;
        private Button BotonPotencia;
        private Button Boton6;
        private Button Boton5;
        private Button Boton4;
        private Button BotonIgual;
        private Button Boton3;
        private Button Boton2;
        private Button Boton1;
        private Button BotonComa;
        private Button Boton0;
    }
}