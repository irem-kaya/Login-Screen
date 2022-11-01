using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kullaniciAdi;
        string sifre;


        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi == "iremsss59" && sifre == "0000")
            {
                MessageBox.Show("WELCOME!!");
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("The user or password you entered is incorrect");
            }          
        }
        private void tbxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            kullaniciAdi = tbxKullaniciAdi.Text;
        }
        private void tbxSifre_TextChanged(object sender, EventArgs e)
        {
            tbxSifre.PasswordChar = '*';
            sifre = tbxSifre.Text;   
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
        }
    }
}
