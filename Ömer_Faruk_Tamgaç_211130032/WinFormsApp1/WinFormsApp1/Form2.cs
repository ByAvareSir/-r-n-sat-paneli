using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();

        }
       
        FormEkle ekle = new FormEkle();
        FormSil sil = new FormSil();
        FormGüncelle gün = new FormGüncelle();
        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.ForestGreen;
            btn2.BackColor = btn4.BackColor;
            btn3.BackColor = btn4.BackColor;
            panelTitleBar.BackColor = Color.ForestGreen;
            panelLogo.BackColor = Color.DarkGreen;
            label1.Text = "Kullanıcı Ekleme Ekranı";
            gün.Hide();
            sil.Hide();
            ekle.TopLevel = false;           
            panel1.Controls.Add(ekle);
            ekle.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.BackColor = btn4.BackColor;
            btn2.BackColor = Color.Firebrick;
            btn3.BackColor = btn4.BackColor;
            panelTitleBar.BackColor = Color.Firebrick;
            panelLogo.BackColor = Color.Firebrick;
            label1.Text = "Kullanıcı Silme Ekranı";


            gün.Hide();
            ekle.Hide();
            sil.TopLevel = false;
            panel1.Controls.Add(sil);
            sil.Show();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn1.BackColor = btn4.BackColor;
            btn2.BackColor = btn4.BackColor;
            btn3.BackColor = Color.RoyalBlue;
            panelTitleBar.BackColor = Color.RoyalBlue;
            panelLogo.BackColor = Color.DarkBlue;
            label1.Text = "Ürün Güncelleme Ekranı";


            sil.Hide();
            ekle.Hide();
            gün.TopLevel = false;
            panel1.Controls.Add(gün);
            gün.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            btn1.BackColor = btn4.BackColor;
            btn2.BackColor = btn4.BackColor;
            btn3.BackColor = btn4.BackColor;

            Application.Exit();
        }
    }
}
