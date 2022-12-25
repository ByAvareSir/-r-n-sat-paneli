
namespace WinFormsApp1
{
    partial class FormEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoy = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textSfr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(104, 59);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 23);
            this.textAd.TabIndex = 5;
            // 
            // textSoy
            // 
            this.textSoy.Location = new System.Drawing.Point(104, 105);
            this.textSoy.Name = "textSoy";
            this.textSoy.Size = new System.Drawing.Size(100, 23);
            this.textSoy.TabIndex = 6;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(104, 13);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 23);
            this.textID.TabIndex = 7;
            // 
            // textSfr
            // 
            this.textSfr.Location = new System.Drawing.Point(104, 197);
            this.textSfr.Name = "textSfr";
            this.textSfr.Size = new System.Drawing.Size(100, 23);
            this.textSfr.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(465, 348);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtUsr
            // 
            this.txtUsr.Location = new System.Drawing.Point(104, 151);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(100, 23);
            this.txtUsr.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(-6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Tabloyu Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormEkle
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(707, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textSfr);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textSoy);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEkle";
            this.Load += new System.EventHandler(this.FormEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoy;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textSfr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}