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
    public partial class Form5 : Form
    {//declare variables
        private int Baseedge;
        private int Height;
        private int Surfacearea;
        private int Volume;

        private int intvalidation;

        //declare and initialize variables
        private bool bedge = false;
        private bool bheight = false;
        private bool barea = false;
        private bool bvolume = false;

        public Form5()
        {
            
            InitializeComponent();
            //initialise variables  on form constructors
            Baseedge = 0;
            Height = 0;

            //change attribute
            txt3_34.ReadOnly = true;
            txt4_34.ReadOnly = true;

        }


        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bedge == false && bheight == false)
                {
                    Baseedge = int.Parse(txt1_34.Text);
                    Height = int.Parse(txt2_34.Text);

                    Surfacearea = Baseedge*(4*Baseedge+(Baseedge*Baseedge+4*Height*Height)^(1/2) )/4;
                    Volume = (Baseedge*Baseedge*Height)/3;
                    txt3_34.Text = Surfacearea.ToString();
                    txt4_34.Text = Volume.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }

        private void txt1_validating(object sender, CancelEventArgs e)
        {//clear error provider
            errorProvider1.SetError(txt1_34, "");
            bedge = false;
            if (!int.TryParse(txt1_34.Text, out intvalidation))
            {
                bedge = true;
                errorProvider1.SetError(txt1_34, "Please fill the required area");
            }

        }

        private void txt2_validating(object sender, EventArgs e)
        {
            //clear error provider
            errorProvider2.SetError(txt2_34, "");
            bheight = false;
            if (!int.TryParse(txt2_34.Text, out intvalidation))
            {
                bheight = true;
                errorProvider2.SetError(txt2_34, "Please fill the required area");
            }


        }
    }
}
