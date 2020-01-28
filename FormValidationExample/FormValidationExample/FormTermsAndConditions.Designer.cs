namespace FormValidationExample
{
	partial class FormTermsAndConditions
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
			this.tbTermsAndConditions = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbTermsAndConditions
			// 
			this.tbTermsAndConditions.Location = new System.Drawing.Point(13, 13);
			this.tbTermsAndConditions.Multiline = true;
			this.tbTermsAndConditions.Name = "tbTermsAndConditions";
			this.tbTermsAndConditions.ReadOnly = true;
			this.tbTermsAndConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbTermsAndConditions.Size = new System.Drawing.Size(579, 180);
			this.tbTermsAndConditions.TabIndex = 0;
			this.tbTermsAndConditions.TabStop = false;
			// 
			// FormTermsAndConditions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 208);
			this.Controls.Add(this.tbTermsAndConditions);
			this.Name = "FormTermsAndConditions";
			this.Text = "FormTermsAndConditions";
			this.Load += new System.EventHandler(this.FormTermsAndConditions_Load);
			this.Resize += new System.EventHandler(this.FormTermsAndConditions_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbTermsAndConditions;
	}
}