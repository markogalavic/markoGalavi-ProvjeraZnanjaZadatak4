namespace markoGalavićProvjeraZnanjaZadatak4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Broj = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.smjer = new System.Windows.Forms.ComboBox();
            this.Snimi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(41, 37);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(188, 20);
            this.ime.TabIndex = 2;
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(44, 125);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(185, 20);
            this.prezime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj indeksa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum rođenja";
            // 
            // Broj
            // 
            this.Broj.Location = new System.Drawing.Point(511, 36);
            this.Broj.Name = "Broj";
            this.Broj.Size = new System.Drawing.Size(196, 20);
            this.Broj.TabIndex = 6;
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(514, 124);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(193, 20);
            this.Datum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Smjer:";
            // 
            // smjer
            // 
            this.smjer.FormattingEnabled = true;
            this.smjer.Location = new System.Drawing.Point(44, 239);
            this.smjer.Name = "smjer";
            this.smjer.Size = new System.Drawing.Size(185, 21);
            this.smjer.TabIndex = 9;
            // 
            // Snimi
            // 
            this.Snimi.Location = new System.Drawing.Point(73, 326);
            this.Snimi.Name = "Snimi";
            this.Snimi.Size = new System.Drawing.Size(117, 29);
            this.Snimi.TabIndex = 10;
            this.Snimi.Text = "Snimi";
            this.Snimi.UseVisualStyleBackColor = true;
            this.Snimi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Otkaži";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Snimi);
            this.Controls.Add(this.smjer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.Broj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Unos novog studenta";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Broj;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox smjer;
        private System.Windows.Forms.Button Snimi;
        private System.Windows.Forms.Button button2;
    }
}