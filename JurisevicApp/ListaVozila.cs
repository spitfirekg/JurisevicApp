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
    public partial class ListaVozila : Form
    {

        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = JurisevicAppDb.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        public ListaVozila()
        {
            InitializeComponent();
            dgListaVozila.Show();
        }

        //Prikaz svih vozila iz baze podataka
        private void ListaVozila_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM vozila";

            try
            {
                conn.Open();
                com = new SQLiteCommand(selectQuery,conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgListaVozila.DataSource = dt;

                dgListaVozila.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgListaVozila.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgListaVozila.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgListaVozila.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgListaVozila.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgListaVozila.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5F, GraphicsUnit.Pixel);

                dgListaVozila.Columns[0].Width = 100;
                dgListaVozila.Columns[1].Width = 150;
                dgListaVozila.Columns[2].Width = 100;
                dgListaVozila.Columns[3].Width = 100;
                dgListaVozila.Columns[4].Width = 150;
                dgListaVozila.Columns[5].Width = 150;
                dgListaVozila.Columns[6].Width = 150;
                dgListaVozila.Columns[7].Width = 273;
                dgListaVozila.Columns[8].Width = 150;
                dgListaVozila.Columns[9].Width = 300;
                dgListaVozila.Columns[10].Width = 200;

                conn.Close();
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex.Message);
            }
        }

        private void dgListaVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
