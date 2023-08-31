namespace Calculadora2
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
            cajaResultado = new TextBox();
            lblHistorial = new Label();
            btnuno = new Button();
            btndos = new Button();
            btntres = new Button();
            btnseis = new Button();
            btncinco = new Button();
            btncuatro = new Button();
            btnnueve = new Button();
            btnocho = new Button();
            btnsiete = new Button();
            btnReset = new Button();
            btnDivision = new Button();
            btnModulo = new Button();
            btncero = new Button();
            btnpunto = new Button();
            btnresultado = new Button();
            btnBorrar = new Button();
            btnmultiplicar = new Button();
            btnresta = new Button();
            btnsuma = new Button();
            button1 = new Button();
            potencia = new Button();
            SuspendLayout();
            // 
            // cajaResultado
            // 
            cajaResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cajaResultado.Location = new Point(35, 37);
            cajaResultado.Name = "cajaResultado";
            cajaResultado.ReadOnly = true;
            cajaResultado.Size = new Size(348, 35);
            cajaResultado.TabIndex = 0;
            cajaResultado.Text = "0";
            cajaResultado.TextAlign = HorizontalAlignment.Right;
            cajaResultado.TextChanged += cajaResultado_TextChanged;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(35, 16);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.RightToLeft = RightToLeft.No;
            lblHistorial.Size = new Size(0, 15);
            lblHistorial.TabIndex = 1;
            // 
            // btnuno
            // 
            btnuno.BackColor = Color.FromArgb(64, 64, 64);
            btnuno.FlatAppearance.BorderColor = Color.Black;
            btnuno.FlatStyle = FlatStyle.Flat;
            btnuno.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnuno.ForeColor = Color.White;
            btnuno.Location = new Point(35, 269);
            btnuno.Name = "btnuno";
            btnuno.Size = new Size(53, 54);
            btnuno.TabIndex = 2;
            btnuno.Text = "1";
            btnuno.UseVisualStyleBackColor = false;
            btnuno.Click += btnuno_Click;
            // 
            // btndos
            // 
            btndos.BackColor = Color.FromArgb(64, 64, 64);
            btndos.FlatAppearance.BorderColor = Color.Black;
            btndos.FlatStyle = FlatStyle.Flat;
            btndos.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndos.ForeColor = Color.White;
            btndos.Location = new Point(94, 269);
            btndos.Name = "btndos";
            btndos.Size = new Size(53, 54);
            btndos.TabIndex = 3;
            btndos.Text = "2";
            btndos.UseVisualStyleBackColor = false;
            btndos.Click += btndos_Click;
            // 
            // btntres
            // 
            btntres.BackColor = Color.FromArgb(64, 64, 64);
            btntres.FlatAppearance.BorderColor = Color.Black;
            btntres.FlatStyle = FlatStyle.Flat;
            btntres.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btntres.ForeColor = Color.White;
            btntres.Location = new Point(153, 269);
            btntres.Name = "btntres";
            btntres.Size = new Size(53, 54);
            btntres.TabIndex = 4;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = false;
            btntres.Click += btntres_Click;
            // 
            // btnseis
            // 
            btnseis.BackColor = Color.FromArgb(64, 64, 64);
            btnseis.FlatAppearance.BorderColor = Color.Black;
            btnseis.FlatStyle = FlatStyle.Flat;
            btnseis.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnseis.ForeColor = Color.White;
            btnseis.Location = new Point(153, 209);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(53, 54);
            btnseis.TabIndex = 7;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = false;
            btnseis.Click += btnseis_Click;
            // 
            // btncinco
            // 
            btncinco.BackColor = Color.FromArgb(64, 64, 64);
            btncinco.FlatAppearance.BorderColor = Color.Black;
            btncinco.FlatStyle = FlatStyle.Flat;
            btncinco.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncinco.ForeColor = Color.White;
            btncinco.Location = new Point(94, 209);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(53, 54);
            btncinco.TabIndex = 6;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = false;
            btncinco.Click += btncinco_Click;
            // 
            // btncuatro
            // 
            btncuatro.BackColor = Color.FromArgb(64, 64, 64);
            btncuatro.FlatAppearance.BorderColor = Color.Black;
            btncuatro.FlatStyle = FlatStyle.Flat;
            btncuatro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncuatro.ForeColor = Color.White;
            btncuatro.Location = new Point(35, 209);
            btncuatro.Name = "btncuatro";
            btncuatro.Size = new Size(53, 54);
            btncuatro.TabIndex = 5;
            btncuatro.Text = "4";
            btncuatro.UseVisualStyleBackColor = false;
            btncuatro.Click += btncuatro_Click;
            // 
            // btnnueve
            // 
            btnnueve.BackColor = Color.FromArgb(64, 64, 64);
            btnnueve.FlatAppearance.BorderColor = Color.Black;
            btnnueve.FlatStyle = FlatStyle.Flat;
            btnnueve.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnnueve.ForeColor = Color.White;
            btnnueve.Location = new Point(153, 149);
            btnnueve.Name = "btnnueve";
            btnnueve.Size = new Size(53, 54);
            btnnueve.TabIndex = 10;
            btnnueve.Text = "9";
            btnnueve.UseVisualStyleBackColor = false;
            btnnueve.Click += btnnueve_Click;
            // 
            // btnocho
            // 
            btnocho.BackColor = Color.FromArgb(64, 64, 64);
            btnocho.FlatAppearance.BorderColor = Color.Black;
            btnocho.FlatStyle = FlatStyle.Flat;
            btnocho.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnocho.ForeColor = Color.White;
            btnocho.Location = new Point(94, 149);
            btnocho.Name = "btnocho";
            btnocho.Size = new Size(53, 54);
            btnocho.TabIndex = 9;
            btnocho.Text = "8";
            btnocho.UseVisualStyleBackColor = false;
            btnocho.Click += btnocho_Click;
            // 
            // btnsiete
            // 
            btnsiete.BackColor = Color.FromArgb(64, 64, 64);
            btnsiete.FlatAppearance.BorderColor = Color.Black;
            btnsiete.FlatStyle = FlatStyle.Flat;
            btnsiete.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsiete.ForeColor = Color.White;
            btnsiete.Location = new Point(35, 149);
            btnsiete.Name = "btnsiete";
            btnsiete.Size = new Size(53, 54);
            btnsiete.TabIndex = 8;
            btnsiete.Text = "7";
            btnsiete.UseVisualStyleBackColor = false;
            btnsiete.Click += btnsiete_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(64, 64, 64);
            btnReset.FlatAppearance.BorderColor = Color.Black;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(153, 89);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(53, 54);
            btnReset.TabIndex = 13;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(64, 64, 64);
            btnDivision.FlatAppearance.BorderColor = Color.Black;
            btnDivision.FlatStyle = FlatStyle.Flat;
            btnDivision.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.ForeColor = Color.White;
            btnDivision.Location = new Point(94, 89);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(53, 54);
            btnDivision.TabIndex = 12;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnModulo
            // 
            btnModulo.BackColor = Color.FromArgb(64, 64, 64);
            btnModulo.FlatAppearance.BorderColor = Color.Black;
            btnModulo.FlatStyle = FlatStyle.Flat;
            btnModulo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModulo.ForeColor = Color.White;
            btnModulo.Location = new Point(35, 89);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(53, 54);
            btnModulo.TabIndex = 11;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = false;
            btnModulo.Click += btnModulo_Click;
            // 
            // btncero
            // 
            btncero.BackColor = Color.FromArgb(64, 64, 64);
            btncero.FlatAppearance.BorderColor = Color.Black;
            btncero.FlatStyle = FlatStyle.Flat;
            btncero.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncero.ForeColor = Color.White;
            btncero.Location = new Point(35, 329);
            btncero.Name = "btncero";
            btncero.Size = new Size(112, 54);
            btncero.TabIndex = 14;
            btncero.Text = "0";
            btncero.UseVisualStyleBackColor = false;
            btncero.Click += btncero_Click;
            // 
            // btnpunto
            // 
            btnpunto.BackColor = Color.FromArgb(64, 64, 64);
            btnpunto.FlatAppearance.BorderColor = Color.Black;
            btnpunto.FlatStyle = FlatStyle.Flat;
            btnpunto.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpunto.ForeColor = Color.White;
            btnpunto.Location = new Point(153, 329);
            btnpunto.Name = "btnpunto";
            btnpunto.Size = new Size(53, 54);
            btnpunto.TabIndex = 15;
            btnpunto.Text = ".";
            btnpunto.UseVisualStyleBackColor = false;
            btnpunto.Click += btnpunto_Click;
            // 
            // btnresultado
            // 
            btnresultado.BackColor = Color.FromArgb(64, 64, 64);
            btnresultado.FlatAppearance.BorderColor = Color.Black;
            btnresultado.FlatStyle = FlatStyle.Flat;
            btnresultado.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnresultado.ForeColor = Color.White;
            btnresultado.Location = new Point(212, 329);
            btnresultado.Name = "btnresultado";
            btnresultado.Size = new Size(171, 54);
            btnresultado.TabIndex = 20;
            btnresultado.Text = "=";
            btnresultado.UseVisualStyleBackColor = false;
            btnresultado.Click += btnresultado_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(64, 64, 64);
            btnBorrar.FlatAppearance.BorderColor = Color.Black;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(212, 89);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(53, 54);
            btnBorrar.TabIndex = 19;
            btnBorrar.Text = "<";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.BackColor = Color.FromArgb(64, 64, 64);
            btnmultiplicar.FlatAppearance.BorderColor = Color.Black;
            btnmultiplicar.FlatStyle = FlatStyle.Flat;
            btnmultiplicar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmultiplicar.ForeColor = Color.White;
            btnmultiplicar.Location = new Point(212, 149);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(53, 54);
            btnmultiplicar.TabIndex = 18;
            btnmultiplicar.Text = "X";
            btnmultiplicar.UseVisualStyleBackColor = false;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btnresta
            // 
            btnresta.BackColor = Color.FromArgb(64, 64, 64);
            btnresta.FlatAppearance.BorderColor = Color.Black;
            btnresta.FlatStyle = FlatStyle.Flat;
            btnresta.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnresta.ForeColor = Color.White;
            btnresta.Location = new Point(212, 209);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(171, 54);
            btnresta.TabIndex = 17;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += btnresta_Click;
            // 
            // btnsuma
            // 
            btnsuma.BackColor = Color.FromArgb(64, 64, 64);
            btnsuma.FlatAppearance.BorderColor = Color.Black;
            btnsuma.FlatStyle = FlatStyle.Flat;
            btnsuma.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsuma.ForeColor = Color.White;
            btnsuma.Location = new Point(212, 269);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(171, 54);
            btnsuma.TabIndex = 16;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += btnsuma_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(271, 89);
            button1.Name = "button1";
            button1.Size = new Size(112, 54);
            button1.TabIndex = 21;
            button1.Text = "√";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // potencia
            // 
            potencia.BackColor = Color.FromArgb(64, 64, 64);
            potencia.FlatAppearance.BorderColor = Color.Black;
            potencia.FlatStyle = FlatStyle.Flat;
            potencia.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            potencia.ForeColor = Color.White;
            potencia.Location = new Point(271, 149);
            potencia.Name = "potencia";
            potencia.Size = new Size(112, 54);
            potencia.TabIndex = 22;
            potencia.Text = "X^2";
            potencia.UseVisualStyleBackColor = false;
            potencia.Click += potencia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(407, 413);
            Controls.Add(potencia);
            Controls.Add(button1);
            Controls.Add(btnresultado);
            Controls.Add(btnBorrar);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnresta);
            Controls.Add(btnsuma);
            Controls.Add(btnpunto);
            Controls.Add(btncero);
            Controls.Add(btnReset);
            Controls.Add(btnDivision);
            Controls.Add(btnModulo);
            Controls.Add(btnnueve);
            Controls.Add(btnocho);
            Controls.Add(btnsiete);
            Controls.Add(btnseis);
            Controls.Add(btncinco);
            Controls.Add(btncuatro);
            Controls.Add(btntres);
            Controls.Add(btndos);
            Controls.Add(btnuno);
            Controls.Add(lblHistorial);
            Controls.Add(cajaResultado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cajaResultado;
        private Label lblHistorial;
        private Button btnuno;
        private Button btndos;
        private Button btntres;
        private Button btnseis;
        private Button btncinco;
        private Button btncuatro;
        private Button btnnueve;
        private Button btnocho;
        private Button btnsiete;
        private Button btnReset;
        private Button btnDivision;
        private Button btnModulo;
        private Button btncero;
        private Button btnpunto;
        private Button btnresultado;
        private Button btnBorrar;
        private Button btnmultiplicar;
        private Button btnresta;
        private Button btnsuma;
        private Button button1;
        private Button potencia;
    }
}