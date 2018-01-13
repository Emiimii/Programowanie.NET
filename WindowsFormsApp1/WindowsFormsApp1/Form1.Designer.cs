namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.bMnozenie = new System.Windows.Forms.Button();
            this.bUsunOst = new System.Windows.Forms.Button();
            this.bUsun = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.bRowne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(10, 196);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(61, 56);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(77, 196);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(61, 56);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(144, 196);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(61, 56);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(10, 134);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(61, 56);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(77, 134);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(61, 56);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(144, 134);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(61, 56);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button6_Click);
            this.b6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.b6_KeyPress);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(10, 72);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(61, 56);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(77, 72);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(61, 56);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(144, 72);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(61, 56);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button9_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(10, 258);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(61, 56);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(77, 258);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(61, 56);
            this.bDot.TabIndex = 11;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            // 
            // bDodawanie
            // 
            this.bDodawanie.Location = new System.Drawing.Point(211, 72);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(61, 56);
            this.bDodawanie.TabIndex = 12;
            this.bDodawanie.Text = "+";
            this.bDodawanie.UseVisualStyleBackColor = true;
            this.bDodawanie.Click += new System.EventHandler(this.bDodawanie_Click);
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.Location = new System.Drawing.Point(211, 134);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(61, 56);
            this.bOdejmowanie.TabIndex = 13;
            this.bOdejmowanie.Text = "-";
            this.bOdejmowanie.UseVisualStyleBackColor = true;
            this.bOdejmowanie.Click += new System.EventHandler(this.bOdejmowanie_Click);
            // 
            // bMnozenie
            // 
            this.bMnozenie.Location = new System.Drawing.Point(211, 196);
            this.bMnozenie.Name = "bMnozenie";
            this.bMnozenie.Size = new System.Drawing.Size(61, 56);
            this.bMnozenie.TabIndex = 14;
            this.bMnozenie.Text = "*";
            this.bMnozenie.UseVisualStyleBackColor = true;
            this.bMnozenie.Click += new System.EventHandler(this.bMnozenie_Click);
            // 
            // bUsunOst
            // 
            this.bUsunOst.Location = new System.Drawing.Point(277, 134);
            this.bUsunOst.Name = "bUsunOst";
            this.bUsunOst.Size = new System.Drawing.Size(61, 56);
            this.bUsunOst.TabIndex = 15;
            this.bUsunOst.Text = "CE";
            this.bUsunOst.UseVisualStyleBackColor = true;
            this.bUsunOst.Click += new System.EventHandler(this.button15_Click);
            // 
            // bUsun
            // 
            this.bUsun.Location = new System.Drawing.Point(278, 72);
            this.bUsun.Name = "bUsun";
            this.bUsun.Size = new System.Drawing.Size(60, 56);
            this.bUsun.TabIndex = 17;
            this.bUsun.Text = "C";
            this.bUsun.UseVisualStyleBackColor = true;
            // 
            // bDzielenie
            // 
            this.bDzielenie.Location = new System.Drawing.Point(211, 258);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(61, 56);
            this.bDzielenie.TabIndex = 18;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = true;
            this.bDzielenie.Click += new System.EventHandler(this.bDzielenie_Click);
            // 
            // bRowne
            // 
            this.bRowne.Location = new System.Drawing.Point(144, 258);
            this.bRowne.Name = "bRowne";
            this.bRowne.Size = new System.Drawing.Size(61, 56);
            this.bRowne.TabIndex = 19;
            this.bRowne.Text = "=";
            this.bRowne.UseVisualStyleBackColor = true;
            this.bRowne.Click += new System.EventHandler(this.bRowne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 383);
            this.Controls.Add(this.bRowne);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.bUsun);
            this.Controls.Add(this.bUsunOst);
            this.Controls.Add(this.bMnozenie);
            this.Controls.Add(this.bOdejmowanie);
            this.Controls.Add(this.bDodawanie);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bDodawanie;
        private System.Windows.Forms.Button bOdejmowanie;
        private System.Windows.Forms.Button bMnozenie;
        private System.Windows.Forms.Button bUsunOst;
        private System.Windows.Forms.Button bUsun;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button bRowne;
    }
}

