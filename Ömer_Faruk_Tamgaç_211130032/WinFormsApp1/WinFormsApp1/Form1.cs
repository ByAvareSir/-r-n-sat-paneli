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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string path = Application.StartupPath + @"/admin.xml";
        private string pathK = Application.StartupPath + @"/users.xml";

        private void btn1_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
           
            
            string id = xDoc.GetElementsByTagName("id")[0].InnerText;
            string sfr = xDoc.GetElementsByTagName("sifre")[0].InnerText;
            string Kid = textBox1.Text;
            string Ksfr = textBox2.Text;



                if (Kid == id && Ksfr == sfr)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
               

                var userName = textBox1.Text;
                var password = textBox2.Text;
                var match = System.Xml.Linq.XElement.Load(@"users.xml")
                    .Elements("users")
                    .Where(x => x.Element("Username")?.Value == userName &&
                                x.Element("Şifre")?.Value == password)
                    .Any();
                if (match==true) {
                    FormKullanıcı klnc = new FormKullanıcı();
                    klnc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
