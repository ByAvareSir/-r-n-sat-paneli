using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace WinFormsApp1
{
    public partial class FormGüncelle : Form
    {
        public FormGüncelle()
        {
            InitializeComponent();
        }

        private void KayitGetir()
        {
            DataSet dset = new DataSet();
            XmlReader reader = XmlReader.Create(@"ürünler.xml", new XmlReaderSettings());
            dset.ReadXml(reader);
            dataGridView1.DataSource = dset.Tables[0];
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"users.xml");
            XElement element = xdosya.Element("kullanıcı").Elements("users").FirstOrDefault(x => x.Element("ID").Value == txtID.Text);
            {

                if (txtAdi.Text==string.Empty||txtID.Text==string.Empty || txtFiyat.Text == string.Empty)
                {
                    MessageBox.Show("Alanlar boş bırakılamaz");
                    return;
                    
                }

                XDocument x = XDocument.Load(@"ürünler.xml");
                XElement node = x.Element("ürünler").Elements("saat").FirstOrDefault(a => a.Element("ID").Value.Trim() == txtID.Text);
                if (node!=null)
                {
                    node.SetElementValue("Adı", txtAdi.Text) ;
                    node.SetElementValue("Fiyat",txtFiyat.Text);
                    x.Save(@"ürünler.xml");
                    KayitGetir();
                    txtAdi.Clear();
                    txtFiyat.Clear();
                    txtID.Clear();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  txtAdi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           */
        }

        private void FormGüncelle_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}
