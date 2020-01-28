namespace FormValidationExample
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
			this.components = new System.ComponentModel.Container();
			this.lbl_name_surname = new System.Windows.Forms.Label();
			this.lbl_address = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tbNameSurname = new System.Windows.Forms.TextBox();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbCity = new System.Windows.Forms.TextBox();
			this.mtbTelNum = new System.Windows.Forms.MaskedTextBox();
			this.tbAge = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbCode = new System.Windows.Forms.TextBox();
			this.errorProviderAge = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_name_surname
			// 
			this.lbl_name_surname.AutoSize = true;
			this.lbl_name_surname.Location = new System.Drawing.Point(27, 20);
			this.lbl_name_surname.Name = "lbl_name_surname";
			this.lbl_name_surname.Size = new System.Drawing.Size(104, 13);
			this.lbl_name_surname.TabIndex = 0;
			this.lbl_name_surname.Text = "Name and Surname:";
			// 
			// lbl_address
			// 
			this.lbl_address.AutoSize = true;
			this.lbl_address.Location = new System.Drawing.Point(83, 45);
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.Size = new System.Drawing.Size(48, 13);
			this.lbl_address.TabIndex = 1;
			this.lbl_address.Text = "Address:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Tel. number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(104, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "City:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(94, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "e-mail:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(102, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Age:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Postal Code:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(97, 267);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 42);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tbNameSurname
			// 
			this.tbNameSurname.Location = new System.Drawing.Point(137, 17);
			this.tbNameSurname.MaxLength = 20;
			this.tbNameSurname.Multiline = true;
			this.tbNameSurname.Name = "tbNameSurname";
			this.tbNameSurname.Size = new System.Drawing.Size(181, 20);
			this.tbNameSurname.TabIndex = 1;
			// 
			// tbAddress
			// 
			this.tbAddress.AcceptsReturn = true;
			this.tbAddress.Location = new System.Drawing.Point(137, 42);
			this.tbAddress.MaxLength = 120;
			this.tbAddress.Multiline = true;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(181, 20);
			this.tbAddress.TabIndex = 2;
			// 
			// tbCity
			// 
			this.tbCity.AutoCompleteCustomSource.AddRange(new string[] {
            "Skopje",
            "Bitola",
            "Kumanovo",
            "Tetovo",
            "Ohrid",
            "Prilep",
            "Stip",
            "Strumica",
            "Kicevo",
            "Veles"});
			this.tbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbCity.Location = new System.Drawing.Point(137, 91);
			this.tbCity.Name = "tbCity";
			this.tbCity.Size = new System.Drawing.Size(181, 20);
			this.tbCity.TabIndex = 3;
			// 
			// mtbTelNum
			// 
			this.mtbTelNum.Location = new System.Drawing.Point(137, 120);
			this.mtbTelNum.Mask = "(999) 000-000";
			this.mtbTelNum.Name = "mtbTelNum";
			this.mtbTelNum.Size = new System.Drawing.Size(181, 20);
			this.mtbTelNum.TabIndex = 4;
			this.mtbTelNum.Text = "07";
			// 
			// tbAge
			// 
			this.tbAge.Location = new System.Drawing.Point(137, 148);
			this.tbAge.Name = "tbAge";
			this.tbAge.Size = new System.Drawing.Size(181, 20);
			this.tbAge.TabIndex = 5;
			this.tbAge.Validating += new System.ComponentModel.CancelEventHandler(this.tbAge_Validating);
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(137, 178);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(181, 20);
			this.tbEmail.TabIndex = 6;
			this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
			// 
			// tbCode
			// 
			this.tbCode.Location = new System.Drawing.Point(137, 210);
			this.tbCode.Name = "tbCode";
			this.tbCode.Size = new System.Drawing.Size(181, 20);
			this.tbCode.TabIndex = 7;
			// 
			// errorProviderAge
			// 
			this.errorProviderAge.ContainerControl = this;
			// 
			// errorProviderEmail
			// 
			this.errorProviderEmail.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 321);
			this.Controls.Add(this.tbCode);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.tbAge);
			this.Controls.Add(this.mtbTelNum);
			this.Controls.Add(this.tbCity);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.tbNameSurname);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbl_address);
			this.Controls.Add(this.lbl_name_surname);
			this.Name = "Form1";
			this.Text = "Input Form";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_name_surname;
		private System.Windows.Forms.Label lbl_address;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbNameSurname;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbCity;
		private System.Windows.Forms.MaskedTextBox mtbTelNum;
		private System.Windows.Forms.TextBox tbAge;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.ErrorProvider errorProviderAge;
		private System.Windows.Forms.ErrorProvider errorProviderEmail;
	}
}

