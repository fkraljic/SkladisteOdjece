namespace skladisteOdjece
{
    partial class DostupneVelicineOdjece
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
            this.dataGridViewOdjeca = new System.Windows.Forms.DataGridView();
            this.dataGridViewVelicine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.dataGridViewVelicineOdjece = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdjeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicineOdjece)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOdjeca
            // 
            this.dataGridViewOdjeca.AllowUserToAddRows = false;
            this.dataGridViewOdjeca.AllowUserToDeleteRows = false;
            this.dataGridViewOdjeca.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewOdjeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdjeca.Location = new System.Drawing.Point(591, 73);
            this.dataGridViewOdjeca.MultiSelect = false;
            this.dataGridViewOdjeca.Name = "dataGridViewOdjeca";
            this.dataGridViewOdjeca.ReadOnly = true;
            this.dataGridViewOdjeca.RowTemplate.Height = 24;
            this.dataGridViewOdjeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOdjeca.Size = new System.Drawing.Size(786, 501);
            this.dataGridViewOdjeca.TabIndex = 0;
            this.dataGridViewOdjeca.SelectionChanged += new System.EventHandler(this.dataGridViewOdjeca_SelectionChanged);
            // 
            // dataGridViewVelicine
            // 
            this.dataGridViewVelicine.AllowUserToAddRows = false;
            this.dataGridViewVelicine.AllowUserToDeleteRows = false;
            this.dataGridViewVelicine.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewVelicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVelicine.Location = new System.Drawing.Point(126, 73);
            this.dataGridViewVelicine.MultiSelect = false;
            this.dataGridViewVelicine.Name = "dataGridViewVelicine";
            this.dataGridViewVelicine.ReadOnly = true;
            this.dataGridViewVelicine.RowTemplate.Height = 24;
            this.dataGridViewVelicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVelicine.Size = new System.Drawing.Size(459, 501);
            this.dataGridViewVelicine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veličine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asortiman";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 73);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(108, 501);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // dataGridViewVelicineOdjece
            // 
            this.dataGridViewVelicineOdjece.AllowUserToAddRows = false;
            this.dataGridViewVelicineOdjece.AllowUserToDeleteRows = false;
            this.dataGridViewVelicineOdjece.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewVelicineOdjece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVelicineOdjece.Location = new System.Drawing.Point(591, 580);
            this.dataGridViewVelicineOdjece.MultiSelect = false;
            this.dataGridViewVelicineOdjece.Name = "dataGridViewVelicineOdjece";
            this.dataGridViewVelicineOdjece.ReadOnly = true;
            this.dataGridViewVelicineOdjece.RowTemplate.Height = 24;
            this.dataGridViewVelicineOdjece.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVelicineOdjece.Size = new System.Drawing.Size(786, 213);
            this.dataGridViewVelicineOdjece.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Određivanje dostupnih veličina odjeće";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(1248, 45);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(129, 22);
            this.textBoxFilter.TabIndex = 7;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1150, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oznaka filter:";
            // 
            // DostupneVelicineOdjece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1389, 804);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewVelicineOdjece);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVelicine);
            this.Controls.Add(this.dataGridViewOdjeca);
            this.MaximumSize = new System.Drawing.Size(1407, 851);
            this.MinimumSize = new System.Drawing.Size(1407, 851);
            this.Name = "DostupneVelicineOdjece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dostupne velićine odjeće";
            this.Load += new System.EventHandler(this.DostupneVelicineOdjece_Load);
            this.Leave += new System.EventHandler(this.DostupneVelicineOdjece_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdjeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicineOdjece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOdjeca;
        private System.Windows.Forms.DataGridView dataGridViewVelicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridView dataGridViewVelicineOdjece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label4;
    }
}