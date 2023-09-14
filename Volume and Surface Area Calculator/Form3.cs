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
    public partial class Form3 : Form
    {//declare variables
        private int Radius;      
        private int Surfacearea;
        private int Volume;

        private int intvalidation;

        //declare and initialize variables
        private bool bradius = false;
        private bool barea = false;
        private bool bvolume = false;
    
        public Form3()
        {
            InitializeComponent();
            //initialise variables  on form constructors
            Radius = 0;        

            //change attribute
            txt3_34.ReadOnly = true;
            txt4_34.ReadOnly = true;
        }

        private void txt1_validating(object sender, EventArgs e)
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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bradius == false )
                {
                   Radius = int.Parse(txt1_34.Text);
                    

                    Surfacearea = (88*(Radius)*(Radius))/7;
                    Volume = (88*(Radius)*(Radius)*(Radius)) /21;
                    txt3_34.Text = Surfacearea.ToString();
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
