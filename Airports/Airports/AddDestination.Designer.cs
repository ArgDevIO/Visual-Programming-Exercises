namespace Airports
{
	partial class AddDestination
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
			this.btnAddDestinationCancel = new System.Windows.Forms.Button();
			this.btnAddDestinationSave = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbAddDestinationName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.nudAddDestinationLength = new System.Windows.Forms.NumericUpDown();
			this.nudAddDestinationPrice = new System.Windows.Forms.NumericUpDown();
			this.errorProviderAddDestination = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAddDestinationLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAddDestinationPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAddDestination)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudAddDestinationPrice);
			this.groupBox1.Controls.Add(this.nudAddDestinationLength);
			this.groupBox1.Controls.Add(this.btnAddDestinationCancel);
			this.groupBox1.Controls.Add(this.btnAddDestinationSave);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbAddDestinationName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(263, 196);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Destination";
			// 
			// btnAddDestinationCancel
			// 
			this.btnAddDestinationCancel.Location = new System.Drawing.Point(136, 164);
			this.btnAddDestinationCancel.Name = "btnAddDestinationCancel";
			this.btnAddDestinationCancel.Size = new System.Drawing.Size(102, 23);
			this.btnAddDestinationCancel.TabIndex = 7;
			this.btnAddDestinationCancel.Text = "Cancel";
			this.btnAddDestinationCancel.UseVisualStyleBackColor = true;
			this.btnAddDestinationCancel.Click += new System.EventHandler(this.btnAddDestinationCancel_Click);
			// 
			// btnAddDestinationSave
			// 
			this.btnAddDestinationSave.Location = new System.Drawing.Point(6, 164);
			this.btnAddDestinationSave.Name = "btnAddDestinationSave";
			this.btnAddDestinationSave.Size = new System.Drawing.Size(102, 23);
			this.btnAddDestinationSave.TabIndex = 6;
			this.btnAddDestinationSave.Text = "Save";
			this.btnAddDestinationSave.UseVisualStyleBackColor = true;
			this.btnAddDestinationSave.Click += new System.EventHandler(this.btnAddDestinationSave_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Length";
			// 
			// tbAddDestinationName
			// 
			this.tbAddDestinationName.Location = new System.Drawing.Point(6, 37);
			this.tbAddDestinationName.Name = "tbAddDestinationName";
			this.tbAddDestinationName.Size = new System.Drawing.Size(232, 20);
			this.tbAddDestinationName.TabIndex = 1;
			this.tbAddDestinationName.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddDestinationName_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// nudAddDestinationLength
			// 
			this.nudAddDestinationLength.Location = new System.Drawing.Point(9, 88);
			this.nudAddDestinationLength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.nudAddDestinationLength.Name = "nudAddDestinationLength";
			this.nudAddDestinationLength.Size = new System.Drawing.Size(120, 20);
			this.nudAddDestinationLength.TabIndex = 8;
			// 
			// nudAddDestinationPrice
			// 
			this.nudAddDestinationPrice.Location = new System.Drawing.Point(9, 138);
			this.nudAddDestinationPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.nudAddDestinationPrice.Name = "nudAddDestinationPrice";
			this.nudAddDestinationPrice.Size = new System.Drawing.Size(120, 20);
			this.nudAddDestinationPrice.TabIndex = 9;
			// 
			// errorProviderAddDestination
			// 
			this.errorProviderAddDestination.ContainerControl = this;
			// 
			// AddDestination
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 221);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(310, 260);
			this.MinimumSize = new System.Drawing.Size(310, 260);
			this.Name = "AddDestination";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Destination";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAddDestinationLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAddDestinationPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAddDestination)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddDestinationCancel;
		private System.Windows.Forms.Button btnAddDestinationSave;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbAddDestinationName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudAddDestinationPrice;
		private System.Windows.Forms.NumericUpDown nudAddDestinationLength;
		private System.Windows.Forms.ErrorProvider errorProviderAddDestination;
	}
}