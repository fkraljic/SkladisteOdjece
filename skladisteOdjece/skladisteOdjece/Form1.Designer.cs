namespace skladisteOdjece
{
    partial class Izbornik
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
            this.buttonStanjeSkladista = new System.Windows.Forms.Button();
            this.buttonEvidencija = new System.Windows.Forms.Button();
            this.buttonZaprimljeneN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAsortiman = new System.Windows.Forms.Button();
            this.buttonVelicine = new System.Windows.Forms.Button();
            this.buttonDodavanjeNaSkl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStanjeSkladista
            // 
            this.buttonStanjeSkladista.Location = new System.Drawing.Point(120, 64);
            this.buttonStanjeSkladista.Name = "buttonStanjeSkladista";
            this.buttonStanjeSkladista.Size = new System.Drawing.Size(161, 54);
            this.buttonStanjeSkladista.TabIndex = 1;
            this.buttonStanjeSkladista.Text = "Stanje skladišta";
            this.buttonStanjeSkladista.UseVisualStyleBackColor = true;
            this.buttonStanjeSkladista.Click += new System.EventHandler(this.buttonStanjeSkladista_Click);
            // 
            // buttonEvidencija
            // 
            this.buttonEvidencija.Location = new System.Drawing.Point(120, 184);
            this.buttonEvidencija.Name = "buttonEvidencija";
            this.buttonEvidencija.Size = new System.Drawing.Size(161, 54);
            this.buttonEvidencija.TabIndex = 2;
            this.buttonEvidencija.Text = "Evidencija promjene skladišta";
            this.buttonEvidencija.UseVisualStyleBackColor = true;
            this.buttonEvidencija.Click += new System.EventHandler(this.buttonEvidencija_Click);
            // 
            // buttonZaprimljeneN
            // 
            this.buttonZaprimljeneN.Location = new System.Drawing.Point(120, 244);
            this.buttonZaprimljeneN.Name = "buttonZaprimljeneN";
            this.buttonZaprimljeneN.Size = new System.Drawing.Size(161, 54);
            this.buttonZaprimljeneN.TabIndex = 3;
            this.buttonZaprimljeneN.Text = "Zaprimljene narudžbe";
            this.buttonZaprimljeneN.UseVisualStyleBackColor = true;
            this.buttonZaprimljeneN.Click += new System.EventHandler(this.buttonZaprimljeneN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Narudžbe u dolasku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAsortiman
            // 
            this.buttonAsortiman.Location = new System.Drawing.Point(120, 364);
            this.buttonAsortiman.Name = "buttonAsortiman";
            this.buttonAsortiman.Size = new System.Drawing.Size(161, 54);
            this.buttonAsortiman.TabIndex = 5;
            this.buttonAsortiman.Text = "Asortiman";
            this.buttonAsortiman.UseVisualStyleBackColor = true;
            this.buttonAsortiman.Click += new System.EventHandler(this.buttonAsortiman_Click);
            // 
            // buttonVelicine
            // 
            this.buttonVelicine.Location = new System.Drawing.Point(120, 424);
            this.buttonVelicine.Name = "buttonVelicine";
            this.buttonVelicine.Size = new System.Drawing.Size(161, 54);
            this.buttonVelicine.TabIndex = 6;
            this.buttonVelicine.Text = "Veličine";
            this.buttonVelicine.UseVisualStyleBackColor = true;
            this.buttonVelicine.Click += new System.EventHandler(this.buttonVelicine_Click);
            // 
            // buttonDodavanjeNaSkl
            // 
            this.buttonDodavanjeNaSkl.Location = new System.Drawing.Point(120, 124);
            this.buttonDodavanjeNaSkl.Name = "buttonDodavanjeNaSkl";
            this.buttonDodavanjeNaSkl.Size = new System.Drawing.Size(161, 54);
            this.buttonDodavanjeNaSkl.TabIndex = 7;
            this.buttonDodavanjeNaSkl.Text = "Dodavanje na skladište";
            this.buttonDodavanjeNaSkl.UseVisualStyleBackColor = true;
            this.buttonDodavanjeNaSkl.Click += new System.EventHandler(this.buttonDodavanjeNaSkl_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 538);
            this.Controls.Add(this.buttonDodavanjeNaSkl);
            this.Controls.Add(this.buttonVelicine);
            this.Controls.Add(this.buttonAsortiman);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonZaprimljeneN);
            this.Controls.Add(this.buttonEvidencija);
            this.Controls.Add(this.buttonStanjeSkladista);
            this.Name = "Izbornik";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Izbornik_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStanjeSkladista;
        private System.Windows.Forms.Button buttonEvidencija;
        private System.Windows.Forms.Button buttonZaprimljeneN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAsortiman;
        private System.Windows.Forms.Button buttonVelicine;
        private System.Windows.Forms.Button buttonDodavanjeNaSkl;
    }
}

