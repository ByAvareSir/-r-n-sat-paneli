using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WinFormsApp1
{
    public partial class FormKullanıcı : Form
    {
        public FormKullanıcı()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(130,Color.LightGray);

        }
        private string path = Application.StartupPath + @"ürünler.xml";

        private void FormKullanıcı_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);

            string ürün1 = xDoc.GetElementsByTagName("Adı")[0].InnerText;
            string ürün2 = xDoc.GetElementsByTagName("Adı")[1].InnerText;
            string ürün3 = xDoc.GetElementsByTagName("Adı")[2].InnerText;
            string ürün4 = xDoc.GetElementsByTagName("Adı")[3].InnerText;

            urun1.Text = ürün1;
            urun2.Text = ürün2;
            urun3.Text = ürün3;
            urun4.Text = ürün4;

           
        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);

            string ürün1 = xDoc.GetElementsByTagName("Adı")[0].InnerText;
            string ürün2 = xDoc.GetElementsByTagName("Adı")[1].InnerText;
            string ürün3 = xDoc.GetElementsByTagName("Adı")[2].InnerText;
            string ürün4 = xDoc.GetElementsByTagName("Adı")[3].InnerText;

            double fiyat1 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[0].InnerText);
            double fiyat2 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[1].InnerText);
            double fiyat3 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[2].InnerText);
            double fiyat4 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[3].InnerText);

            fiyat1 *= (double)numericUpDown1.Value;
            fiyat2 *= (double)numericUpDown2.Value;
            fiyat3 *= (double)numericUpDown3.Value;
            fiyat4 *= (double)numericUpDown4.Value;

            double fiyat5 = 0;
            if (checkBox1.Checked && numericUpDown1.Value>0)
            {

                richTextBox1.AppendText(numericUpDown1.Value + " Adet "+ürün1 +" Fiyatı: "+fiyat1+" TL"+"\n");
                fiyat5 += fiyat1;
            }

            if (checkBox2.Checked && numericUpDown2.Value > 0)
            {
                richTextBox1.AppendText(numericUpDown2.Value + " Adet " + ürün2 + " Fiyatı: " + fiyat2 + " TL" + "\n");
                fiyat5 += fiyat2;
            }
            if (checkBox3.Checked && numericUpDown3.Value > 0)
            {
                richTextBox1.AppendText(numericUpDown3.Value + " Adet " + ürün3 + " Fiyatı: " + fiyat3 + " TL" + "\n");
                fiyat5 += fiyat3;
            }
            if (checkBox4.Checked && numericUpDown4.Value > 0)
            {
                richTextBox1.AppendText(numericUpDown4.Value + " Adet " + ürün4 + " Fiyatı: " + fiyat4 + " TL"+"\n");
                fiyat5 += fiyat4;
            }

            if (richTextBox1.Text!=string.Empty)
            {
                richTextBox1.AppendText("Toplam Fiyat:" + fiyat5 + " TL");
                btnHesapla.Enabled = false;
            }
           

        }

        double gosterge;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            double fiyat1 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[0].InnerText);
            double fiyat2 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[1].InnerText);
            double fiyat3 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[2].InnerText);
            double fiyat4 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[3].InnerText);

            fiyat1 *= (double)numericUpDown1.Value;
            fiyat2 *= (double)numericUpDown2.Value;
            fiyat3 *= (double)numericUpDown3.Value;
            fiyat4 *= (double)numericUpDown4.Value;

            gosterge = fiyat1 + fiyat2 + fiyat3 + fiyat4;
            lblGösterge.Text = gosterge.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            double fiyat1 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[0].InnerText);
            double fiyat2 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[1].InnerText);
            double fiyat3 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[2].InnerText);
            double fiyat4 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[3].InnerText);

            fiyat1 *= (double)numericUpDown1.Value;
            fiyat2 *= (double)numericUpDown2.Value;
            fiyat3 *= (double)numericUpDown3.Value;
            fiyat4 *= (double)numericUpDown4.Value;

            gosterge = fiyat1 + fiyat2 + fiyat3 + fiyat4;
            lblGösterge.Text = gosterge.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            double fiyat1 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[0].InnerText);
            double fiyat2 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[1].InnerText);
            double fiyat3 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[2].InnerText);
            double fiyat4 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[3].InnerText);

            fiyat1 *= (double)numericUpDown1.Value;
            fiyat2 *= (double)numericUpDown2.Value;
            fiyat3 *= (double)numericUpDown3.Value;
            fiyat4 *= (double)numericUpDown4.Value;

            gosterge = fiyat1 + fiyat2 + fiyat3 + fiyat4;
            lblGösterge.Text = gosterge.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            double fiyat1 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[0].InnerText);
            double fiyat2 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[1].InnerText);
            double fiyat3 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[2].InnerText);
            double fiyat4 = Convert.ToDouble(xDoc.GetElementsByTagName("Fiyat")[3].InnerText);

            fiyat1 *= (double)numericUpDown1.Value;
            fiyat2 *= (double)numericUpDown2.Value;
            fiyat3 *= (double)numericUpDown3.Value;
            fiyat4 *= (double)numericUpDown4.Value;

            gosterge = fiyat1 + fiyat2 + fiyat3 + fiyat4;
            lblGösterge.Text = gosterge.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            btnHesapla.Enabled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Times New Roman", 30, FontStyle.Bold);
            Brush renk = Brushes.Black;
            PointF baslangıc = new Point(150,500);
            e.Graphics.DrawString(richTextBox1.Text,font,renk,baslangıc);
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
