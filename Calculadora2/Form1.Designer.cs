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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            SuspendLayout();
            // 
            // cajaResultado
            // 
            cajaResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cajaResultado.Location = new Point(23, 22);
            cajaResultado.Name = "cajaResultado";
            cajaResultado.ReadOnly = true;
            cajaResultado.Size = new Size(230, 35);
            cajaResultado.TabIndex = 0;
            cajaResultado.Text = "0";
            cajaResultado.TextAlign = HorizontalAlignment.Right;
            cajaResultado.TextChanged += cajaResultado_TextChanged;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(36, 6);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.RightToLeft = RightToLeft.No;
            lblHistorial.Size = new Size(0, 15);
            lblHistorial.TabIndex = 1;
            // 
            // btnuno
            // 
            btnuno.BackColor = Color.Black;
            btnuno.FlatAppearance.BorderColor = Color.Black;
            btnuno.FlatStyle = FlatStyle.Flat;
            btnuno.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnuno.ForeColor = Color.White;
            btnuno.Location = new Point(23, 435);
            btnuno.Name = "btnuno";
            btnuno.Size = new Size(53, 54);
            btnuno.TabIndex = 2;
            btnuno.Text = "1";
            btnuno.UseVisualStyleBackColor = false;
            btnuno.Click += btnuno_Click;
            // 
            // btndos
            // 
            btndos.BackColor = Color.Black;
            btndos.FlatAppearance.BorderColor = Color.Black;
            btndos.FlatStyle = FlatStyle.Flat;
            btndos.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndos.ForeColor = Color.White;
            btndos.Location = new Point(82, 435);
            btndos.Name = "btndos";
            btndos.Size = new Size(53, 54);
            btndos.TabIndex = 3;
            btndos.Text = "2";
            btndos.UseVisualStyleBackColor = false;
            btndos.Click += btndos_Click;
            // 
            // btntres
            // 
            btntres.BackColor = Color.Black;
            btntres.FlatAppearance.BorderColor = Color.Black;
            btntres.FlatStyle = FlatStyle.Flat;
            btntres.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btntres.ForeColor = Color.White;
            btntres.Location = new Point(141, 435);
            btntres.Name = "btntres";
            btntres.Size = new Size(53, 54);
            btntres.TabIndex = 4;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = false;
            btntres.Click += btntres_Click;
            // 
            // btnseis
            // 
            btnseis.BackColor = Color.Black;
            btnseis.FlatAppearance.BorderColor = Color.Black;
            btnseis.FlatStyle = FlatStyle.Flat;
            btnseis.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnseis.ForeColor = Color.White;
            btnseis.Location = new Point(141, 375);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(53, 54);
            btnseis.TabIndex = 7;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = false;
            btnseis.Click += btnseis_Click;
            // 
            // btncinco
            // 
            btncinco.BackColor = Color.Black;
            btncinco.FlatAppearance.BorderColor = Color.Black;
            btncinco.FlatStyle = FlatStyle.Flat;
            btncinco.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncinco.ForeColor = Color.White;
            btncinco.Location = new Point(82, 375);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(53, 54);
            btncinco.TabIndex = 6;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = false;
            btncinco.Click += btncinco_Click;
            // 
            // btncuatro
            // 
            btncuatro.BackColor = Color.Black;
            btncuatro.FlatAppearance.BorderColor = Color.Black;
            btncuatro.FlatStyle = FlatStyle.Flat;
            btncuatro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncuatro.ForeColor = Color.White;
            btncuatro.Location = new Point(23, 375);
            btncuatro.Name = "btncuatro";
            btncuatro.Size = new Size(53, 54);
            btncuatro.TabIndex = 5;
            btncuatro.Text = "4";
            btncuatro.UseVisualStyleBackColor = false;
            btncuatro.Click += btncuatro_Click;
            // 
            // btnnueve
            // 
            btnnueve.BackColor = Color.Black;
            btnnueve.FlatAppearance.BorderColor = Color.Black;
            btnnueve.FlatStyle = FlatStyle.Flat;
            btnnueve.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnnueve.ForeColor = Color.White;
            btnnueve.Location = new Point(141, 315);
            btnnueve.Name = "btnnueve";
            btnnueve.Size = new Size(53, 54);
            btnnueve.TabIndex = 10;
            btnnueve.Text = "9";
            btnnueve.UseVisualStyleBackColor = false;
            btnnueve.Click += btnnueve_Click;
            // 
            // btnocho
            // 
            btnocho.BackColor = Color.Black;
            btnocho.FlatAppearance.BorderColor = Color.Black;
            btnocho.FlatStyle = FlatStyle.Flat;
            btnocho.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnocho.ForeColor = Color.White;
            btnocho.Location = new Point(82, 315);
            btnocho.Name = "btnocho";
            btnocho.Size = new Size(53, 54);
            btnocho.TabIndex = 9;
            btnocho.Text = "8";
            btnocho.UseVisualStyleBackColor = false;
            btnocho.Click += btnocho_Click;
            // 
            // btnsiete
            // 
            btnsiete.BackColor = Color.Black;
            btnsiete.FlatAppearance.BorderColor = Color.Black;
            btnsiete.FlatStyle = FlatStyle.Flat;
            btnsiete.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsiete.ForeColor = Color.White;
            btnsiete.Location = new Point(23, 315);
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
            btnReset.Location = new Point(82, 255);
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
            btnDivision.Location = new Point(200, 255);
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
            btnModulo.Location = new Point(23, 196);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(43, 35);
            btnModulo.TabIndex = 11;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = false;
            btnModulo.Click += btnModulo_Click;
            // 
            // btncero
            // 
            btncero.BackColor = Color.Black;
            btncero.FlatAppearance.BorderColor = Color.Black;
            btncero.FlatStyle = FlatStyle.Flat;
            btncero.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncero.ForeColor = Color.White;
            btncero.Location = new Point(82, 495);
            btncero.Name = "btncero";
            btncero.Size = new Size(53, 54);
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
            btnpunto.Location = new Point(141, 495);
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
            btnresultado.Location = new Point(200, 495);
            btnresultado.Name = "btnresultado";
            btnresultado.Size = new Size(53, 54);
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
            btnBorrar.Location = new Point(141, 255);
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
            btnmultiplicar.Location = new Point(200, 315);
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
            btnresta.Location = new Point(200, 375);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(53, 54);
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
            btnsuma.Location = new Point(200, 435);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(53, 54);
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
            button1.Location = new Point(82, 196);
            button1.Name = "button1";
            button1.Size = new Size(43, 35);
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
            potencia.Location = new Point(141, 196);
            potencia.Name = "potencia";
            potencia.Size = new Size(43, 35);
            potencia.TabIndex = 22;
            potencia.Text = "X^2";
            potencia.UseVisualStyleBackColor = false;
            potencia.Click += potencia_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(200, 114);
            button2.Name = "button2";
            button2.Size = new Size(43, 35);
            button2.TabIndex = 30;
            button2.Text = "π";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(200, 155);
            button3.Name = "button3";
            button3.Size = new Size(43, 35);
            button3.TabIndex = 29;
            button3.Text = "Log";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(141, 114);
            button4.Name = "button4";
            button4.Size = new Size(43, 35);
            button4.TabIndex = 28;
            button4.Text = "Exp";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(82, 114);
            button5.Name = "button5";
            button5.Size = new Size(43, 35);
            button5.TabIndex = 27;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(23, 114);
            button6.Name = "button6";
            button6.Size = new Size(43, 35);
            button6.TabIndex = 26;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(141, 155);
            button7.Name = "button7";
            button7.Size = new Size(43, 35);
            button7.TabIndex = 25;
            button7.Text = "Tan";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(64, 64, 64);
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(82, 155);
            button8.Name = "button8";
            button8.Size = new Size(43, 35);
            button8.TabIndex = 24;
            button8.Text = "Cos";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(64, 64, 64);
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(23, 155);
            button9.Name = "button9";
            button9.Size = new Size(43, 35);
            button9.TabIndex = 23;
            button9.Text = "Sin";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(64, 64, 64);
            button10.FlatAppearance.BorderColor = Color.Black;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(210, 63);
            button10.Name = "button10";
            button10.Size = new Size(43, 41);
            button10.TabIndex = 33;
            button10.Text = "MS";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(64, 64, 64);
            button11.FlatAppearance.BorderColor = Color.Black;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(151, 63);
            button11.Name = "button11";
            button11.Size = new Size(43, 41);
            button11.TabIndex = 32;
            button11.Text = "MR";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(64, 64, 64);
            button12.FlatAppearance.BorderColor = Color.Black;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(92, 63);
            button12.Name = "button12";
            button12.Size = new Size(43, 41);
            button12.TabIndex = 31;
            button12.Text = "MC";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(64, 64, 64);
            button13.FlatAppearance.BorderColor = Color.Black;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Location = new Point(200, 196);
            button13.Name = "button13";
            button13.Size = new Size(43, 35);
            button13.TabIndex = 34;
            button13.Text = "1/x";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(64, 64, 64);
            button14.FlatAppearance.BorderColor = Color.Black;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.White;
            button14.Location = new Point(23, 495);
            button14.Name = "button14";
            button14.Size = new Size(53, 54);
            button14.TabIndex = 35;
            button14.Text = "+/-";
            button14.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(277, 571);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}