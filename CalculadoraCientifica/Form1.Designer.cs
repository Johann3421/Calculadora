namespace CalculadoraCientifica
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
            lblhistorial = new Label();
            btndos = new Button();
            btntres = new Button();
            btnseis = new Button();
            btncinco = new Button();
            btncuatro = new Button();
            btnnueve = new Button();
            btnocho = new Button();
            btnsiete = new Button();
            btnuno = new Button();
            btnCero = new Button();
            btnpunto = new Button();
            btnmultiplicar = new Button();
            btnresta = new Button();
            btnsuma = new Button();
            btnigual = new Button();
            btnmodulo = new Button();
            btnDivision = new Button();
            btnReset = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // cajaResultado
            // 
            cajaResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cajaResultado.Location = new Point(22, 30);
            cajaResultado.Name = "cajaResultado";
            cajaResultado.Size = new Size(344, 35);
            cajaResultado.TabIndex = 20;
            cajaResultado.Text = "0";
            cajaResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhistorial
            // 
            lblhistorial.AutoSize = true;
            lblhistorial.Location = new Point(22, 13);
            lblhistorial.Name = "lblhistorial";
            lblhistorial.Size = new Size(0, 15);
            lblhistorial.TabIndex = 21;
            // 
            // btndos
            // 
            btndos.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndos.Location = new Point(127, 239);
            btndos.Name = "btndos";
            btndos.Size = new Size(47, 40);
            btndos.TabIndex = 22;
            btndos.Text = "2";
            btndos.UseVisualStyleBackColor = true;
            btndos.Click += button2_Click;
            // 
            // btntres
            // 
            btntres.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btntres.Location = new Point(197, 239);
            btntres.Name = "btntres";
            btntres.Size = new Size(47, 40);
            btntres.TabIndex = 23;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = true;
            // 
            // btnseis
            // 
            btnseis.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnseis.Location = new Point(197, 181);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(47, 40);
            btnseis.TabIndex = 26;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = true;
            // 
            // btncinco
            // 
            btncinco.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncinco.Location = new Point(127, 181);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(47, 40);
            btncinco.TabIndex = 25;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = true;
            // 
            // btncuatro
            // 
            btncuatro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncuatro.Location = new Point(63, 181);
            btncuatro.Name = "btncuatro";
            btncuatro.Size = new Size(47, 40);
            btncuatro.TabIndex = 24;
            btncuatro.Text = "4";
            btncuatro.UseVisualStyleBackColor = true;
            // 
            // btnnueve
            // 
            btnnueve.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnnueve.Location = new Point(197, 122);
            btnnueve.Name = "btnnueve";
            btnnueve.Size = new Size(47, 40);
            btnnueve.TabIndex = 29;
            btnnueve.Text = "9";
            btnnueve.UseVisualStyleBackColor = true;
            // 
            // btnocho
            // 
            btnocho.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnocho.Location = new Point(127, 121);
            btnocho.Name = "btnocho";
            btnocho.Size = new Size(47, 40);
            btnocho.TabIndex = 28;
            btnocho.Text = "8";
            btnocho.UseVisualStyleBackColor = true;
            btnocho.Click += btnocho_Click;
            // 
            // btnsiete
            // 
            btnsiete.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsiete.Location = new Point(63, 122);
            btnsiete.Name = "btnsiete";
            btnsiete.Size = new Size(47, 40);
            btnsiete.TabIndex = 27;
            btnsiete.Text = "7";
            btnsiete.UseVisualStyleBackColor = true;
            // 
            // btnuno
            // 
            btnuno.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnuno.Location = new Point(63, 239);
            btnuno.Name = "btnuno";
            btnuno.Size = new Size(47, 40);
            btnuno.TabIndex = 0;
            btnuno.Text = "1";
            btnuno.UseVisualStyleBackColor = true;
            btnuno.Click += button1_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCero.Location = new Point(63, 292);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(111, 40);
            btnCero.TabIndex = 30;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += button10_Click;
            // 
            // btnpunto
            // 
            btnpunto.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpunto.Location = new Point(197, 292);
            btnpunto.Name = "btnpunto";
            btnpunto.Size = new Size(47, 40);
            btnpunto.TabIndex = 31;
            btnpunto.Text = ".";
            btnpunto.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmultiplicar.Location = new Point(262, 122);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(47, 40);
            btnmultiplicar.TabIndex = 32;
            btnmultiplicar.Text = "X";
            btnmultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            btnresta.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnresta.Location = new Point(262, 181);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(47, 40);
            btnresta.TabIndex = 33;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = true;
            // 
            // btnsuma
            // 
            btnsuma.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsuma.Location = new Point(262, 239);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(47, 40);
            btnsuma.TabIndex = 34;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnigual
            // 
            btnigual.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnigual.Location = new Point(262, 292);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(47, 40);
            btnigual.TabIndex = 35;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            // 
            // btnmodulo
            // 
            btnmodulo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodulo.Location = new Point(63, 71);
            btnmodulo.Name = "btnmodulo";
            btnmodulo.Size = new Size(47, 40);
            btnmodulo.TabIndex = 36;
            btnmodulo.Text = "%";
            btnmodulo.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.Location = new Point(127, 71);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(47, 40);
            btnDivision.TabIndex = 37;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(197, 71);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(47, 40);
            btnReset.TabIndex = 38;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(262, 71);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(47, 40);
            btnBorrar.TabIndex = 39;
            btnBorrar.Text = "<";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 355);
            Controls.Add(btnBorrar);
            Controls.Add(btnReset);
            Controls.Add(btnDivision);
            Controls.Add(btnmodulo);
            Controls.Add(btnigual);
            Controls.Add(btnsuma);
            Controls.Add(btnresta);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnpunto);
            Controls.Add(btnCero);
            Controls.Add(btnnueve);
            Controls.Add(btnocho);
            Controls.Add(btnsiete);
            Controls.Add(btnseis);
            Controls.Add(btncinco);
            Controls.Add(btncuatro);
            Controls.Add(btntres);
            Controls.Add(btndos);
            Controls.Add(lblhistorial);
            Controls.Add(cajaResultado);
            Controls.Add(btnuno);
            Name = "Form1";
            Text = "CalculadoraV1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox cajaResultado;
        private Label lblhistorial;
        private Button btndos;
        private Button btntres;
        private Button btnseis;
        private Button btncinco;
        private Button btncuatro;
        private Button btnnueve;
        private Button btnocho;
        private Button btnsiete;
        private Button btnuno;
        private Button btnCero;
        private Button btnpunto;
        private Button btnmultiplicar;
        private Button btnresta;
        private Button btnsuma;
        private Button btnigual;
        private Button btnmodulo;
        private Button btnDivision;
        private Button btnReset;
        private Button btnBorrar;
    }
}