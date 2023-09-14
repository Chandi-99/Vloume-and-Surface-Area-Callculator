namespace Volume_and_Surface_Area_Calculator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txt1_34 = new System.Windows.Forms.TextBox();
            this.txt2_34 = new System.Windows.Forms.TextBox();
            this.txt3_34 = new System.Windows.Forms.TextBox();
            this.label1_34 = new System.Windows.Forms.Label();
            this.lbl1_34 = new System.Windows.Forms.Label();
            this.lbl2_34 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl3_34 = new System.Windows.Forms.Label();
            this.btn1_34 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1_34 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1_34
            // 
            this.txt1_34.Location = new System.Drawing.Point(174, 60);
            this.txt1_34.Name = "txt1_34";
            this.txt1_34.Size = new System.Drawing.Size(109, 20);
            this.txt1_34.TabIndex = 1;
            this.txt1_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt1_34.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_validating);
            // 
            // txt2_34
            // 
            this.txt2_34.Location = new System.Drawing.Point(174, 96);
            this.txt2_34.Name = "txt2_34";
            this.txt2_34.Size = new System.Drawing.Size(109, 20);
            this.txt2_34.TabIndex = 1;
            this.txt2_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt2_34.Validating += new System.ComponentModel.CancelEventHandler(this.txt2_validating);
            // 
            // txt3_34
            // 
            this.txt3_34.Location = new System.Drawing.Point(166, 175);
            this.txt3_34.Name = "txt3_34";
            this.txt3_34.Size = new System.Drawing.Size(100, 20);
            this.txt3_34.TabIndex = 1;
            this.txt3_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1_34
            // 
            this.label1_34.AutoSize = true;
            this.label1_34.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1_34.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_34.Location = new System.Drawing.Point(110, 9);
            this.label1_34.Name = "label1_34";
            this.label1_34.Size = new System.Drawing.Size(115, 22);
            this.label1_34.TabIndex = 2;
            this.label1_34.Text = "Solid Cone";
            // 
            // lbl1_34
            // 
            this.lbl1_34.AutoSize = true;
            this.lbl1_34.ForeColor = System.Drawing.Color.Black;
            this.lbl1_34.Location = new System.Drawing.Point(98, 67);
            this.lbl1_34.Name = "lbl1_34";
            this.lbl1_34.Size = new System.Drawing.Size(67, 13);
            this.lbl1_34.TabIndex = 3;
            this.lbl1_34.Text = "Base Radius";
            // 
            // lbl2_34
            // 
            this.lbl2_34.AutoSize = true;
            this.lbl2_34.ForeColor = System.Drawing.Color.Black;
            this.lbl2_34.Location = new System.Drawing.Point(111, 103);
            this.lbl2_34.Name = "lbl2_34";
            this.lbl2_34.Size = new System.Drawing.Size(38, 13);
            this.lbl2_34.TabIndex = 4;
            this.lbl2_34.Text = "Height";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lbl3_34
            // 
            this.lbl3_34.AutoSize = true;
            this.lbl3_34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3_34.ForeColor = System.Drawing.Color.Black;
            this.lbl3_34.Location = new System.Drawing.Point(47, 175);
            this.lbl3_34.Name = "lbl3_34";
            this.lbl3_34.Size = new System.Drawing.Size(82, 16);
            this.lbl3_34.TabIndex = 5;
            this.lbl3_34.Text = "Surface Area";
            // 
            // btn1_34
            // 
            this.btn1_34.ForeColor = System.Drawing.Color.Black;
            this.btn1_34.Location = new System.Drawing.Point(191, 122);
            this.btn1_34.Name = "btn1_34";
            this.btn1_34.Size = new System.Drawing.Size(75, 23);
            this.btn1_34.TabIndex = 7;
            this.btn1_34.Text = "Submit";
            this.btn1_34.UseVisualStyleBackColor = true;
            this.btn1_34.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(284, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "(m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(284, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(m)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(272, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(m)^2";
            // 
            // pictureBox1_34
            // 
            this.pictureBox1_34.Image = global::Volume_and_Surface_Area_Calculator.Properties.Resources.cone;
            this.pictureBox1_34.Location = new System.Drawing.Point(21, 46);
            this.pictureBox1_34.Name = "pictureBox1_34";
            this.pictureBox1_34.Size = new System.Drawing.Size(73, 81);
            this.pictureBox1_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_34.TabIndex = 0;
            this.pictureBox1_34.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 235);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn1_34);
            this.Controls.Add(this.lbl3_34);
            this.Controls.Add(this.lbl2_34);
            this.Controls.Add(this.lbl1_34);
            this.Controls.Add(this.label1_34);
            this.Controls.Add(this.txt3_34);
            this.Controls.Add(this.txt2_34);
            this.Controls.Add(this.txt1_34);
            this.Controls.Add(this.pictureBox1_34);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Solid Cone-Surface Area";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_34)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_34;
        private System.Windows.Forms.TextBox txt1_34;
        private System.Windows.Forms.TextBox txt2_34;
        private System.Windows.Forms.TextBox txt3_34;
        private System.Windows.Forms.Label label1_34;
        private System.Windows.Forms.Label lbl1_34;
        private System.Windows.Forms.Label lbl2_34;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn1_34;
        private System.Windows.Forms.Label lbl3_34;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}