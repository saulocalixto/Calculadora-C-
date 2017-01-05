namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt7
            // 
            this.bt7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(31, 81);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(50, 50);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // bt8
            // 
            this.bt8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(96, 81);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(50, 50);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // bt9
            // 
            this.bt9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(161, 81);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(50, 50);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // soma
            // 
            this.soma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.soma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.soma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(223, 81);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(50, 50);
            this.soma.TabIndex = 4;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.operadores);
            // 
            // subtracao
            // 
            this.subtracao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subtracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(223, 146);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(50, 50);
            this.subtracao.TabIndex = 8;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.operadores);
            // 
            // bt6
            // 
            this.bt6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(161, 146);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(50, 50);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // bt5
            // 
            this.bt5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(96, 146);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(50, 50);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // bt4
            // 
            this.bt4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(31, 146);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(50, 50);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // divide
            // 
            this.divide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(223, 215);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 12;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operadores);
            // 
            // bt3
            // 
            this.bt3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(161, 215);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(50, 50);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // bt2
            // 
            this.bt2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(96, 215);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(50, 50);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // bt1
            // 
            this.bt1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(31, 215);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(50, 50);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // multi
            // 
            this.multi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.multi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(223, 282);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(50, 50);
            this.multi.TabIndex = 16;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.operadores);
            // 
            // igual
            // 
            this.igual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.igual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(161, 282);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(50, 50);
            this.igual.TabIndex = 15;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // bt0
            // 
            this.bt0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(96, 282);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(50, 50);
            this.bt0.TabIndex = 14;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.mostrarVisor);
            // 
            // limpar
            // 
            this.limpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(31, 282);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(50, 50);
            this.limpar.TabIndex = 13;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(31, 26);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(243, 20);
            this.txtResult.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 353);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.MaskedTextBox txtResult;
    }
}

