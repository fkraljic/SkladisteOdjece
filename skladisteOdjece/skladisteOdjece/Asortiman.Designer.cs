namespace skladisteOdjece
{
    partial class Asortiman
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
            this.buttonDodajO = new System.Windows.Forms.Button();
            this.buttonIzmjeniO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 603);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // buttonDodajO
            // 
            this.buttonDodajO.Location = new System.Drawing.Point(12, 70);
            this.buttonDodajO.Name = "buttonDodajO";
            this.buttonDodajO.Size = new System.Drawing.Size(113, 62);
            this.buttonDodajO.TabIndex = 1;
            this.buttonDodajO.Text = "Dodaj";
            this.buttonDodajO.UseVisualStyleBackColor = true;
            this.buttonDodajO.Click += new System.EventHandler(this.buttonDodajO_Click);
            // 
            // buttonIzmjeniO
            // 
            this.buttonIzmjeniO.Location = new System.Drawing.Point(12, 138);
            this.buttonIzmjeniO.Name = "buttonIzmjeniO";
            this.buttonIzmjeniO.Size = new System.Drawing.Size(113, 62);
            this.buttonIzmjeniO.TabIndex = 2;
            this.buttonIzmjeniO.Text = "Izmjeni";
            this.buttonIzmjeniO.UseVisualStyleBackColor = true;
            this.buttonIzmjeniO.Click += new System.EventHandler(this.buttonIzmjeniO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unos i izmjena asortimana";
            // 
            // Asortiman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1179, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIzmjeniO);
            this.Controls.Add(this.buttonDodajO);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1197, 732);
            this.MinimumSize = new System.Drawing.Size(1197, 732);
            this.Name = "Asortiman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asortiman";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodajO;
        private System.Windows.Forms.Button buttonIzmjeniO;
        private System.Windows.Forms.Label label1;
    }
}