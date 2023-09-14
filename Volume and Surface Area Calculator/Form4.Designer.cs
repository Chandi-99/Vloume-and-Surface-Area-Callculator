namespace Volume_and_Surface_Area_Calculator
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lbl1_34 = new System.Windows.Forms.Label();
            this.txt1_34 = new System.Windows.Forms.TextBox();
            this.txt2_34 = new System.Windows.Forms.TextBox();
            this.lbl2_34 = new System.Windows.Forms.Label();
            this.lbl3_34 = new System.Windows.Forms.Label();
            this.btn1_34 = new System.Windows.Forms.Button();
            this.lbl4_34 = new System.Windows.Forms.Label();
            this.txt3_34 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1_34 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1_34
            // 
            this.lbl1_34.AutoSize = true;
            this.lbl1_34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl1_34.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_34.Location = new System.Drawing.Point(87, 27);
            this.lbl1_34.Name = "lbl1_34";
            this.lbl1_34.Size = new System.Drawing.Size(157, 22);
            this.lbl1_34.TabIndex = 1;
            this.lbl1_34.Text = "Solid Cylinder";
            // 
            // txt1_34
            // 
            this.txt1_34.Location = new System.Drawing.Point(200, 84);
            this.txt1_34.Name = "txt1_34";
            this.txt1_34.Size = new System.Drawing.Size(100, 20);
            this.txt1_34.TabIndex = 2;
            this.txt1_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt1_34.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_validating);
            // 
            // txt2_34
            // 
            this.txt2_34.Location = new System.Drawing.Point(200, 128);
            this.txt2_34.Name = "txt2_34";
            this.txt2_34.Size = new System.Drawing.Size(100, 20);
            this.txt2_34.TabIndex = 3;
            this.txt2_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt2_34.Validating += new System.ComponentModel.CancelEventHandler(this.txt2_validating);
            // 
            // lbl2_34
            // 
            this.lbl2_34.AutoSize = true;
            this.lbl2_34.ForeColor = System.Drawing.Color.Black;
            this.lbl2_34.Location = new System.Drawing.Point(143, 87);
            this.lbl2_34.Name = "lbl2_34";
            this.lbl2_34.Size = new System.Drawing.Size(40, 13);
            this.lbl2_34.TabIndex = 4;
            this.lbl2_34.Text = "Radius";
            // 
            // lbl3_34
            // 
            this.lbl3_34.AutoSize = true;
            this.lbl3_34.ForeColor = System.Drawing.Color.Black;
            this.lbl3_34.Location = new System.Drawing.Point(145, 128);
            this.lbl3_34.Name = "lbl3_34";
            this.lbl3_34.Size = new System.Drawing.Size(38, 13);
            this.lbl3_34.TabIndex = 5;
            this.lbl3_34.Text = "Height";
            // 
            // btn1_34
            // 
            this.btn1_34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1_34.Location = new System.Drawing.Point(211, 154);
            this.btn1_34.Name = "btn1_34";
            this.btn1_34.Size = new System.Drawing.Size(75, 23);
            this.btn1_34.TabIndex = 6;
            this.btn1_34.Text = "Submit";
            this.btn1_34.UseVisualStyleBackColor = true;
            this.btn1_34.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lbl4_34
            // 
            this.lbl4_34.AutoSize = true;
            this.lbl4_34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4_34.ForeColor = System.Drawing.Color.Black;
            this.lbl4_34.Location = new System.Drawing.Point(72, 207);
            this.lbl4_34.Name = "lbl4_34";
            this.lbl4_34.Size = new System.Drawing.Size(82, 16);
            this.lbl4_34.TabIndex = 7;
            this.lbl4_34.Text = "Surface Area";
            // 
            // txt3_34
            // 
            this.txt3_34.Location = new System.Drawing.Point(200, 203);
            this.txt3_34.Name = "txt3_34";
            this.txt3_34.Size = new System.Drawing.Size(100, 20);
            this.txt3_34.TabIndex = 9;
            this.txt3_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(305, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(306, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(305, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "(m)^2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox1_34
            // 
            this.pictureBox1_34.Image = global::Volume_and_Surface_Area_Calculator.Properties.Resources.cylinder;
            this.pictureBox1_34.Location = new System.Drawing.Point(23, 75);
            this.pictureBox1_34.Name = "pictureBox1_34";
            this.pictureBox1_34.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_34.TabIndex = 0;
            this.pictureBox1_34.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 243);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt3_34);
            this.Controls.Add(this.lbl4_34);
            this.Controls.Add(this.btn1_34);
            this.Controls.Add(this.lbl3_34);
            this.Controls.Add(this.lbl2_34);
            this.Controls.Add(this.txt2_34);
            this.Controls.Add(this.txt1_34);
            this.Controls.Add(this.lbl1_34);
            this.Controls.Add(this.pictureBox1_34);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Solid Cylinder";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_34;
        private System.Windows.Forms.Label lbl1_34;
        private System.Windows.Forms.TextBox txt1_34;
        private System.Windows.Forms.TextBox txt2_34;
        private System.Windows.Forms.TextBox txt3_34;
        private System.Windows.Forms.Label lbl4_34;
        private System.Windows.Forms.Button btn1_34;
        private System.Windows.Forms.Label lbl3_34;
        private System.Windows.Forms.Label lbl2_34;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}