using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurisevicApp
{
    public partial class ListaServisa : Form
    {
        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = JurisevicAppDb.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        public ListaServisa()
        {
            InitializeComponent();
        }
        //Prikaz svih servisa iz baze podataka
        private void ListaServisa_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM servis";

            try
            {
                conn.Open();
                com = new SQLiteCommand(selectQuery,conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgListaServisa.DataSource = dt;

                dgListaServisa.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaServisa.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaServisa.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaServisa.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaServisa.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaServisa.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaServisa.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaServisa.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgListaServisa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgListaServisa.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgListaServisa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgListaServisa.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5F, GraphicsUnit.Pixel);

                dgListaServisa.Columns[0].Width = 100;
                dgListaServisa.Columns[1].Width = 100;
                dgListaServisa.Columns[2].Width = 150;
                dgListaServisa.Columns[3].Width = 250;
                dgListaServisa.Columns[4].Width = 300;
                dgListaServisa.Columns[5].Width = 523;
                dgListaServisa.Columns[6].Width = 200;
                dgListaServisa.Columns[7].Width = 200;
                dgListaServisa.Columns[7].DefaultCellStyle.Format = "N2";

                conn.Close();
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("GRESKA :" +ex.Message);
            }
        }

        private void dgListaServisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
