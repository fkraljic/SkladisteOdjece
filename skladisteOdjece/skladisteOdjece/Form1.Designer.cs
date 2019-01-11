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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonStanjeSkladista = new System.Windows.Forms.Button();
            this.buttonEvidencija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(117, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonStanjeSkladista
            // 
            this.buttonStanjeSkladista.Location = new System.Drawing.Point(324, 79);
            this.buttonStanjeSkladista.Name = "buttonStanjeSkladista";
            this.buttonStanjeSkladista.Size = new System.Drawing.Size(161, 54);
            this.buttonStanjeSkladista.TabIndex = 1;
            this.buttonStanjeSkladista.Text = "Stanje skladišta";
            this.buttonStanjeSkladista.UseVisualStyleBackColor = true;
            this.buttonStanjeSkladista.Click += new System.EventHandler(this.buttonStanjeSkladista_Click);
            // 
            // buttonEvidencija
            // 
            this.buttonEvidencija.Location = new System.Drawing.Point(324, 139);
            this.buttonEvidencija.Name = "buttonEvidencija";
            this.buttonEvidencija.Size = new System.Drawing.Size(161, 54);
            this.buttonEvidencija.TabIndex = 2;
            this.buttonEvidencija.Text = "Evidencija promjene skladišta";
            this.buttonEvidencija.UseVisualStyleBackColor = true;
            this.buttonEvidencija.Click += new System.EventHandler(this.buttonEvidencija_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEvidencija);
            this.Controls.Add(this.buttonStanjeSkladista);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Izbornik";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Izbornik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonStanjeSkladista;
        private System.Windows.Forms.Button buttonEvidencija;
    }
}

