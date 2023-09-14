using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_and_Surface_Area_Calculator
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form4 form4
               = new Form4();
            form4.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form9 form9
               = new Form9();
            form9.Show();
        }
    }
}
