namespace CALCULADORA2
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
            this.resultado = new System.Windows.Forms.TextBox();
            this.siete = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resultado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(16, 50);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(397, 26);
            this.resultado.TabIndex = 0;
            this.resultado.Text = "0";
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // siete
            // 
            this.siete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siete.Location = new System.Drawing.Point(16, 79);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(75, 42);
            this.siete.TabIndex = 1;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // ocho
            // 
            this.ocho.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ocho.Location = new System.Drawing.Point(97, 79);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(75, 42);
            this.ocho.TabIndex = 2;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // nueve
            // 
            this.nueve.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nueve.Location = new System.Drawing.Point(178, 79);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(75, 42);
            this.nueve.TabIndex = 3;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dividir.Location = new System.Drawing.Point(259, 79);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 42);
            this.dividir.TabIndex = 4;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CE.Location = new System.Drawing.Point(338, 79);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(75, 42);
            this.CE.TabIndex = 5;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(338, 127);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 42);
            this.C.TabIndex = 10;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplicar.Location = new System.Drawing.Point(259, 127);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(75, 42);
            this.multiplicar.TabIndex = 9;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // seis
            // 
            this.seis.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seis.Location = new System.Drawing.Point(178, 127);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(75, 42);
            this.seis.TabIndex = 8;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cinco.Location = new System.Drawing.Point(97, 127);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(75, 42);
            this.cinco.TabIndex = 7;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // cuatro
            // 
            this.cuatro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cuatro.Location = new System.Drawing.Point(16, 127);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(75, 42);
            this.cuatro.TabIndex = 6;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resta.Location = new System.Drawing.Point(259, 175);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(75, 42);
            this.resta.TabIndex = 14;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // tres
            // 
            this.tres.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tres.Location = new System.Drawing.Point(178, 175);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(75, 42);
            this.tres.TabIndex = 13;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // dos
            // 
            this.dos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dos.Location = new System.Drawing.Point(97, 175);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(75, 42);
            this.dos.TabIndex = 12;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // uno
            // 
            this.uno.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uno.Location = new System.Drawing.Point(16, 175);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(75, 42);
            this.uno.TabIndex = 11;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // punto
            // 
            this.punto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.punto.Location = new System.Drawing.Point(178, 223);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(75, 42);
            this.punto.TabIndex = 15;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // cero
            // 
            this.cero.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cero.Location = new System.Drawing.Point(16, 223);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(156, 42);
            this.cero.TabIndex = 17;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(259, 223);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 42);
            this.suma.TabIndex = 20;
            this.suma.Text = "+";
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(338, 176);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 89);
            this.igual.TabIndex = 19;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Historial
            // 
            this.Historial.AutoSize = true;
            this.Historial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Historial.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Historial.Location = new System.Drawing.Point(16, 9);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(49, 38);
            this.Historial.TabIndex = 21;
            this.Historial.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 273);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.C);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.resultado);
            this.Name = "Form1";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox resultado;
        private Button siete;
        private Button ocho;
        private Button nueve;
        private Button dividir;
        private Button CE;
        private Button C;
        private Button multiplicar;
        private Button seis;
        private Button cinco;
        private Button cuatro;
        private Button resta;
        private Button tres;
        private Button dos;
        private Button uno;
        private Button punto;
        private Button cero;
        private Button suma;
        private Button igual;
        private Label Historial;
    }
}