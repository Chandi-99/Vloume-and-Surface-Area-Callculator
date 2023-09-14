namespace Volume_and_Surface_Area_Calculator
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.pictureBox1_34 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1_34 = new System.Windows.Forms.TextBox();
            this.txt2_34 = new System.Windows.Forms.TextBox();
            this.btn1_34 = new System.Windows.Forms.Button();
            this.lbl2_34 = new System.Windows.Forms.Label();
            this.lbl3_34 = new System.Windows.Forms.Label();
            this.lbl4_34 = new System.Windows.Forms.Label();
            this.txt4_34 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1_34
            // 
            this.pictureBox1_34.Image = global::Volume_and_Surface_Area_Calculator.Properties.Resources.cone1;
            this.pictureBox1_34.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1_34.Name = "pictureBox1_34";
            this.pictureBox1_34.Size = new System.Drawing.Size(79, 80);
            this.pictureBox1_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_34.TabIndex = 0;
            this.pictureBox1_34.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOLID CONE";
            // 
            // txt1_34
            // 
            this.txt1_34.Location = new System.Drawing.Point(185, 55);
            this.txt1_34.Name = "txt1_34";
            this.txt1_34.Size = new System.Drawing.Size(100, 20);
            this.txt1_34.TabIndex = 2;
            this.txt1_34.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_Validating);
            // 
            // txt2_34
            // 
            this.txt2_34.Location = new System.Drawing.Point(185, 88);
            this.txt2_34.Name = "txt2_34";
            this.txt2_34.Size = new System.Drawing.Size(100, 20);
            this.txt2_34.TabIndex = 3;
            this.txt2_34.Validating += new System.ComponentModel.CancelEventHandler(this.txt2_Validating);
            // 
            // btn1_34
            // 
            this.btn1_34.Location = new System.Drawing.Point(201, 114);
            this.btn1_34.Name = "btn1_34";
            this.btn1_34.Size = new System.Drawing.Size(75, 23);
            this.btn1_34.TabIndex = 4;
            this.btn1_34.Text = "Submit";
            this.btn1_34.UseVisualStyleBackColor = true;
            this.btn1_34.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lbl2_34
            // 
            this.lbl2_34.AutoSize = true;
            this.lbl2_34.Location = new System.Drawing.Point(110, 58);
            this.lbl2_34.Name = "lbl2_34";
            this.lbl2_34.Size = new System.Drawing.Size(67, 13);
            this.lbl2_34.TabIndex = 5;
            this.lbl2_34.Text = "Base Radius";
            // 
            // lbl3_34
            // 
            this.lbl3_34.AutoSize = true;
            this.lbl3_34.Location = new System.Drawing.Point(110, 88);
            this.lbl3_34.Name = "lbl3_34";
            this.lbl3_34.Size = new System.Drawing.Size(38, 13);
            this.lbl3_34.TabIndex = 5;
            this.lbl3_34.Text = "Height";
            // 
            // lbl4_34
            // 
            this.lbl4_34.AutoSize = true;
            this.lbl4_34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4_34.Location = new System.Drawing.Point(46, 176);
            this.lbl4_34.Name = "lbl4_34";
            this.lbl4_34.Size = new System.Drawing.Size(54, 16);
            this.lbl4_34.TabIndex = 5;
            this.lbl4_34.Text = "Volume";
            // 
            // txt4_34
            // 
            this.txt4_34.Location = new System.Drawing.Point(167, 172);
            this.txt4_34.Name = "txt4_34";
            this.txt4_34.Size = new System.Drawing.Size(100, 20);
            this.txt4_34.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(291, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "(m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(291, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(273, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(m)^3";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 237);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt4_34);
            this.Controls.Add(this.lbl4_34);
            this.Controls.Add(this.lbl3_34);
            this.Controls.Add(this.lbl2_34);
            this.Controls.Add(this.btn1_34);
            this.Controls.Add(this.txt2_34);
            this.Controls.Add(this.txt1_34);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1_34);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Solid Cone-Volume";
            this.Click += new System.EventHandler(this.btnsubmit_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_34;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1_34;
        private System.Windows.Forms.TextBox txt2_34;
        private System.Windows.Forms.Button btn1_34;
        private System.Windows.Forms.Label lbl2_34;
        private System.Windows.Forms.Label lbl3_34;
        private System.Windows.Forms.Label lbl4_34;
        private System.Windows.Forms.TextBox txt4_34;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}