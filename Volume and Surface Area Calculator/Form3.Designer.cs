namespace Volume_and_Surface_Area_Calculator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbl1_34 = new System.Windows.Forms.Label();
            this.lbl2_34 = new System.Windows.Forms.Label();
            this.lbl3_34 = new System.Windows.Forms.Label();
            this.lbl4_34 = new System.Windows.Forms.Label();
            this.txt1_34 = new System.Windows.Forms.TextBox();
            this.txt3_34 = new System.Windows.Forms.TextBox();
            this.txt4_34 = new System.Windows.Forms.TextBox();
            this.btn1_34 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1_34 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1_34
            // 
            this.lbl1_34.AutoSize = true;
            this.lbl1_34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl1_34.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_34.ForeColor = System.Drawing.Color.Blue;
            this.lbl1_34.Location = new System.Drawing.Point(128, 22);
            this.lbl1_34.Name = "lbl1_34";
            this.lbl1_34.Size = new System.Drawing.Size(141, 22);
            this.lbl1_34.TabIndex = 1;
            this.lbl1_34.Text = "Solid Sphare";
            // 
            // lbl2_34
            // 
            this.lbl2_34.AutoSize = true;
            this.lbl2_34.Location = new System.Drawing.Point(146, 82);
            this.lbl2_34.Name = "lbl2_34";
            this.lbl2_34.Size = new System.Drawing.Size(40, 13);
            this.lbl2_34.TabIndex = 2;
            this.lbl2_34.Text = "Radius";
            // 
            // lbl3_34
            // 
            this.lbl3_34.AutoSize = true;
            this.lbl3_34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3_34.Location = new System.Drawing.Point(55, 183);
            this.lbl3_34.Name = "lbl3_34";
            this.lbl3_34.Size = new System.Drawing.Size(82, 16);
            this.lbl3_34.TabIndex = 3;
            this.lbl3_34.Text = "Surface Area";
            // 
            // lbl4_34
            // 
            this.lbl4_34.AutoSize = true;
            this.lbl4_34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4_34.Location = new System.Drawing.Point(67, 223);
            this.lbl4_34.Name = "lbl4_34";
            this.lbl4_34.Size = new System.Drawing.Size(51, 16);
            this.lbl4_34.TabIndex = 4;
            this.lbl4_34.Text = "Volume";
            // 
            // txt1_34
            // 
            this.txt1_34.Location = new System.Drawing.Point(204, 79);
            this.txt1_34.Name = "txt1_34";
            this.txt1_34.Size = new System.Drawing.Size(100, 20);
            this.txt1_34.TabIndex = 5;
            this.txt1_34.TextChanged += new System.EventHandler(this.txt1_validating);
            // 
            // txt3_34
            // 
            this.txt3_34.Location = new System.Drawing.Point(180, 183);
            this.txt3_34.Name = "txt3_34";
            this.txt3_34.Size = new System.Drawing.Size(100, 20);
            this.txt3_34.TabIndex = 5;
            // 
            // txt4_34
            // 
            this.txt4_34.Location = new System.Drawing.Point(180, 223);
            this.txt4_34.Name = "txt4_34";
            this.txt4_34.Size = new System.Drawing.Size(100, 20);
            this.txt4_34.TabIndex = 5;
            // 
            // btn1_34
            // 
            this.btn1_34.Location = new System.Drawing.Point(194, 124);
            this.btn1_34.Name = "btn1_34";
            this.btn1_34.Size = new System.Drawing.Size(75, 23);
            this.btn1_34.TabIndex = 6;
            this.btn1_34.Text = "Submit";
            this.btn1_34.UseVisualStyleBackColor = true;
            this.btn1_34.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1_34
            // 
            this.pictureBox1_34.Image = global::Volume_and_Surface_Area_Calculator.Properties.Resources.ball;
            this.pictureBox1_34.Location = new System.Drawing.Point(24, 62);
            this.pictureBox1_34.Name = "pictureBox1_34";
            this.pictureBox1_34.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_34.TabIndex = 0;
            this.pictureBox1_34.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "(m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "(m)^2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "(m)^3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 264);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn1_34);
            this.Controls.Add(this.txt4_34);
            this.Controls.Add(this.txt3_34);
            this.Controls.Add(this.txt1_34);
            this.Controls.Add(this.lbl4_34);
            this.Controls.Add(this.lbl3_34);
            this.Controls.Add(this.lbl2_34);
            this.Controls.Add(this.lbl1_34);
            this.Controls.Add(this.pictureBox1_34);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Solid Sphare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_34;
        private System.Windows.Forms.Label lbl1_34;
        private System.Windows.Forms.Label lbl2_34;
        private System.Windows.Forms.Label lbl3_34;
        private System.Windows.Forms.Label lbl4_34;
        private System.Windows.Forms.TextBox txt1_34;
        private System.Windows.Forms.TextBox txt3_34;
        private System.Windows.Forms.TextBox txt4_34;
        private System.Windows.Forms.Button btn1_34;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}