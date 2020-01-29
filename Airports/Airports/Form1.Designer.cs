namespace Airports
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
			this.label1 = new System.Windows.Forms.Label();
			this.lbAirports = new System.Windows.Forms.ListBox();
			this.lbDestinations = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
			this.tbAvgLngthDestinations = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddDestination = new System.Windows.Forms.Button();
			this.btnAddAirport = new System.Windows.Forms.Button();
			this.btnDeleteAirport = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Airports";
			// 
			// lbAirports
			// 
			this.lbAirports.FormattingEnabled = true;
			this.lbAirports.Location = new System.Drawing.Point(16, 30);
			this.lbAirports.Name = "lbAirports";
			this.lbAirports.Size = new System.Drawing.Size(284, 264);
			this.lbAirports.TabIndex = 1;
			this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
			// 
			// lbDestinations
			// 
			this.lbDestinations.FormattingEnabled = true;
			this.lbDestinations.Location = new System.Drawing.Point(306, 30);
			this.lbDestinations.Name = "lbDestinations";
			this.lbDestinations.Size = new System.Drawing.Size(284, 264);
			this.lbDestinations.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(303, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Destinations";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbAvgLngthDestinations);
			this.groupBox1.Controls.Add(this.tbMostExpensiveDestination);
			this.groupBox1.Location = new System.Drawing.Point(306, 300);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 125);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Destinations";
			// 
			// tbMostExpensiveDestination
			// 
			this.tbMostExpensiveDestination.Enabled = false;
			this.tbMostExpensiveDestination.Location = new System.Drawing.Point(7, 40);
			this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
			this.tbMostExpensiveDestination.Size = new System.Drawing.Size(271, 20);
			this.tbMostExpensiveDestination.TabIndex = 0;
			// 
			// tbAvgLngthDestinations
			// 
			this.tbAvgLngthDestinations.Enabled = false;
			this.tbAvgLngthDestinations.Location = new System.Drawing.Point(7, 84);
			this.tbAvgLngthDestinations.Name = "tbAvgLngthDestinations";
			this.tbAvgLngthDestinations.Size = new System.Drawing.Size(271, 20);
			this.tbAvgLngthDestinations.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Most expensive destination";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Average length of destinations";
			// 
			// btnAddDestination
			// 
			this.btnAddDestination.Location = new System.Drawing.Point(16, 402);
			this.btnAddDestination.Name = "btnAddDestination";
			this.btnAddDestination.Size = new System.Drawing.Size(284, 23);
			this.btnAddDestination.TabIndex = 5;
			this.btnAddDestination.Text = "Add Destination";
			this.btnAddDestination.UseVisualStyleBackColor = true;
			this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
			// 
			// btnAddAirport
			// 
			this.btnAddAirport.Location = new System.Drawing.Point(16, 314);
			this.btnAddAirport.Name = "btnAddAirport";
			this.btnAddAirport.Size = new System.Drawing.Size(284, 23);
			this.btnAddAirport.TabIndex = 6;
			this.btnAddAirport.Text = "Add Airport";
			this.btnAddAirport.UseVisualStyleBackColor = true;
			this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
			// 
			// btnDeleteAirport
			// 
			this.btnDeleteAirport.Location = new System.Drawing.Point(16, 358);
			this.btnDeleteAirport.Name = "btnDeleteAirport";
			this.btnDeleteAirport.Size = new System.Drawing.Size(284, 23);
			this.btnDeleteAirport.TabIndex = 7;
			this.btnDeleteAirport.Text = "Delete Airport";
			this.btnDeleteAirport.UseVisualStyleBackColor = true;
			this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 438);
			this.Controls.Add(this.btnDeleteAirport);
			this.Controls.Add(this.btnAddAirport);
			this.Controls.Add(this.btnAddDestination);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbDestinations);
			this.Controls.Add(this.lbAirports);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(622, 477);
			this.MinimumSize = new System.Drawing.Size(622, 477);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Airports";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbAirports;
		private System.Windows.Forms.ListBox lbDestinations;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbAvgLngthDestinations;
		private System.Windows.Forms.TextBox tbMostExpensiveDestination;
		private System.Windows.Forms.Button btnAddDestination;
		private System.Windows.Forms.Button btnAddAirport;
		private System.Windows.Forms.Button btnDeleteAirport;
	}
}

