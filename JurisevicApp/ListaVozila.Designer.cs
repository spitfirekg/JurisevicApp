namespace JurisevicApp
{
    partial class ListaVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaVozila));
            this.dgListaVozila = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaVozila
            // 
            this.dgListaVozila.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.dgListaVozila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListaVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaVozila.Location = new System.Drawing.Point(12, 59);
            this.dgListaVozila.Name = "dgListaVozila";
            this.dgListaVozila.RowHeadersWidth = 51;
            this.dgListaVozila.RowTemplate.Height = 24;
            this.dgListaVozila.Size = new System.Drawing.Size(1878, 962);
            this.dgListaVozila.TabIndex = 0;
            this.dgListaVozila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaVozila_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA SVIH VOZILA IZ BAZE PODATAKA";
            // 
            // ListaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListaVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Servis Jurišević - Lista vozila";
            this.Load += new System.EventHandler(this.ListaVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaVozila;
        private System.Windows.Forms.Label label1;
    }
}