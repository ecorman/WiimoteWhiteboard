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
            this.pbBattery = new System.Windows.Forms.ProgressBar();
            this.lblBattery = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCursorControl = new System.Windows.Forms.CheckBox();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.lblIRvisible = new System.Windows.Forms.Label();
            this.lblTrackingUtil = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBattery
            // 
            this.pbBattery.Location = new System.Drawing.Point(11, 25);
            this.pbBattery.Margin = new System.Windows.Forms.Padding(4);
            this.pbBattery.Maximum = 200;
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(86, 28);
            this.pbBattery.Step = 1;
            this.pbBattery.TabIndex = 6;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(105, 25);
            this.lblBattery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(46, 17);
            this.lblBattery.TabIndex = 9;
            this.lblBattery.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbBattery);
            this.groupBox4.Controls.Add(this.lblBattery);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(161, 57);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wiimote Battery";
            // 
            // cbCursorControl
            // 
            this.cbCursorControl.AutoSize = true;
            this.cbCursorControl.Location = new System.Drawing.Point(24, 142);
            this.cbCursorControl.Name = "cbCursorControl";
            this.cbCursorControl.Size = new System.Drawing.Size(121, 21);
            this.cbCursorControl.TabIndex = 22;
            this.cbCursorControl.Text = "Cursor Control";
            this.cbCursorControl.UseVisualStyleBackColor = true;
            this.cbCursorControl.CheckedChanged += new System.EventHandler(this.cbCursorControl_CheckedChanged);
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Location = new System.Drawing.Point(12, 178);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(161, 64);
            this.btnCalibrate.TabIndex = 24;
            this.btnCalibrate.Text = "Calibrate Location (Wiimote A)";
            this.btnCalibrate.UseVisualStyleBackColor = true;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // lblIRvisible
            // 
            this.lblIRvisible.AutoSize = true;
            this.lblIRvisible.Location = new System.Drawing.Point(14, 87);
            this.lblIRvisible.Name = "lblIRvisible";
            this.lblIRvisible.Size = new System.Drawing.Size(105, 17);
            this.lblIRvisible.TabIndex = 25;
            this.lblIRvisible.Text = "Visible IR dots: ";
            // 
            // lblTrackingUtil
            // 
            this.lblTrackingUtil.AutoSize = true;
            this.lblTrackingUtil.Location = new System.Drawing.Point(14, 113);
            this.lblTrackingUtil.Name = "lblTrackingUtil";
            this.lblTrackingUtil.Size = new System.Drawing.Size(146, 17);
            this.lblTrackingUtil.TabIndex = 26;
            this.lblTrackingUtil.Text = "Tracking Utilization: --";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 257);
            this.Controls.Add(this.lblTrackingUtil);
            this.Controls.Add(this.lblIRvisible);
            this.Controls.Add(this.btnCalibrate);
            this.Controls.Add(this.cbCursorControl);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wiimote Whiteboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.ProgressBar pbBattery;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbCursorControl;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.Label lblIRvisible;
        private System.Windows.Forms.Label lblTrackingUtil;
	}
}

