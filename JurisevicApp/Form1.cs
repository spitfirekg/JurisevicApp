using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurisevicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBoxNovo.Show();
            addPanelNovo.Hide();
            searchPanelNovo.Hide();
            adminPanel21.Hide();
            
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            adminPanel21.Hide();
            searchPanel11.Hide();
            addPanelNovo.Hide();
            pictureBoxNovo.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            adminPanel21.Hide();
            searchPanelNovo.Hide();
            addPanelNovo.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            adminPanel21.Hide();
            addPanelNovo.Hide();
            searchPanelNovo.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            addPanelNovo.Hide();
            searchPanelNovo.Hide();
            adminPanel21.Show();
        }

        private void searchPanel11_Load(object sender, EventArgs e)
        {

        }

        private void searchPanel12_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void adminPanel21_Load(object sender, EventArgs e)
        {

        }
    }
}
