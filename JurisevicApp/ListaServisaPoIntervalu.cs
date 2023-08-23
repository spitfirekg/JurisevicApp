using iTextSharp.text.pdf;
using iTextSharp.text;
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

namespace JurisevicApp
{
    public partial class ListaServisaPoIntervalu : Form
    {

        SQLiteConnection conn = new SQLiteConnection(@"Data Source = JurisevicAppDb.sqlite;Version=3");
        SQLiteCommand com;
        SQLiteDataReader reader;
        public ListaServisaPoIntervalu()
        {
            InitializeComponent();

            dgZaInterval.Hide();
            labelUkupno.Hide();
            btInterval1.Hide();
            label5.Hide();
        }
        //Metoda za pretragu svih servisa po intervalu od datuma do datuma
        private void btZaiNTERVAL1_Click(object sender, EventArgs e)
        {

            string datumOd = dtOdDatuma1.Value.Date.ToString("MM/dd/yyyy");
            string datumDo = dtDodatuma1.Value.Date.ToString("MM/dd/yyyy");
            string byDateQuery = "SELECT * FROM servis WHERE datum BETWEEN '" + datumOd + "' AND '" + datumDo + "'";

            try
            {
                conn.Open();
                com = new SQLiteCommand(byDateQuery, conn);
                reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgZaInterval.DataSource = dt;
                //Centriranje texta u tabeli dataGridView
                dgZaInterval.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaInterval.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaInterval.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaInterval.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaInterval.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaInterval.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaInterval.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgZaInterval.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgZaInterval.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgZaInterval.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgZaInterval.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                //Odredjivanje sirine kolona u dataGridView
                dgZaInterval.Columns[0].Width = 100;
                dgZaInterval.Columns[1].Width = 100;
                dgZaInterval.Columns[2].Width = 150;
                dgZaInterval.Columns[3].Width = 200;
                dgZaInterval.Columns[4].Width = 300;
                dgZaInterval.Columns[5].Width = 626;
                dgZaInterval.Columns[6].Width = 150;
                dgZaInterval.Columns[7].Width = 150;
                dgZaInterval.Columns[7].DefaultCellStyle.Format = "N2";

                conn.Close();
                reader.Close();
                //Proracum ukupne sume iz tabele po cenama
                double sum = 0;
                for (int i = 0; i < dgZaInterval.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dgZaInterval.Rows[i].Cells[7].Value);
                }
                labelUkupno.Text = sum.ToString("N") + " Rsd";
            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA : " + ex);
            }



            dgZaInterval.Show();
            labelUkupno.Show();
            btInterval1.Show();
            label5.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Metoda za kreiranje PDF dokumenta i njegovo cuvanje
        private void btInterval1_Click(object sender, EventArgs e)
        {
            if (dgZaInterval.Rows.Count > 0)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF (*.pdf)|*.pdf";

                string nazivDnevnogIzvestaja = "Izveštaj za interval - ";
                string datumDnevnogIzvestajaOd = dtOdDatuma1.Value.ToString("dd.MM.yyyy");
                string datumDnevnogIzvestajaDo = dtDodatuma1.Value.ToString("dd.MM.yyyy");

                sf.FileName = nazivDnevnogIzvestaja + datumDnevnogIzvestajaOd + " do " + datumDnevnogIzvestajaDo;
                bool fileError = false;

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sf.FileName))
                    {
                        try
                        {
                            File.Delete(sf.FileName);
                        }
                        catch (Exception ex)
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message.ToString());
                        }

                    }
                }
                if (!fileError)
                {
                    try
                    {
                        //Podesavanje fontova za paragrafe
                        iTextSharp.text.Font f1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 15, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
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

                        string datum1 = DateTime.Now.ToString("dd/MM/yyyy");
                        string datum2 = DateTime.Now.ToString("dd/MM/yyyy");
                        string header = "Izveštaj servisa za period od " + datumDnevnogIzvestajaOd + " do " + datumDnevnogIzvestajaDo;

                        //Dodavanje paragrafa za dokument
                        Paragraph p1 = new Paragraph( header, f1);
                        p1.Alignment = Element.ALIGN_CENTER;
                        p1.SpacingAfter = 30;

                        Paragraph p2 = new Paragraph("  ID   Id Vozila  Marka    Model      Ime Vlasnika           Informacije o servisu           Datum                  Cena");
                        p2.Alignment = Element.ALIGN_LEFT;
                        p2.SpacingAfter = 15;

                        string datumizvestaja1 = DateTime.Now.ToString("dd/MM/yyyy");
                        Paragraph p3 = new Paragraph("Datum izveštaja : " + datumizvestaja1);
                        p3.Alignment = Element.ALIGN_CENTER;
                        p3.SpacingBefore = 5;

                        PdfPTable pdfPtabe = new PdfPTable(dgZaInterval.Columns.Count);




                        pdfPtabe.DefaultCell.Padding = 3;
                        pdfPtabe.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPtabe.TotalWidth = 570f;
                        pdfPtabe.LockedWidth = true;
                        float[] widths = new float[] { 35f, 35f, 70f, 70f, 120f, 230f, 100f, 100f };
                        pdfPtabe.SetWidths(widths);
                        pdfPtabe.HorizontalAlignment = Element.ALIGN_CENTER;

                        foreach (DataGridViewRow row in dgZaInterval.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfPtabe.AddCell(Convert.ToString(cell.FormattedValue));
                            }
                        }

                        double sum = 0;
                        for (int i = 0; i < dgZaInterval.Rows.Count; i++)
                        {
                            sum += Convert.ToDouble(dgZaInterval.Rows[i].Cells[7].Value);
                        }
                        labelUkupno.Text = sum.ToString("N");

                        Paragraph p4 = new Paragraph("UKUPNO : " + labelUkupno.Text + " Rsd");
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
                        MessageBox.Show("GRESKA :" + ex);
                    }
                }
            }
        }
    }
}
