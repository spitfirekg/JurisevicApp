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
    public partial class AdminPanel2 : UserControl
    {
        public AdminPanel2()
        {
            InitializeComponent();
        }

        private void btAdminSvaVozila_Click(object sender, EventArgs e)
        {
            //Prikazivanje nove forme sa listom tj DataGridView svih vozila iz baze podataka
            var listaVozila = new ListaVozila();
            listaVozila.Show();
        }

        private void btAdminSViServisi_Click(object sender, EventArgs e)
        {
            //Prikazivanje nove forme sa listom tj DataGridView svih  servisa iz baze podataka
            var listaServis = new ListaServisa();
            listaServis.Show();
        }

        private void btAdminZaDatum_Click(object sender, EventArgs e)
        {
            //Prikazivanje nove forme sa DataGridView i izborom datuma za prikaz servisa po odredjenom datumu
            var listaPoDatumu = new ListaServisaPoDatumu();
            listaPoDatumu.Show();
        }

        private void btAdminPoIntervalu_Click(object sender, EventArgs e)
        {
            //Prikazivanje nove forme da DataGridView i izborom intervala uzmedju dva datuma za prikaz servisa odabranog intervala
            var listaPoIntervalu = new ListaServisaPoIntervalu();
            listaPoIntervalu.Show();
        }
    }
}
