using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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
            try
            {
                lengh = double.Parse(Width.Text);
            }
            catch
            {
                MessageBox.Show(textBox1.Text + "is not a number");
            }
            
            double width = double.Parse(Height.Text);
            double area = lengh * width;
            Area.AppendText(area.ToString());

        }

        private void Width_TextChanged(object sender, EventArgs e)
        {

        }

        private void Height_TextChanged(object sender, EventArgs e)
        {

        }

        private void Area_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
