using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace JurisevicApp
{
    public partial class SearchPanel1 : UserControl
    {
        //Globalna konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = JurisevicAppDb.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;


        public SearchPanel1()
        {
            InitializeComponent();
            panelSearchResult.Hide();
            panelLServisInfo.Hide();

        }


        //Metod za Pretragu novog vozila u bazu podataka
        private void btsearch_Click(object sender, EventArgs e)
        {
            string registracija = tbsearch.Text;
            string ime = tbsearch.Text;
            string sasija = tbsearch.Text;

            string searchQuery = "SELECT * FROM vozila WHERE registracija = '" + registracija + "' OR ime = '" + ime + "' OR sasija = '" + sasija + "'";

            if (String.IsNullOrEmpty(tbsearch.Text))
            {
                MessageBox.Show("NISTE UNELI PARAMETAR ZA PRETRAGU");
            }
            else
            {
                try
                {
                    conn.Open();
                    com = new SQLiteCommand(searchQuery,conn);
                    reader = com.ExecuteReader();
                    if (reader.Read())
                    {

                        tbid1.Text = Convert.ToString((int)reader.GetInt32(0));
                        tbmarka1.Text = reader.GetString(1);
                        tbmodel1.Text = reader.GetString(2);
                        tbgodiste1.Text = reader.GetString(3);
                        tbmotor1.Text = reader.GetString(4);
                        tbgorivo1.Text = reader.GetString(5);
                        tbregistracija1.Text = reader.GetString(6);
                        tbsasija1.Text = reader.GetString(7);
                        tbkilometraza.Text = reader.GetString(8);
                        tbime1.Text = reader.GetString(9);
                        tbtelefon1.Text = reader.GetString(10);
                        panelSearchResult.Show();
                        panelLServisInfo.Hide();
                        reader.Close();
                        conn.Close();


                        //UREDITI KREIRANJE PDF RACUNA NAKON CUVANJA PODATAKA O SERVISU
                    }
                    else
                    {
                        MessageBox.Show("VOZILO NIJE PRONADJENO");
                        tbsearch.Clear();
                        conn.Close();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("GREŠKA : " + ex);
                }
            }
            
        }

        //Metod za prikazivanje informacija o servisu pretrazenog vozila
        private void btServisInfo_Click(object sender, EventArgs e)
        {

            string selectQuery = "SELECT * FROM servis WHERE idVozila='" + tbid1.Text + "'";

            try
            {
                conn.Open();
                com = new SQLiteCommand(selectQuery,conn);
                reader= com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgServisInfo.DataSource = dt;

                dgServisInfo.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgServisInfo.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                

                dgServisInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgServisInfo.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgServisInfo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgServisInfo.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5F, GraphicsUnit.Pixel);

                dgServisInfo.Columns[0].Width = 50;
                dgServisInfo.Columns[1].Width = 70;
                dgServisInfo.Columns[2].Width = 100;
                dgServisInfo.Columns[3].Width = 120;
                dgServisInfo.Columns[4].Width = 250;
                dgServisInfo.Columns[5].Width =473;
                dgServisInfo.Columns[6].Width = 100;
                dgServisInfo.Columns[7].Width = 110;
                dgServisInfo.Columns[7].DefaultCellStyle.Format = "N2";
                conn.Close();
                reader.Close();


                btnSaveService.Hide();
                labelcena1.Hide();
                tbcena1.Hide();
                tbAddServis.Hide();
                btNewService.Show();
                dgServisInfo.Show();
                panelLServisInfo.Show();


                
            }
            catch(Exception ex)
            {
                MessageBox.Show("GREŠKA : " + ex);
            }

           

        }





        //Metod za izmenu podataka pretrazeng vozila iz baze podataka
        private void btUpdate_Click(object sender, EventArgs e)
        {
            //Provera dali su sva polja za izmenu podataka popunjena
            if (String.IsNullOrEmpty(tbmarka1.Text) ||
                String.IsNullOrEmpty(tbmodel1.Text) ||
                String.IsNullOrEmpty(tbgorivo1.Text) ||
                String.IsNullOrEmpty(tbgodiste1.Text) ||
                String.IsNullOrEmpty(tbmotor1.Text) ||
                String.IsNullOrEmpty(tbregistracija1.Text) ||
                String.IsNullOrEmpty(tbsasija1.Text) ||
                String.IsNullOrEmpty(tbime1.Text) ||
                String.IsNullOrEmpty(tbtelefon1.Text))
            {
                MessageBox.Show("SVA POLJA SA PODACIMA MORAJU BITI POPUNJENA");
            }
            else if(tbsasija1.Text.Length != 17)
            {
                MessageBox.Show("POLJE ZA UNOS BROJA ŠASIJE MORA IMATI 17 KARAKTERA");
            }
            else
            {
                string updateQuery = "UPDATE vozila SET marka='"+tbmarka1.Text+"', " +
                                                       "model='"+tbmodel1.Text+"', " +
                                                       "godiste='"+tbgodiste1.Text+"', " +
                                                       "motor='"+tbmotor1.Text+"', " +
                                                       "gorivo='"+tbgorivo1.Text+"', " +
                                                       "registracija='"+tbregistracija1.Text+"', " +
                                                       "sasija='"+tbsasija1.Text+"', " +
                                                       "kilometraza='"+tbkilometraza.Text+"', " +
                                                       "ime='"+tbime1.Text+"', " +
                                                       "telefon='"+tbtelefon1.Text+"' " +
                                                       "WHERE id='"+tbid1.Text+"'";

                try
                {
                    conn.Open();
                    com = new SQLiteCommand(updateQuery,conn);
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("UŠPESNO STE IZMENILI PODATKE ZA VOZILO SA REGISTRACIONOM OZNAKOM '" + tbregistracija1.Text + "'");

                }
                catch(Exception ex)
                {
                    MessageBox.Show ("GREŠKA : " + ex.Message);
                }
            }
        }


        //Metoda za dodavanje servisnih informacija za pretrazeno vozilo
        private void btNewService_Click(object sender, EventArgs e)
        {
            
            btNewService.Hide();
            dgServisInfo.Hide();
            tbAddServis.Show();
            labelcena1.Show();
            tbcena1.Show();
            btnSaveService.Show();

        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbAddServis.Text) ||
               String.IsNullOrEmpty(tbcena1.Text))
            {
                MessageBox.Show("POLJA ZA UNOS SERVISNIH INFORMACIJA I CENE MORAJU BITI POPUNJENA");
            }
            else
            {
                string datum = DateTime.Now.ToString("MM/dd/yyyy");
                string insertQuery = "INSERT INTO servis (idVozila,marka,model,ime,servisInfo,datum,cena) " +
                                                  "VALUES ('"+tbid1.Text+"','"+tbmarka1.Text+"','"+tbmodel1.Text+"'," +
                                                  "'"+tbime1.Text+"','"+tbAddServis.Text+"','"+datum+"','"+tbcena1.Text+"')";
                try
                {
                    conn.Open();
                    com = new SQLiteCommand(insertQuery, conn); 
                   // com.ExecuteNonQuery();

                    if(com.ExecuteNonQuery() > 0 ) 
                    {
                        MessageBox.Show("USPEŠNO STE SAČUVALI SERVISNE INFORMACIJE ZA VOZILO SA REGISTRACIONOM OZNAKOM '" + tbregistracija1.Text + "'");
                        conn.Close();



                        //KREIRANJE PDF FAJLA
                        
                        string registracija = tbregistracija1.Text.ToString();
                        string datumRacuna = Convert.ToString(DateTime.Now);
                        SaveFileDialog sf = new SaveFileDialog();
                        sf.Filter = "PDF (*.pdf)|*.pdf";
                        sf.FileName = "Izvod servisa za vozilo " + registracija;    
                        bool fileError = false;

                        if(sf.ShowDialog() == DialogResult.OK)
                        {
                            if(File.Exists(sf.FileName))
                            {
                                try
                                {
                                    File.Delete(sf.FileName);
                                }
                                catch(IOException ex)
                                {
                                    MessageBox.Show("GREŠKA : " + ex);
                                }

                            }
                        }
                        if(!fileError )
                        {
                            try
                            {
                                //Podesavanje fontova za paragrafe
                                iTextSharp.text.Font f1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

                                //Dodavanje slike u dokument
                                System.Drawing.Image pImage = System.Drawing.Image.FromFile("C:/images/Kompletna slika.jpg");
                                iTextSharp.text.Image itextImage = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Png);
                                itextImage.Alignment = Element.ALIGN_CENTER;
                                //itextImage.ScaleAbsolute(SIRINA, Visina)
                                itextImage.ScaleAbsolute(300f, 100f);

                                System.Drawing.Image pImage2 = System.Drawing.Image.FromFile("C:/images/Auto Servis Jurišević.png");
                                iTextSharp.text.Image itextImage2 = iTextSharp.text.Image.GetInstance(pImage2, System.Drawing.Imaging.ImageFormat.Png);
                                itextImage2.Alignment = Element.ALIGN_CENTER;
                                itextImage2.ScaleAbsolute(300, 60);

                                string danasnjiDatum = DateTime.Now.ToString("dd/MM/yyyy");

                                //Kreiranje paragrafa
                                Paragraph p1 = new Paragraph("Izveštaj servisa za vozilo : " + tbregistracija1.Text, f1);
                                p1.Alignment = Element.ALIGN_CENTER;
                                p1.SpacingBefore = 5;

                                Paragraph p2 = new Paragraph(tbAddServis.Text);
                                p2.Alignment = Element.ALIGN_CENTER;
                                p2.SpacingBefore = 20;


                                Paragraph pLine = new Paragraph("____________________________________________");
                                    pLine.Alignment = Element.ALIGN_CENTER; 
                                    pLine.SpacingBefore = 10;
                                //***************************************
                                //***************************************
                                //KONVERZIJA IZ TEXTBOXA U DOUBLE VREDNOST
                                double cena = Convert.ToDouble(tbcena1.Text);
                                var ukupno = cena.ToString("N");

                                

                                Paragraph p5 = new Paragraph("CENA SERVISA : " +ukupno+" Rsd");
                                p5.Alignment = Element.ALIGN_CENTER;
                                p5.SpacingBefore = 20;
                                

                                Paragraph p3 = new Paragraph("Izveštaj izdao : ______________________________");
                                p3.Alignment = Element.ALIGN_CENTER;
                                p3.SpacingBefore = 30;

                                Paragraph p4 = new Paragraph("Datum : " + danasnjiDatum);
                                p4.Alignment = Element.ALIGN_CENTER;
                                p4.SpacingBefore = 20;

                                using (FileStream fs = new FileStream(sf.FileName, FileMode.Create))
                                {
                                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(doc, fs);

                                    doc.Open();
                                    doc.Add(itextImage);
                                    doc.Add(itextImage2);
                                    doc.Add(p1);
                                    doc.Add(p2);
                                    doc.Add(pLine);
                                    doc.Add(p5);
                                    doc.Add(p3);
                                    doc.Add(p4);
                                    doc.Close();
                                    fs.Close();
                                }

                                MessageBox.Show("Uspešno ste kreirali PDF dokument !");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("GREŠKA : " + ex);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("GREŠKA : PODACI NISU SACUVANI");
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("GREŠKA : " + ex);
                }
            }
            {
                {

                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM vozila WHERE id='" + tbid1.Text + "'";
            string deleteQuery2 = "DELETE FROM servis where idVozila='" + tbid1.Text + "'";
            try
            {
                conn.Open();
                com = new SQLiteCommand(deleteQuery,conn);
                com.ExecuteNonQuery();
                
                SQLiteCommand com1 = new SQLiteCommand(deleteQuery2,conn);
                com1.ExecuteNonQuery();

                MessageBox.Show("USPEŠNO STE IZBRISALI SVE PODATKE O VOZILU I SERVISU ZA VOZILO '" + tbregistracija1.Text + "'");
                conn.Close();
                tbid1.Clear();
                tbmarka1.Clear();
                tbmodel1.Clear();  
                tbgorivo1.Clear();
                tbgodiste1.Clear();
                tbmotor1.Clear();
                tbregistracija1.Clear();
                tbsasija1.Clear();
                tbime1.Clear();
                tbtelefon1.Clear();
                tbkilometraza.Clear();
                tbAddServis.Clear();
                tbcena1.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
