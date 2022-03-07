namespace vježbaZaTest1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.vrsta = new System.Windows.Forms.ComboBox();
            this.txtVrsta = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.GodProd = new System.Windows.Forms.DateTimePicker();
            this.lblGodprod = new System.Windows.Forms.Label();
            this.lblAero = new System.Windows.Forms.Label();
            this.chkDa = new System.Windows.Forms.CheckBox();
            this.chkNe = new System.Windows.Forms.CheckBox();
            this.lblBrzina = new System.Windows.Forms.Label();
            this.trckBrzina = new System.Windows.Forms.TrackBar();
            this.btnUpis = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrzina)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(197, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 310);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // vrsta
            // 
            this.vrsta.FormattingEnabled = true;
            this.vrsta.Items.AddRange(new object[] {
            "Avion",
            "Helikopter"});
            this.vrsta.Location = new System.Drawing.Point(15, 58);
            this.vrsta.Name = "vrsta";
            this.vrsta.Size = new System.Drawing.Size(121, 21);
            this.vrsta.TabIndex = 1;
            // 
            // txtVrsta
            // 
            this.txtVrsta.AutoSize = true;
            this.txtVrsta.Location = new System.Drawing.Point(12, 42);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(89, 13);
            this.txtVrsta.TabIndex = 2;
            this.txtVrsta.Text = "Vrsta zrakoplova:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 106);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(82, 13);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime zrakoplova:";
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(15, 122);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(118, 20);
            this.txbIme.TabIndex = 4;
            // 
            // GodProd
            // 
            this.GodProd.Location = new System.Drawing.Point(14, 192);
            this.GodProd.Name = "GodProd";
            this.GodProd.Size = new System.Drawing.Size(152, 20);
            this.GodProd.TabIndex = 5;
            // 
            // lblGodprod
            // 
            this.lblGodprod.AutoSize = true;
            this.lblGodprod.Location = new System.Drawing.Point(11, 166);
            this.lblGodprod.Name = "lblGodprod";
            this.lblGodprod.Size = new System.Drawing.Size(90, 13);
            this.lblGodprod.TabIndex = 6;
            this.lblGodprod.Text = "God. proizvodnje:";
            // 
            // lblAero
            // 
            this.lblAero.AutoSize = true;
            this.lblAero.Location = new System.Drawing.Point(12, 231);
            this.lblAero.Name = "lblAero";
            this.lblAero.Size = new System.Drawing.Size(77, 13);
            this.lblAero.TabIndex = 7;
            this.lblAero.Text = "Aerodinamika?";
            // 
            // chkDa
            // 
            this.chkDa.AutoSize = true;
            this.chkDa.Location = new System.Drawing.Point(13, 262);
            this.chkDa.Name = "chkDa";
            this.chkDa.Size = new System.Drawing.Size(40, 17);
            this.chkDa.TabIndex = 8;
            this.chkDa.Text = "Da";
            this.chkDa.UseVisualStyleBackColor = true;
            // 
            // chkNe
            // 
            this.chkNe.AutoSize = true;
            this.chkNe.Location = new System.Drawing.Point(13, 295);
            this.chkNe.Name = "chkNe";
            this.chkNe.Size = new System.Drawing.Size(40, 17);
            this.chkNe.TabIndex = 9;
            this.chkNe.Text = "Ne";
            this.chkNe.UseVisualStyleBackColor = true;
            // 
            // lblBrzina
            // 
            this.lblBrzina.AutoSize = true;
            this.lblBrzina.Location = new System.Drawing.Point(414, 373);
            this.lblBrzina.Name = "lblBrzina";
            this.lblBrzina.Size = new System.Drawing.Size(39, 13);
            this.lblBrzina.TabIndex = 10;
            this.lblBrzina.Text = "Brzina:";
            // 
            // trckBrzina
            // 
            this.trckBrzina.LargeChange = 10;
            this.trckBrzina.Location = new System.Drawing.Point(281, 400);
            this.trckBrzina.Maximum = 400;
            this.trckBrzina.Minimum = 60;
            this.trckBrzina.Name = "trckBrzina";
            this.trckBrzina.Size = new System.Drawing.Size(311, 45);
            this.trckBrzina.SmallChange = 10;
            this.trckBrzina.TabIndex = 11;
            this.trckBrzina.Value = 60;
            // 
            // btnUpis
            // 
            this.btnUpis.Location = new System.Drawing.Point(716, 42);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(220, 123);
            this.btnUpis.TabIndex = 12;
            this.btnUpis.Text = "Upisi";
            this.btnUpis.UseVisualStyleBackColor = true;
            this.btnUpis.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(716, 214);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(220, 129);
            this.btnIspis.TabIndex = 13;
            this.btnIspis.Text = "Ispisi";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 521);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUpis);
            this.Controls.Add(this.trckBrzina);
            this.Controls.Add(this.lblBrzina);
            this.Controls.Add(this.chkNe);
            this.Controls.Add(this.chkDa);
            this.Controls.Add(this.lblAero);
            this.Controls.Add(this.lblGodprod);
            this.Controls.Add(this.GodProd);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.vrsta);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckBrzina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox vrsta;
        private System.Windows.Forms.Label txtVrsta;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.DateTimePicker GodProd;
        private System.Windows.Forms.Label lblGodprod;
        private System.Windows.Forms.Label lblAero;
        private System.Windows.Forms.CheckBox chkDa;
        private System.Windows.Forms.CheckBox chkNe;
        private System.Windows.Forms.Label lblBrzina;
        private System.Windows.Forms.TrackBar trckBrzina;
        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.Button btnIspis;
    }
}

