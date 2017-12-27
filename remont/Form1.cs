using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            avtoriz n = new avtoriz();
            n.Show();
            Hide();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Parent = label1;
            label2.BackColor = Color.Transparent;
        }


        private void label2_Click_1(object sender, EventArgs e)
        {
            author n = new author();
            n.Show();

        }
    }
}
