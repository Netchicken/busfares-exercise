namespace busfares_exercise
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAshFare = new System.Windows.Forms.TextBox();
            this.txtDunFare = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAshburton = new System.Windows.Forms.Label();
            this.lboutput = new System.Windows.Forms.ListBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDisabled = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(350, 34);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(46, 26);
            this.txtAge.TabIndex = 1;
            // 
            // txtAshFare
            // 
            this.txtAshFare.Location = new System.Drawing.Point(30, 29);
            this.txtAshFare.Name = "txtAshFare";
            this.txtAshFare.Size = new System.Drawing.Size(96, 26);
            this.txtAshFare.TabIndex = 2;
            this.txtAshFare.Text = "17.99";
            // 
            // txtDunFare
            // 
            this.txtDunFare.Location = new System.Drawing.Point(222, 29);
            this.txtDunFare.Name = "txtDunFare";
            this.txtDunFare.Size = new System.Drawing.Size(115, 26);
            this.txtDunFare.TabIndex = 6;
            this.txtDunFare.Text = "35.66";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAshburton);
            this.panel1.Controls.Add(this.txtDunFare);
            this.panel1.Controls.Add(this.txtAshFare);
            this.panel1.Location = new System.Drawing.Point(315, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 77);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dunedin";
            // 
            // lblAshburton
            // 
            this.lblAshburton.AutoSize = true;
            this.lblAshburton.Location = new System.Drawing.Point(27, 3);
            this.lblAshburton.Name = "lblAshburton";
            this.lblAshburton.Size = new System.Drawing.Size(83, 20);
            this.lblAshburton.TabIndex = 11;
            this.lblAshburton.Text = "Ashburton";
            // 
            // lboutput
            // 
            this.lboutput.FormattingEnabled = true;
            this.lboutput.ItemHeight = 20;
            this.lboutput.Location = new System.Drawing.Point(18, 328);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(709, 164);
            this.lboutput.TabIndex = 8;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(404, 111);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(55, 26);
            this.txtdiscount.TabIndex = 9;
            this.txtdiscount.Text = "0.20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Age";
            // 
            // cbxDisabled
            // 
            this.cbxDisabled.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisabled.Location = new System.Drawing.Point(3, 68);
            this.cbxDisabled.Name = "cbxDisabled";
            this.cbxDisabled.Size = new System.Drawing.Size(478, 51);
            this.cbxDisabled.TabIndex = 14;
            this.cbxDisabled.Text = "is the passenger Disabled?";
            this.cbxDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxDisabled.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.cbxDisabled);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(315, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 122);
            this.panel2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bus Company fares";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImage = global::busfares_exercise.Resource1.bus_7;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(18, 69);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(255, 195);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Fares";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(816, 520);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAshFare;
        private System.Windows.Forms.TextBox txtDunFare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAshburton;
        private System.Windows.Forms.ListBox lboutput;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxDisabled;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}

