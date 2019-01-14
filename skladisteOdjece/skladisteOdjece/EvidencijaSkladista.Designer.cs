namespace skladisteOdjece
{
    partial class EvidencijaSkladista
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            this.dateTimePickerVoD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVdO = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 565);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evidencija ulaza i izlaza s skladišta";
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.Location = new System.Drawing.Point(42, 54);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.Size = new System.Drawing.Size(157, 22);
            this.dateTimePickerOd.TabIndex = 2;
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.Location = new System.Drawing.Point(41, 82);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.Size = new System.Drawing.Size(158, 22);
            this.dateTimePickerDo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do";
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(346, 54);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(87, 50);
            this.buttonPretrazi.TabIndex = 6;
            this.buttonPretrazi.Text = "Traži";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // dateTimePickerVoD
            // 
            this.dateTimePickerVoD.Location = new System.Drawing.Point(205, 54);
            this.dateTimePickerVoD.Name = "dateTimePickerVoD";
            this.dateTimePickerVoD.Size = new System.Drawing.Size(135, 22);
            this.dateTimePickerVoD.TabIndex = 7;
            this.dateTimePickerVoD.Value = new System.DateTime(2019, 1, 14, 22, 40, 0, 0);
            // 
            // dateTimePickerVdO
            // 
            this.dateTimePickerVdO.Location = new System.Drawing.Point(205, 82);
            this.dateTimePickerVdO.Name = "dateTimePickerVdO";
            this.dateTimePickerVdO.Size = new System.Drawing.Size(135, 22);
            this.dateTimePickerVdO.TabIndex = 8;
            this.dateTimePickerVdO.Value = new System.DateTime(2019, 1, 14, 22, 40, 0, 0);
            // 
            // EvidencijaSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1224, 687);
            this.Controls.Add(this.dateTimePickerVdO);
            this.Controls.Add(this.dateTimePickerVoD);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDo);
            this.Controls.Add(this.dateTimePickerOd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1242, 734);
            this.MinimumSize = new System.Drawing.Size(1242, 734);
            this.Name = "EvidencijaSkladista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija skladišta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPretrazi;
        private System.Windows.Forms.DateTimePicker dateTimePickerVoD;
        private System.Windows.Forms.DateTimePicker dateTimePickerVdO;
    }
}