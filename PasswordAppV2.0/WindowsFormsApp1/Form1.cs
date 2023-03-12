using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lenght_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenghts;
            if (int.TryParse(lenght.Text, out lenghts))
            {
            }
            else
            {
                MessageBox.Show("Please enter a integer!");
            }


            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            Random random = new Random();
            string password = "";
            for (int i = 0; i < lenghts; i++)
            {
                int index = random.Next(characters.Length);
                password += characters[index];



            }
            newPassword.Text = password;
            
            string newName = appName.Text;

            string wayOfFile = @"C:\\Users\\rmznk\\OneDrive\\Masaüstü\\Mytools\\PasswordAppV2.0\\dark.txt";
            wayOfFile = wayOfFile.ToString();
            using (StreamWriter filedump = new StreamWriter(wayOfFile, true))
            {
                filedump.WriteLine("Appname: "+newName+ " Password : " + password);
            }       
}
        
    }
}
