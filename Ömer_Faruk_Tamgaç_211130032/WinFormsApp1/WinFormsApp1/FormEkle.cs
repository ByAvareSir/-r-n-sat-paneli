using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
namespace WinFormsApp1
{
    public partial class FormEkle : Form
    {
        public FormEkle()
        {
            InitializeComponent();

        }

        private void FormEkle_Load(object sender, EventArgs e)
        {
            KayitGetir();

        }

        private void KayitGetir()
        {
            DataSet dset = new DataSet();
            XmlReader reader = XmlReader.Create(@"users.xml", new XmlReaderSettings());
            dset.ReadXml(reader);
            dataGridView1.DataSource = dset.Tables[0];
            reader.Close();
        }
        private string pathK = Application.StartupPath + @"/users.xml";

        private void button1_Click(object sender, EventArgs e)
        {
            KayitGetir();

            if (textSfr.Text==string.Empty|| textAd.Text == string.Empty || textSoy.Text == string.Empty
                || textID.Text == string.Empty || txtUsr.Text == string.Empty)
            {
                MessageBox.Show("Form alanları boş geçilemez!");
                return;
            }

            var userName = txtUsr.Text;
            
            var match = System.Xml.Linq.XElement.Load(@"users.xml")
                .Elements("users")
                .Where(x => x.Element("Username")?.Value == userName)
                .Any();

            if (match != true)
            {
                XDocument x = XDocument.Load(@"users.xml");
                x.Element("kullanıcı").Add(
                    new XElement("users",
                    new XElement("ID", textID.Text),
                    new XElement("Adı", textAd.Text),
                    new XElement("Soyadı", textSoy.Text),
                    new XElement("Username", txtUsr.Text),
                    new XElement("Şifre", textSfr.Text)
                        ));

                x.Save(@"users.xml");
                KayitGetir();
                textAd.Clear();
                textID.Clear();
                textSoy.Clear();
                textSfr.Clear();
                txtUsr.Clear();
            }

            else
            {
                MessageBox.Show("Bu kullanıcı adı daha önce kullanılmış");  
            }

           
}

        private void button2_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }
    }
}
