using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace JurisevicApp
{
    public partial class ListaServisaPoDatumu : Form
    {

        //Konekcija sa bazom podataka
        SQLiteConnection conn = new SQLiteConnection(@"Data Source = JurisevicAppDb.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        private object cell;

        public ListaServisaPoDatumu()
        {
            InitializeComponent();
            dgZaDatum1.Hide();
            label3.Hide();
            labelUkupno.Hide();
            btZaDatumPdf.Hide();
        }


        //Metoda za prikazivanje servisa po izabranom datumu putem DatePicker-a
        private void btZaDatum1_Click(object sender, EventArgs e)
        {

            string datum = dtZaDatum.Value.Date.ToString("MM/dd/yyyy");
            string byDateQuery = "SELECT * FROM servis WHERE datum='" + datum + "'";
            string cenaPodatumu = "SELECT SUM(cena) FROM servis WHERE datum='" + datum + "'";

            try
            {
                conn.Open();
                com = new SQLiteCommand(byDateQuery,conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgZaDatum.DataSource = dt;


                //Podesavanje i centriranje texta u kolonama
                dgZaDatum.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaDatum.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaDatum.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaDatum.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaDatum.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaDatum.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaDatum.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaDatum.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgZaDatum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgZaDatum.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgZaDatum.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;


                //Poderavanje sirine kolona
                dgZaDatum.Columns[0].Width = 100;
                dgZaDatum.Columns[1].Width = 100;
                dgZaDatum.Columns[2].Width = 150;
                dgZaDatum.Columns[3].Width = 200;
                dgZaDatum.Columns[4].Width = 300;
                dgZaDatum.Columns[5].Width = 626;
                dgZaDatum.Columns[6].Width = 150;
                dgZaDatum.Columns[7].Width = 150;
                dgZaDatum.Columns[7].DefaultCellStyle.Format = "N2";

                conn.Close();
                reader.Close();


                //Izracinavanje ukupne sume tj sabiranje kolona sa cenama
                double sum = 0;
                for( int i = 0; i < dgZaDatum.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dgZaDatum.Rows[i].Cells[7].Value);
                }
                labelUkupno.Text = sum.ToString("N") +" Rsd";


            }
            catch(Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex.Message);
            }

            dgZaDatum.Show();
            label3.Show();
            labelUkupno.Show();
            btZaDatumPdf.Show();
           
        }

        //Metoda za kreiranje i cuvanje PDF fajla
        private void btZaDatumPdf_Click(object sender, EventArgs e)
        {
            if(dgZaDatum.Rows.Count > 0)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF (*.pdf)|*.pdf";

                string nazivDnevnogIzvestaja = "Izveštaj za datum - ";
                string datumDnevnogIzvestaja = dtZaDatum.Value.ToString("dd.MM.yyyy");

                sf.FileName = nazivDnevnogIzvestaja + datumDnevnogIzvestaja;
                bool fileError = false;

                if(sf.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(sf.FileName))
                    {
                        try
                        {
                            File.Delete(sf.FileName);
                        }
                        catch(Exception ex )
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message.ToString()); 
                        }
                        
                    }
                }
                if(!fileError)
                {
                    try
                    {
                        //Podesavanje fontova za paragrafe
                        iTextSharp.text.Font f1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font fontTitle = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

                        //Dodavanje slike u dokument
                        System.Drawing.Image pImage = System.Drawing.Image.FromFile("C:/images/Kompletna slika.jpg");
                        iTextSharp.text.Image itextImage = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Png);
                        itextImage.Alignment = Element.ALIGN_CENTER;
                        itextImage.ScaleAbsolute(300f, 100f);

                        System.Drawing.Image pImage2 = System.Drawing.Image.FromFile("C:/images/Auto Servis Jurišević.png");
                        iTextSharp.text.Image itextImage2 = iTextSharp.text.Image.GetInstance(pImage2, System.Drawing.Imaging.ImageFormat.Png);
                        itextImage2.Alignment = Element.ALIGN_CENTER;
                        itextImage2.ScaleAbsolute(300f, 60f);

                        string datum = dtZaDatum.Value.ToString("dd/MM/yyyy");

                        //Dodavanje paragrafa za dokument
                        Paragraph p1 = new Paragraph("Izveštaj servisa za dan - " + datum, f1);
                        p1.Alignment = Element.ALIGN_CENTER;
                        p1.SpacingAfter = 30;

                        Paragraph p2 = new Paragraph("  ID   Id Vozila  Marka    Model      Ime Vlasnika           Informacije o servisu           Datum                  Cena");
                        p2.Alignment = Element.ALIGN_LEFT;
                        p2.SpacingAfter = 15;

                        string datumizvestaja1 = DateTime.Now.ToString("dd/MM/yyyy");
                        Paragraph p3 = new Paragraph("Datum izveštaja : " + datumizvestaja1);
                        p3.Alignment = Element.ALIGN_CENTER;
                        p3.SpacingBefore = 5;

                        PdfPTable pdfPtabe = new PdfPTable(dgZaDatum.Columns.Count);



                        //Kreiranje tabele sa podacima iz DataGridView tabele i smestanjeu PDF dokument
                        pdfPtabe.DefaultCell.Padding = 3;
                        pdfPtabe.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;                       
                        pdfPtabe.TotalWidth = 570f;
                        pdfPtabe.LockedWidth = true;
                        float[] widths = new float[] { 35f, 35f, 70f, 70f, 120f, 230f, 100f,100f };
                        pdfPtabe.SetWidths(widths);
                        pdfPtabe.HorizontalAlignment = Element.ALIGN_CENTER;

                        foreach(DataGridViewRow row in dgZaDatum.Rows)
                        {
                            foreach(DataGridViewCell cell in row.Cells)
                            {
                                pdfPtabe.AddCell(Convert.ToString(cell.FormattedValue));
                            }
                        }
                         //Proracum ukupne sume sa cenama
                        double sum = 0;
                        for(int i = 0; i < dgZaDatum.Rows.Count; i++)
                        {
                            sum += Convert.ToDouble(dgZaDatum.Rows[i].Cells[7].Value);
                        }
                        labelUkupno.Text = sum.ToString("N");

                        Paragraph p4 = new Paragraph("UKUPNO : " + labelUkupno.Text+ " Rsd");
                        p4.Alignment = Element.ALIGN_RIGHT;
                        p4.SpacingBefore = 10;
                        p4.SpacingAfter = 10;

                        using (FileStream stream1 = new FileStream(sf.FileName, FileMode.Create))
                        {
                            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(doc, stream1);
                            doc.Open();
                            doc.Add(itextImage);
                            doc.Add(itextImage2);
                            doc.Add(p1);
                            doc.Add(p2);
                            doc.Add(pdfPtabe);
                            doc.Add(p4);
                            doc.Add(p3);
                            doc.Close();
                            stream1.Close();
                        }

                        MessageBox.Show("Uspešno ste kreirali PDF dokument");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("GRESKA :"+ex);
                    }
                }
            }
        }

        private void ListaServisaPoDatumu_Load(object sender, EventArgs e)
        {

        }
    }
}
