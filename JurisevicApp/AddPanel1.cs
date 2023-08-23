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
    public partial class AddPanel1 : UserControl
    {
        //Kreiranje globalne konekcije sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = JurisevicAppDb.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;   
        public AddPanel1()
        {
            InitializeComponent();
        }





        private void btSacuvajVozilo_Click(object sender, EventArgs e)
        {
            //Ukoliko sva polja za dodavanje novih vozila nisu popunjena
            //izbaciti upozorenje u vidu poruke da polja nisu popunjena
            if (String.IsNullOrEmpty(tbmarka.Text) ||
                String.IsNullOrEmpty(tbmodel.Text) ||
                String.IsNullOrEmpty(tbgodiste.Text) ||
                String.IsNullOrEmpty(tbmotor.Text) ||
                String.IsNullOrEmpty(tbregistracija.Text) ||
                String.IsNullOrEmpty(tbsasija.Text) ||
                String.IsNullOrEmpty(tbkilometraza.Text) ||
                String.IsNullOrEmpty(tbime.Text) ||
                String.IsNullOrEmpty(cbgorivo.Text) ||
                String.IsNullOrEmpty(tbtelefon.Text))
            {
                MessageBox.Show("POLJA ZA UNOS PODATAKA MORAJU BITI POPUNJENA !");
            } 
            //Ukoliko polje za unos broja sasije ima manje ili vise od 17 karaktera
            //Izbaciti upozorenje u vidu poruke
            else if(tbsasija.Text.Length !=17)
            {
                MessageBox.Show("POLJE ZA UNOS BROJA ŠASIJE MORA IMATI 17 KARAKTERA !");
            }

            //Ukoliko nije pronjadjeno vozilo sa zadatim parametrima
            //Nastaviti sa dodavanjem u bazu podataka
            else
            {
                string registracija = tbregistracija.Text;
                string ime = tbime.Text;
                string sasja = tbsasija.Text;

                string searchQuery = "SELECT * FROM vozila WHERE registracija = '"+registracija+"'";
                string insertQuery = "INSERT INTO vozila (marka,model,godiste,motor,gorivo,registracija,sasija,kilometraza,ime,telefon) " +
                                                  "VALUES ('"+tbmarka.Text+"','"+tbmodel.Text+"','"+tbgodiste.Text+"','"+tbmotor.Text+"'," +
                                                          "'"+cbgorivo.Text+"','"+tbregistracija.Text+"','"+tbsasija.Text+"'," +
                                                          "'"+tbkilometraza.Text+"','"+tbime.Text+"','"+tbtelefon.Text+"')";
                try
                {
                    
                    conn.Open();
                    com = new SQLiteCommand(searchQuery,conn);
                    reader = com.ExecuteReader();
                    if(reader.HasRows)
                    {
                        MessageBox.Show("VOZILO SA REGISTARSKOM OZNAKOM '" + tbregistracija.Text + "' VEĆ POSTOJI U BAZI PODATAKA ");
                        reader.Close();
                    }
                    else
                    {
                        com = new SQLiteCommand(insertQuery,conn);
                        com.ExecuteNonQuery();
                        MessageBox.Show("USPEŠNO STE SAČUVALI VOZILO SA REGISTRACIONOM OZNAKOM '" + tbregistracija.Text + "'");
                        tbmarka.Clear();
                        tbmodel.Clear();
                        tbgodiste.Clear();
                        tbmotor.Clear();
                        tbregistracija.Clear();
                        tbsasija.Clear();
                        tbkilometraza.Clear();
                        tbime.Clear();
                        tbtelefon.Clear();
                        cbgorivo.Items.Clear();
                    }
                    conn.Close();
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show("GRESKA : " + ex);
                    
                }
            }

        }







    }
}
