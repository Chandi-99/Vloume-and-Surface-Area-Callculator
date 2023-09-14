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
    public partial class Form11 : Form
    {//declare variables
        private double Baseradius;
        private double Slantheight;
        private double Surfacearea;
        private double Volume;

        private double intvalidation;

        //declare and initialize variables
        private bool bradius = false;
        private bool bslantheight = false;
        private bool barea = false;
        private bool bvolume = false;

        public Form11()
        {
            InitializeComponent();
            //initialise variables  on form constructors
            Baseradius = 0;
            Height = 0;

            //change attribute
            txt3_34.ReadOnly = true;
            
        }

        private void txt1_validating(object sender, CancelEventArgs e)
        {
            //clear error provider
            errorProvider1.SetError(txt1_34, "");
            bradius = false;
            if (!double.TryParse(txt1_34.Text, out intvalidation))
            {
                bradius = true;
                errorProvider1.SetError(txt1_34, "Please fill the required area");
            }
        }

        private void txt2_validating(object sender, CancelEventArgs e)
        {
            //clear error provider
            errorProvider2.SetError(txt2_34, "");
            bslantheight = false;
            if (!double.TryParse(txt2_34.Text, out intvalidation))
            {
                bslantheight = true;
                errorProvider2.SetError(txt2_34, "Please fill the required area");
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bradius == false && bslantheight == false)
                {
                    Baseradius = double.Parse(txt1_34.Text);
                    Slantheight = int.Parse(txt2_34.Text);

                    Surfacearea = (22 * Baseradius * (Slantheight + Baseradius)) / 7;

                    txt3_34.Text = Surfacearea.ToString();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
