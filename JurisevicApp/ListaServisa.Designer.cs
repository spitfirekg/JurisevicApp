﻿namespace JurisevicApp
{
    partial class ListaServisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaServisa));
            this.dgListaServisa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaServisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaServisa
            // 
            this.dgListaServisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.dgListaServisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListaServisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaServisa.Location = new System.Drawing.Point(12, 59);
            this.dgListaServisa.Name = "dgListaServisa";
            this.dgListaServisa.RowHeadersWidth = 51;
            this.dgListaServisa.RowTemplate.Height = 24;
            this.dgListaServisa.Size = new System.Drawing.Size(1878, 962);
            this.dgListaServisa.TabIndex = 0;
            this.dgListaServisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaServisa_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA SVIH SERVISA IZ BAZE PODATAKA";
            // 
            // ListaServisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListaServisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaServisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Servis Jurišević - Lista servisa";
            this.Load += new System.EventHandler(this.ListaServisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaServisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaServisa;
        private System.Windows.Forms.Label label1;
    }
}