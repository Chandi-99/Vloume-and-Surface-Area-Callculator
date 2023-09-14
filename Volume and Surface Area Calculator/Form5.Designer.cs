namespace Volume_and_Surface_Area_Calculator
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lbl1_34 = new System.Windows.Forms.Label();
            this.lbl2_34 = new System.Windows.Forms.Label();
            this.lbl3_34 = new System.Windows.Forms.Label();
            this.lbl4_34 = new System.Windows.Forms.Label();
            this.lbl5_34 = new System.Windows.Forms.Label();
            this.btn1_34 = new System.Windows.Forms.Button();
            this.txt1_34 = new System.Windows.Forms.TextBox();
            this.txt2_34 = new System.Windows.Forms.TextBox();
            this.txt3_34 = new System.Windows.Forms.TextBox();
            this.txt4_34 = new System.Windows.Forms.TextBox();
            this.pictureBox1_34 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1_34
            // 
            this.lbl1_34.AutoSize = true;
            this.lbl1_34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl1_34.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_34.Location = new System.Drawing.Point(27, 25);
            this.lbl1_34.Name = "lbl1_34";
            this.lbl1_34.Size = new System.Drawing.Size(291, 22);
            this.lbl1_34.TabIndex = 1;
            this.lbl1_34.Text = "Solid Square Base Pyramide";
            // 
            // lbl2_34
            // 
            this.lbl2_34.AutoSize = true;
            this.lbl2_34.ForeColor = System.Drawing.Color.Black;
            this.lbl2_34.Location = new System.Drawing.Point(143, 83);
            this.lbl2_34.Name = "lbl2_34";
            this.lbl2_34.Size = new System.Drawing.Size(59, 13);
            this.lbl2_34.TabIndex = 2;
            this.lbl2_34.Text = "Base Edge";
            // 
            // lbl3_34
            // 
            this.lbl3_34.AutoSize = true;
            this.lbl3_34.ForeColor = System.Drawing.Color.Black;
            this.lbl3_34.Location = new System.Drawing.Point(146, 117);
            this.lbl3_34.Name = "lbl3_34";
            this.lbl3_34.Size = new System.Drawing.Size(38, 13);
            this.lbl3_34.TabIndex = 3;
            this.lbl3_34.Text = "Height";
            // 
            // lbl4_34
            // 
            this.lbl4_34.AutoSize = true;
            this.lbl4_34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4_34.ForeColor = System.Drawing.Color.Black;
            this.lbl4_34.Location = new System.Drawing.Point(42, 188);
            this.lbl4_34.Name = "lbl4_34";
            this.lbl4_34.Size = new System.Drawing.Size(82, 16);
            this.lbl4_34.TabIndex = 4;
            this.lbl4_34.Text = "Surface Area";
            // 
            // lbl5_34
            // 
            this.lbl5_34.AutoSize = true;
            this.lbl5_34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5_34.ForeColor = System.Drawing.Color.Black;
            this.lbl5_34.Location = new System.Drawing.Point(42, 230);
            this.lbl5_34.Name = "lbl5_34";
            this.lbl5_34.Size = new System.Drawing.Size(51, 16);
            this.lbl5_34.TabIndex = 5;
            this.lbl5_34.Text = "Volume";
            // 
            // btn1_34
            // 
            this.btn1_34.ForeColor = System.Drawing.Color.Black;
            this.btn1_34.Location = new System.Drawing.Point(230, 143);
            this.btn1_34.Name = "btn1_34";
            this.btn1_34.Size = new System.Drawing.Size(75, 23);
            this.btn1_34.TabIndex = 6;
            this.btn1_34.Text = "Submit";
            this.btn1_34.UseVisualStyleBackColor = true;
            this.btn1_34.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txt1_34
            // 
            this.txt1_34.Location = new System.Drawing.Point(218, 83);
            this.txt1_34.Name = "txt1_34";
            this.txt1_34.Size = new System.Drawing.Size(100, 20);
            this.txt1_34.TabIndex = 7;
            this.txt1_34.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_validating);
            // 
            // txt2_34
            // 
            this.txt2_34.Location = new System.Drawing.Point(218, 117);
            this.txt2_34.Name = "txt2_34";
            this.txt2_34.Size = new System.Drawing.Size(100, 20);
            this.txt2_34.TabIndex = 8;
            this.txt2_34.TextChanged += new System.EventHandler(this.txt2_validating);
            // 
            // txt3_34
            // 
            this.txt3_34.Location = new System.Drawing.Point(177, 184);
            this.txt3_34.Name = "txt3_34";
            this.txt3_34.Size = new System.Drawing.Size(100, 20);
            this.txt3_34.TabIndex = 9;
            // 
            // txt4_34
            // 
            this.txt4_34.Location = new System.Drawing.Point(177, 230);
            this.txt4_34.Name = "txt4_34";
            this.txt4_34.Size = new System.Drawing.Size(100, 20);
            this.txt4_34.TabIndex = 10;
            // 
            // pictureBox1_34
            // 
            this.pictureBox1_34.Image = global::Volume_and_Surface_Area_Calculator.Properties.Resources.square_pyramid;
            this.pictureBox1_34.Location = new System.Drawing.Point(24, 69);
            this.pictureBox1_34.Name = "pictureBox1_34";
            this.pictureBox1_34.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_34.TabIndex = 0;
            this.pictureBox1_34.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(324, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(324, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(283, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "(m)^2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(283, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "(m)^3";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 283);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt4_34);
            this.Controls.Add(this.txt3_34);
            this.Controls.Add(this.txt2_34);
            this.Controls.Add(this.txt1_34);
            this.Controls.Add(this.btn1_34);
            this.Controls.Add(this.lbl5_34);
            this.Controls.Add(this.lbl4_34);
            this.Controls.Add(this.lbl3_34);
            this.Controls.Add(this.lbl2_34);
            this.Controls.Add(this.lbl1_34);
            this.Controls.Add(this.pictureBox1_34);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Solid Square Base Pyramide";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_34;
        private System.Windows.Forms.Label lbl1_34;
        private System.Windows.Forms.Label lbl2_34;
        private System.Windows.Forms.Label lbl3_34;
        private System.Windows.Forms.Label lbl4_34;
        private System.Windows.Forms.Label lbl5_34;
        private System.Windows.Forms.TextBox txt4_34;
        private System.Windows.Forms.TextBox txt3_34;
        private System.Windows.Forms.TextBox txt2_34;
        private System.Windows.Forms.TextBox txt1_34;
        private System.Windows.Forms.Button btn1_34;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}