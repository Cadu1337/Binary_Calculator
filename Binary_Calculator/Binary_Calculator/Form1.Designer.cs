namespace Binary_Calculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Conta = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BinárioDecimal = new System.Windows.Forms.TextBox();
            this.HexadecimalDecimal = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Resultado);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Conta);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculadora Binária";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Resultado:";
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(65, 159);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valores:";
            // 
            // Conta
            // 
            this.Conta.Location = new System.Drawing.Point(65, 31);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(100, 20);
            this.Conta.TabIndex = 10;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(238, 156);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 9;
            this.button12.Text = "<----";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(319, 156);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 8;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(279, 113);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "=";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Igual);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(319, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Multiplicação);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(238, 65);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "/";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Divisão);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(319, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Subtração);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Soma);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Botão_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Botão_0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.HexadecimalDecimal);
            this.tabPage2.Controls.Add(this.BinárioDecimal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = " Hexadecimal para Decimal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.HexacimalParaDecimal);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Binário para Decimal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BinárioParaDecimal);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coversor de HexaDecimal para Decimal ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conversor Binária/Decimal";
            // 
            // BinárioDecimal
            // 
            this.BinárioDecimal.Location = new System.Drawing.Point(22, 74);
            this.BinárioDecimal.Name = "BinárioDecimal";
            this.BinárioDecimal.Size = new System.Drawing.Size(130, 20);
            this.BinárioDecimal.TabIndex = 0;
            // 
            // HexadecimalDecimal
            // 
            this.HexadecimalDecimal.Location = new System.Drawing.Point(260, 74);
            this.HexadecimalDecimal.Name = "HexadecimalDecimal";
            this.HexadecimalDecimal.Size = new System.Drawing.Size(115, 20);
            this.HexadecimalDecimal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Binary Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BinárioDecimal;
        private System.Windows.Forms.TextBox Conta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HexadecimalDecimal;
    }
}

