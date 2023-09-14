namespace Volume_and_Surface_Area_Calculator
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lbl1_34 = new System.Windows.Forms.Label();
            this.btn1_34 = new System.Windows.Forms.Button();
            this.btn2_34 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1_34
            // 
            this.lbl1_34.AutoSize = true;
            this.lbl1_34.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl1_34.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl1_34.Location = new System.Drawing.Point(53, 40);
            this.lbl1_34.Name = "lbl1_34";
            this.lbl1_34.Size = new System.Drawing.Size(203, 18);
            this.lbl1_34.TabIndex = 0;
            this.lbl1_34.Text = "Select the area you want to find";
            // 
            // btn1_34
            // 
            this.btn1_34.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1_34.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_34.Location = new System.Drawing.Point(111, 83);
            this.btn1_34.Name = "btn1_34";
            this.btn1_34.Size = new System.Drawing.Size(75, 45);
            this.btn1_34.TabIndex = 1;
            this.btn1_34.Text = "Surface Area";
            this.btn1_34.UseVisualStyleBackColor = false;
            this.btn1_34.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2_34
            // 
            this.btn2_34.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2_34.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_34.Location = new System.Drawing.Point(111, 147);
            this.btn2_34.Name = "btn2_34";
            this.btn2_34.Size = new System.Drawing.Size(75, 23);
            this.btn2_34.TabIndex = 2;
            this.btn2_34.Text = "Volume";
            this.btn2_34.UseVisualStyleBackColor = false;
            this.btn2_34.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(298, 211);
            this.Controls.Add(this.btn2_34);
            this.Controls.Add(this.btn1_34);
            this.Controls.Add(this.lbl1_34);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Solid Cone";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1_34;
        private System.Windows.Forms.Button btn1_34;
        private System.Windows.Forms.Button btn2_34;
    }
}