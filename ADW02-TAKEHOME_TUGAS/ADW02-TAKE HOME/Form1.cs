using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADW02_TAKE_HOME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button_submit_Click(object sender, EventArgs e)
        {
            string nama = textBox_nama.Text;
            string email = textBox_email.Text;
            int age = Convert.ToInt32(textBox_age.Text);
            string phoneNum = textBox_phoneNum.Text;
            if (age < 18)
            {
                MessageBox.Show("Nama: " + nama + "\n" + "Email: " + email  + "\n" + "Phone Number: " + phoneNum + "\n" +  "You're a minor", "Biodata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nama: " + nama + "\n" + "Email: " + email  + "\n" + "Phone Number: " + phoneNum + "\n" + "You're an adult", "Biodata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_nama.Clear();
            textBox_age.Clear();
            textBox_email.Clear();
            textBox_phoneNum.Clear();
        }
    }
}
