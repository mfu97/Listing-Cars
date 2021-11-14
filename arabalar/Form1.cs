using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        DataTable yenitablo = new DataTable();
        public int aranan_r = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tablo;
            tablo.Columns.Add("Adı", typeof(string));
            tablo.Columns.Add("Modeli", typeof(string));
            tablo.Columns.Add("Km", typeof(string));
            tablo.Columns.Add("Yılı", typeof(string));

            tablo.Rows.Add("Mercedes", "cla 200", "150000", "2016");
            tablo.Rows.Add("Mercedes", "e 200", "300000", "2013");
            tablo.Rows.Add("Mercedes", "gla 200", "110000", "2015");
            tablo.Rows.Add("Mercedes", "e 250", "250000", "2010");
            tablo.Rows.Add("Mercedes", "b 180", "190000", "2014");
            tablo.Rows.Add("Toyota", "Corolla", "200000", "2009");
            tablo.Rows.Add("Toyota", "Auris", "100000", "2015");

            yenitablo.Columns.Add("Adı", typeof(string));
            yenitablo.Columns.Add("Modeli", typeof(string));
            yenitablo.Columns.Add("Km", typeof(string));
            yenitablo.Columns.Add("Yılı", typeof(string));

        }

        private void modeller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gecir_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
            {
                modeller.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());

            }
            string[] items = modeller.Items.OfType<string>().Distinct().ToArray();
            modeller.Items.Clear();
            for (int i = 0; i < items.Length; i++)
                modeller.Items.Add(items[i]);
        }

        private void sec_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = yenitablo;
            string aranan = modeller.Text.Trim().ToUpper();


            int i = 0;
            aranan_r = 0;
            string ad, model, km, yil;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    if (cell.Value != null)
                    {
                        if (cell.Value.ToString().ToUpper() == aranan)
                        {
                            ad = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            model = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            km = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            yil = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            yenitablo.Rows.Add(ad, model, km, yil);
                        }
                    }
                }
                i = i + 1;
            }
            modeller.Text = ("");
            modeller.Items.Clear();
        }

        private void sec_1_Click(object sender, EventArgs e)
        {
            //int aranan = yil_baslangic.Text.Trim().ToUpper();
            int sayac = dataGridView3.Rows.Count;
            int deger = 0;
            int i = 0;
            int yil1, yil2;
            for (i = 0; i <= sayac - 2; i++)
            {
                try
                {
                    deger = Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value.ToString());
                    yil1 = Convert.ToInt32(this.yil_baslangic.Text);
                    yil2 = Convert.ToInt32(this.yil_bitis.Text);
                    if (deger >= yil1 && deger <= yil2)
                    {

                    }
                    else
                    {
                        dataGridView3.Rows.RemoveAt(this.dataGridView3.Rows[i].Index);
                        i--;
                    }
                }
                catch
                {

                }

            }

        }

        private void sec_2_Click(object sender, EventArgs e)
        {
            int sayac = dataGridView3.Rows.Count;
            int deger = 0;
            int i = 0;
            int Km1, Km2;
            for (i = 0; i <= sayac - 2; i++)
            {
                try
                {
                    deger = Convert.ToInt32(dataGridView3.Rows[i].Cells[2].Value.ToString());
                    Km1 = Convert.ToInt32(this.km_baslangic.Text);
                    Km2 = Convert.ToInt32(this.km_bitis.Text);
                    if (deger >= Km1 && deger <= Km2)
                    {

                    }
                    else
                    {
                        dataGridView3.Rows.RemoveAt(this.dataGridView3.Rows[i].Index);
                        i--;
                    }
                }
                catch
                {

                }
            }
        }
    }
}
