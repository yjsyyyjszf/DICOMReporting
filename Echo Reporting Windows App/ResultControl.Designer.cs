﻿namespace Echo_Reporting_Windows_App {
	partial class ResultControl {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.ResultTitleLabel = new System.Windows.Forms.Label();
			this.ResultUnitLabel = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ResultValueTextBox = new System.Windows.Forms.TextBox();
			this.ZScoreLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// ResultTitleLabel
			// 
			this.ResultTitleLabel.AutoSize = true;
			this.ResultTitleLabel.Location = new System.Drawing.Point(-2, 2);
			this.ResultTitleLabel.Name = "ResultTitleLabel";
			this.ResultTitleLabel.Size = new System.Drawing.Size(83, 13);
			this.ResultTitleLabel.TabIndex = 0;
			this.ResultTitleLabel.Text = "ResultTitleLabel";
			// 
			// ResultUnitLabel
			// 
			this.ResultUnitLabel.AutoSize = true;
			this.ResultUnitLabel.Location = new System.Drawing.Point(78, 22);
			this.ResultUnitLabel.Name = "ResultUnitLabel";
			this.ResultUnitLabel.Size = new System.Drawing.Size(29, 13);
			this.ResultUnitLabel.TabIndex = 1;
			this.ResultUnitLabel.Text = "RUL";
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// ResultValueTextBox
			// 
			this.errorProvider1.SetIconAlignment(this.ResultValueTextBox, System.Windows.Forms.ErrorIconAlignment.TopRight);
			this.ResultValueTextBox.Location = new System.Drawing.Point(30, 18);
			this.ResultValueTextBox.Name = "ResultValueTextBox";
			this.ResultValueTextBox.Size = new System.Drawing.Size(49, 20);
			this.ResultValueTextBox.TabIndex = 3;
			this.ResultValueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// ZScoreLabel
			// 
			this.ZScoreLabel.AutoSize = true;
			this.ZScoreLabel.Location = new System.Drawing.Point(146, 22);
			this.ZScoreLabel.Name = "ZScoreLabel";
			this.ZScoreLabel.Size = new System.Drawing.Size(54, 13);
			this.ZScoreLabel.TabIndex = 4;
			this.ZScoreLabel.Text = "ZScore: 0";
			// 
			// ResultControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.ZScoreLabel);
			this.Controls.Add(this.ResultValueTextBox);
			this.Controls.Add(this.ResultUnitLabel);
			this.Controls.Add(this.ResultTitleLabel);
			this.Name = "ResultControl";
			this.Size = new System.Drawing.Size(250, 39);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ResultTitleLabel;
		private System.Windows.Forms.Label ResultUnitLabel;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox ResultValueTextBox;
		private System.Windows.Forms.Label ZScoreLabel;
	}
}