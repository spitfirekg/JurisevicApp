namespace JurisevicApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btHome = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNovo = new System.Windows.Forms.PictureBox();
            this.adminPanel21 = new JurisevicApp.AdminPanel2();
            this.searchPanelNovo = new JurisevicApp.SearchPanel1();
            this.addPanelNovo = new JurisevicApp.AddPanel1();
            this.searchPanel12 = new JurisevicApp.SearchPanel1();
            this.searchPanel11 = new JurisevicApp.SearchPanel1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1033);
            this.panel1.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 472);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(255, 77);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Administracija";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 395);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(255, 77);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "Pretraga";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 318);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(255, 77);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Dodaj vozilo";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btHome
            // 
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            this.btHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 241);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(255, 77);
            this.btHome.TabIndex = 3;
            this.btHome.Text = "Početna";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(255, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1647, 120);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1647, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxNovo
            // 
            this.pictureBoxNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxNovo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNovo.Image")));
            this.pictureBoxNovo.Location = new System.Drawing.Point(255, 120);
            this.pictureBoxNovo.Name = "pictureBoxNovo";
            this.pictureBoxNovo.Size = new System.Drawing.Size(1647, 913);
            this.pictureBoxNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNovo.TabIndex = 2;
            this.pictureBoxNovo.TabStop = false;
            // 
            // adminPanel21
            // 
            this.adminPanel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(126)))), ((int)(((byte)(166)))));
            this.adminPanel21.Location = new System.Drawing.Point(276, 127);
            this.adminPanel21.Name = "adminPanel21";
            this.adminPanel21.Size = new System.Drawing.Size(1626, 842);
            this.adminPanel21.TabIndex = 7;
            this.adminPanel21.Load += new System.EventHandler(this.adminPanel21_Load);
            // 
            // searchPanelNovo
            // 
            this.searchPanelNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(126)))), ((int)(((byte)(166)))));
            this.searchPanelNovo.Location = new System.Drawing.Point(276, 126);
            this.searchPanelNovo.Name = "searchPanelNovo";
            this.searchPanelNovo.Size = new System.Drawing.Size(1626, 843);
            this.searchPanelNovo.TabIndex = 6;
            // 
            // addPanelNovo
            // 
            this.addPanelNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(126)))), ((int)(((byte)(166)))));
            this.addPanelNovo.Location = new System.Drawing.Point(276, 126);
            this.addPanelNovo.Name = "addPanelNovo";
            this.addPanelNovo.Size = new System.Drawing.Size(1626, 843);
            this.addPanelNovo.TabIndex = 3;
            // 
            // searchPanel12
            // 
            this.searchPanel12.BackColor = System.Drawing.Color.Red;
            this.searchPanel12.Location = new System.Drawing.Point(276, 143);
            this.searchPanel12.Name = "searchPanel12";
            this.searchPanel12.Size = new System.Drawing.Size(1663, 913);
            this.searchPanel12.TabIndex = 4;
            this.searchPanel12.Load += new System.EventHandler(this.searchPanel12_Load);
            // 
            // searchPanel11
            // 
            this.searchPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(126)))), ((int)(((byte)(166)))));
            this.searchPanel11.Location = new System.Drawing.Point(285, 144);
            this.searchPanel11.Name = "searchPanel11";
            this.searchPanel11.Size = new System.Drawing.Size(1605, 822);
            this.searchPanel11.TabIndex = 4;
            this.searchPanel11.Load += new System.EventHandler(this.searchPanel11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.adminPanel21);
            this.Controls.Add(this.searchPanelNovo);
            this.Controls.Add(this.addPanelNovo);
            this.Controls.Add(this.pictureBoxNovo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto servis - Jurišević";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNovo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btHome;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBoxNovo;
        private AddPanel1 addPanelNovo;
        private SearchPanel1 searchPanel11;
        private SearchPanel1 searchPanel12;
       // private AdministratotPanel administratotPanelNovo;
        private SearchPanel1 searchPanelNovo;
        private AdminPanel2 adminPanel21;
        // private adminPnaleNovi1 adminPnaleNovi11;
        // private AdminPanel1 adminPanel11;
    }
}

