namespace JurisevicApp
{
    partial class ListaServisaPoDatumu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaServisaPoDatumu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgZaDatum = new System.Windows.Forms.DataGridView();
            this.btZaDatumPdf = new System.Windows.Forms.Button();
            this.labelUkupno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgZaDatum1 = new System.Windows.Forms.DataGridView();
            this.btZaDatum1 = new System.Windows.Forms.Button();
            this.dtZaDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaDatum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaDatum1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTA SERVISA ZA ODABRANI DATUM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.dgZaDatum);
            this.panel1.Controls.Add(this.btZaDatumPdf);
            this.panel1.Controls.Add(this.labelUkupno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgZaDatum1);
            this.panel1.Controls.Add(this.btZaDatum1);
            this.panel1.Controls.Add(this.dtZaDatum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1878, 973);
            this.panel1.TabIndex = 4;
            // 
            // dgZaDatum
            // 
            this.dgZaDatum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.dgZaDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgZaDatum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZaDatum.Location = new System.Drawing.Point(26, 66);
            this.dgZaDatum.Name = "dgZaDatum";
            this.dgZaDatum.RowHeadersWidth = 51;
            this.dgZaDatum.RowTemplate.Height = 24;
            this.dgZaDatum.Size = new System.Drawing.Size(1828, 770);
            this.dgZaDatum.TabIndex = 11;
            // 
            // btZaDatumPdf
            // 
            this.btZaDatumPdf.BackColor = System.Drawing.Color.RoyalBlue;
            this.btZaDatumPdf.FlatAppearance.BorderSize = 0;
            this.btZaDatumPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btZaDatumPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZaDatumPdf.ForeColor = System.Drawing.Color.White;
            this.btZaDatumPdf.Location = new System.Drawing.Point(1675, 867);
            this.btZaDatumPdf.Name = "btZaDatumPdf";
            this.btZaDatumPdf.Size = new System.Drawing.Size(179, 37);
            this.btZaDatumPdf.TabIndex = 10;
            this.btZaDatumPdf.Text = "Sačuvaj PDF";
            this.btZaDatumPdf.UseVisualStyleBackColor = false;
            this.btZaDatumPdf.Click += new System.EventHandler(this.btZaDatumPdf_Click);
            // 
            // labelUkupno
            // 
            this.labelUkupno.AutoSize = true;
            this.labelUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUkupno.ForeColor = System.Drawing.Color.Red;
            this.labelUkupno.Location = new System.Drawing.Point(1670, 839);
            this.labelUkupno.Name = "labelUkupno";
            this.labelUkupno.Size = new System.Drawing.Size(70, 25);
            this.labelUkupno.TabIndex = 9;
            this.labelUkupno.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(1548, 839);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "UKUPNO :";
            // 
            // dgZaDatum1
            // 
            this.dgZaDatum1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.dgZaDatum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgZaDatum1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgZaDatum1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZaDatum1.Location = new System.Drawing.Point(26, 66);
            this.dgZaDatum1.Name = "dgZaDatum1";
            this.dgZaDatum1.ReadOnly = true;
            this.dgZaDatum1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgZaDatum1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgZaDatum1.RowTemplate.Height = 24;
            this.dgZaDatum1.Size = new System.Drawing.Size(1828, 770);
            this.dgZaDatum1.TabIndex = 7;
            // 
            // btZaDatum1
            // 
            this.btZaDatum1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btZaDatum1.FlatAppearance.BorderSize = 0;
            this.btZaDatum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btZaDatum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZaDatum1.ForeColor = System.Drawing.Color.White;
            this.btZaDatum1.Location = new System.Drawing.Point(407, 22);
            this.btZaDatum1.Name = "btZaDatum1";
            this.btZaDatum1.Size = new System.Drawing.Size(215, 32);
            this.btZaDatum1.TabIndex = 6;
            this.btZaDatum1.Text = "Pretraga";
            this.btZaDatum1.UseVisualStyleBackColor = false;
            this.btZaDatum1.Click += new System.EventHandler(this.btZaDatum1_Click);
            // 
            // dtZaDatum
            // 
            this.dtZaDatum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtZaDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtZaDatum.Location = new System.Drawing.Point(278, 26);
            this.dtZaDatum.Name = "dtZaDatum";
            this.dtZaDatum.Size = new System.Drawing.Size(112, 22);
            this.dtZaDatum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ODABERITE DATUM : ";
            // 
            // ListaServisaPoDatumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaServisaPoDatumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto servis Jurišević - Lista servisa po datumu";
            this.Load += new System.EventHandler(this.ListaServisaPoDatumu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaDatum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaDatum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btZaDatum1;
        private System.Windows.Forms.DateTimePicker dtZaDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgZaDatum1;
        private System.Windows.Forms.Label labelUkupno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btZaDatumPdf;
        private System.Windows.Forms.DataGridView dgZaDatum;
    }
}