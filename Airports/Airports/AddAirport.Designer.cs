namespace Airports
{
	partial class AddAirport
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbAddAirportCity = new System.Windows.Forms.TextBox();
			this.tbAddAirportName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbAddAirportShortname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAddAirportSave = new System.Windows.Forms.Button();
			this.btnAddAirportCancel = new System.Windows.Forms.Button();
			this.errorProviderAddAirport = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAddAirport)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddAirportCancel);
			this.groupBox1.Controls.Add(this.btnAddAirportSave);
			this.groupBox1.Controls.Add(this.tbAddAirportShortname);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbAddAirportName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbAddAirportCity);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(263, 196);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Airport";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "City:";
			// 
			// tbAddAirportCity
			// 
			this.tbAddAirportCity.Location = new System.Drawing.Point(6, 37);
			this.tbAddAirportCity.Name = "tbAddAirportCity";
			this.tbAddAirportCity.Size = new System.Drawing.Size(232, 20);
			this.tbAddAirportCity.TabIndex = 1;
			this.tbAddAirportCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddAirportCity_Validating);
			// 
			// tbAddAirportName
			// 
			this.tbAddAirportName.Location = new System.Drawing.Point(6, 87);
			this.tbAddAirportName.Name = "tbAddAirportName";
			this.tbAddAirportName.Size = new System.Drawing.Size(232, 20);
			this.tbAddAirportName.TabIndex = 3;
			this.tbAddAirportName.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddAirportName_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name:";
			// 
			// tbAddAirportShortname
			// 
			this.tbAddAirportShortname.Location = new System.Drawing.Point(6, 137);
			this.tbAddAirportShortname.Name = "tbAddAirportShortname";
			this.tbAddAirportShortname.Size = new System.Drawing.Size(102, 20);
			this.tbAddAirportShortname.TabIndex = 5;
			this.tbAddAirportShortname.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddAirportShortcut_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Shortname:";
			// 
			// btnAddAirportSave
			// 
			this.btnAddAirportSave.Location = new System.Drawing.Point(6, 164);
			this.btnAddAirportSave.Name = "btnAddAirportSave";
			this.btnAddAirportSave.Size = new System.Drawing.Size(102, 23);
			this.btnAddAirportSave.TabIndex = 6;
			this.btnAddAirportSave.Text = "Save";
			this.btnAddAirportSave.UseVisualStyleBackColor = true;
			this.btnAddAirportSave.Click += new System.EventHandler(this.btnAddAirportSave_Click);
			// 
			// btnAddAirportCancel
			// 
			this.btnAddAirportCancel.Location = new System.Drawing.Point(136, 164);
			this.btnAddAirportCancel.Name = "btnAddAirportCancel";
			this.btnAddAirportCancel.Size = new System.Drawing.Size(102, 23);
			this.btnAddAirportCancel.TabIndex = 7;
			this.btnAddAirportCancel.Text = "Cancel";
			this.btnAddAirportCancel.UseVisualStyleBackColor = true;
			this.btnAddAirportCancel.Click += new System.EventHandler(this.btnAddAirportCancel_Click);
			// 
			// errorProviderAddAirport
			// 
			this.errorProviderAddAirport.ContainerControl = this;
			// 
			// AddAirport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 221);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(310, 260);
			this.MinimumSize = new System.Drawing.Size(310, 260);
			this.Name = "AddAirport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Airport";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAddAirport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddAirportCancel;
		private System.Windows.Forms.Button btnAddAirportSave;
		private System.Windows.Forms.TextBox tbAddAirportShortname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbAddAirportName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbAddAirportCity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProviderAddAirport;
	}
}