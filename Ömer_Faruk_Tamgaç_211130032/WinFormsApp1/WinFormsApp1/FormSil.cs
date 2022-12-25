using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xaml;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace WinFormsApp1
{
    public partial class FormSil : Form
    {
        public FormSil()
        {
            InitializeComponent();
        }

        private void KayitGetir()
        {
            DataSet dset = new DataSet();
            XmlReader reader = XmlReader.Create(@"users.xml", new XmlReaderSettings());
            dset.ReadXml(reader);
            dataGridView1.DataSource = dset.Tables[0];
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"users.xml");
            xdosya.Root.Elements().Where(x => x.Element("ID").Value == dataGridView1.CurrentRow.Cells[0].Value.ToString()).Remove();
            xdosya.Save(@"users.xml");
            MessageBox.Show("Kayıt Silindi");
            KayitGetir();
        }

        private void FormSil_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}
