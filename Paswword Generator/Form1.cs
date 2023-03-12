using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paswword_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght;
            if (int.TryParse(lenghtPassword.Text, out lenght))
            {
                // txtSayi.Text değeri int tipine dönüştürülebilirse, sayi değişkeni bu değeri alır
                // bu blok içinde sayı işlemlerini yapabilirsiniz
            }
            else
            {
                MessageBox.Show("Lütfen bir tamsayı girin!");
            }

            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            Random random = new Random();
            string password = "";
            for (int i = 0; i < lenght; i++)
            {
                int index = random.Next(characters.Length);
                password += characters[index];



            }
            newPassword.Text = password;
        }
    }
}
