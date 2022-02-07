using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafikus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4|| textBox1.Text.Length >4)
            {
                MessageBox.Show("Üres szövegbox vagy legalább 4 karakter legyem.");
            }
            int szuletesev = 0;
            bool szuletes = int.TryParse(textBox1.Text, out szuletesev);
            if (!szuletes)
            {
                MessageBox.Show("A szövegbe csak számot irjon");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
