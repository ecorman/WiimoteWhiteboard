namespace WiimoteWhiteboard
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

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbBattery = new System.Windows.Forms.ProgressBar();
            this.lblBattery = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCursorControl = new System.Windows.Forms.CheckBox();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.lblIRvisible = new System.Windows.Forms.Label();
            this.lblTrackingUtil = new System.Windows.Forms.Label();
            this.pbIR = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBattery
            // 
            this.pbBattery.Location = new System.Drawing.Point(8, 17);
            this.pbBattery.Maximum = 200;
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(78, 23);
            this.pbBattery.Step = 1;
            this.pbBattery.TabIndex = 6;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(92, 17);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(35, 13);
            this.lblBattery.TabIndex = 9;
            this.lblBattery.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbBattery);
            this.groupBox4.Controls.Add(this.lblBattery);
            this.groupBox4.Location = new System.Drawing.Point(10, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 46);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wiimote Battery";
            //
            // cbCursorControl
            // 
            this.cbCursorControl.AutoSize = true;
            this.cbCursorControl.Location = new System.Drawing.Point(11, 235);
            this.cbCursorControl.Margin = new System.Windows.Forms.Padding(2);
            this.cbCursorControl.Name = "cbCursorControl";
            this.cbCursorControl.Size = new System.Drawing.Size(92, 17);
            this.cbCursorControl.TabIndex = 22;
            this.cbCursorControl.Text = "Cursor Control";
            this.cbCursorControl.UseVisualStyleBackColor = true;
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Location = new System.Drawing.Point(10, 179);
            this.btnCalibrate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(121, 52);
            this.btnCalibrate.TabIndex = 24;
            this.btnCalibrate.Text = "Calibrate Location (Wiimote A)";
            this.btnCalibrate.UseVisualStyleBackColor = true;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // lblIRvisible
            // 
            this.lblIRvisible.AutoSize = true;
            this.lblIRvisible.Location = new System.Drawing.Point(7, 60);
            this.lblIRvisible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIRvisible.Name = "lblIRvisible";
            this.lblIRvisible.Size = new System.Drawing.Size(80, 13);
            this.lblIRvisible.TabIndex = 25;
            this.lblIRvisible.Text = "Visible IR dots: ";
            // 
            // lblTrackingUtil
            // 
            this.lblTrackingUtil.AutoSize = true;
            this.lblTrackingUtil.Location = new System.Drawing.Point(7, 160);
            this.lblTrackingUtil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrackingUtil.Name = "lblTrackingUtil";
            this.lblTrackingUtil.Size = new System.Drawing.Size(109, 13);
            this.lblTrackingUtil.TabIndex = 26;
            this.lblTrackingUtil.Text = "Tracking Utilization: --";
            // 
            // pbIR
            // 
            this.pbIR.Image = ((System.Drawing.Image)(resources.GetObject("pbIR.Image")));
            this.pbIR.Location = new System.Drawing.Point(148, 186);
            this.pbIR.Name = "pbIR";
            this.pbIR.Size = new System.Drawing.Size(67, 66);
            this.pbIR.TabIndex = 29;
            this.pbIR.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.lblZ);
            this.groupBox1.Location = new System.Drawing.Point(10, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 72);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wiimote Accel";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(8, 20);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(8, 36);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(8, 52);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(14, 13);
            this.lblZ.TabIndex = 2;
            this.lblZ.Text = "Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalibrate);
            this.Controls.Add(this.pbIR);
            this.Controls.Add(this.lblTrackingUtil);
            this.Controls.Add(this.lblIRvisible);
            this.Controls.Add(this.cbCursorControl);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wiimote Whiteboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        private System.Windows.Forms.ProgressBar pbBattery;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbCursorControl;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.Label lblIRvisible;
        private System.Windows.Forms.Label lblTrackingUtil;
        private System.Windows.Forms.PictureBox pbIR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
	}
}

