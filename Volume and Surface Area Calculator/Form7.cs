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
    public partial class Form7 : Form
    {//declare variables
        private int Baseradius;
        private int Height;
        private int Surfacearea;
        private int Volume;

        private int intvalidation;

        //declare and initialize variables
        private bool bradius = false;
        private bool bheight = false;
        private bool barea = false;
        private bool bvolume = false;

        public Form7()
        {
            
            InitializeComponent();
            //initialise variables  on form constructors
            Baseradius = 0;
            Height = 0;

            //change attribute
            txt4_34.ReadOnly = true;
        }

       

        private void txt1_Validating(object sender, CancelEventArgs e)
        {
            //clear error provider
                errorProvider1.SetError(txt1_34, "");
                bradius = false;
                if (!int.TryParse(txt1_34.Text, out intvalidation))
                {
                    bradius = true;
                    errorProvider1.SetError(txt1_34, "Please fill the required area");
                }

            

        }

        private void txt2_Validating(object sender, CancelEventArgs e)
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
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bradius == false && bheight == false)
                {
                    Baseradius = int.Parse(txt1_34.Text);
                    Height = int.Parse(txt2_34.Text);

                    Surfacearea = ((22 * Baseradius) * (Baseradius + Height)) / 7;
                    Volume = ((Baseradius) ^ 2 * (Height) / 21) * 22;
                
                    txt4_34.Text = Volume.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }
    }
}
