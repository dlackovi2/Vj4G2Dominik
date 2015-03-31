namespace WindowsFormsApplication1
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIspis = new System.Windows.Forms.Label();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(57, 45);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(23, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "ime";
            this.lblIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(38, 67);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(43, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "prezime";
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(38, 99);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(28, 13);
            this.lblIspis.TabIndex = 2;
            this.lblIspis.Text = "Ispis";
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(150, 42);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(100, 20);
            this.txtime.TabIndex = 3;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(150, 69);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(100, 20);
            this.txtprezime.TabIndex = 4;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(150, 99);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(100, 20);
            this.txtIspis.TabIndex = 5;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(150, 175);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 6;
            this.btnIspisi.Text = "Ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnIspisi;
    }
}

