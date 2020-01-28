using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormValidationExample
{
	public partial class FormTermsAndConditions : Form
	{
		public FormTermsAndConditions()
		{
			InitializeComponent();
		}

		private void FormTermsAndConditions_Load(object sender, EventArgs e)
		{
			tbTermsAndConditions.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur consequat risus nisl, ac interdum risus sodales eu. Maecenas interdum tincidunt mi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nunc non posuere augue. Nulla eu orci tellus. Nunc in facilisis nulla. Sed egestas, enim eu imperdiet volutpat, quam ligula ultrices dolor, eu rutrum libero turpis in enim. Integer congue, dui in rhoncus viverra, metus risus blandit felis, nec faucibus leo metus eu metus. Suspendisse at bibendum arcu, et malesuada tellus. Aliquam aliquet sollicitudin odio, aliquet ullamcorper ligula mattis quis. Aliquam fermentum dapibus lacus nec congue. In rhoncus erat leo, quis faucibus quam varius at. Pellentesque at fermentum augue.Nulla placerat, massa vitae sodales ullamcorper, sapien ante accumsan mi, vitae lacinia eros magna sit amet odio. Proin sed diam diam. Cras elit mi, congue sit amet pretium ut, tincidunt nec leo.Vestibulum commodo ornare ante eget consectetur. Fusce id consequat ante. Integer auctor augue vitae venenatis elementum. Quisque vestibulum vestibulum mauris nec lacinia. Cras sit amet nulla nisi.Quisque venenatis vitae tellus vel pretium. Maecenas lacinia fringilla diam vel porta. Nam dignissim aliquam ante et tempus. Quisque nec tristique mi. Aliquam et consequat odio, quis condimentum purus. Duis vehicula metus vel sem malesuada, in porttitor dolor euismod.Nam non magna vitae enim egestas viverra.Ut non ex tortor. Suspendisse imperdiet lorem eget vehicula efficitur. In in nibh tortor. Maecenas feugiat nisi ac eros aliquam tempus.Quisque sed orci scelerisque, fermentum dolor eget, euismod lectus.Proin convallis ex orci, quis aliquet arcu vehicula eget. Proin euismod tristique elit, quis sodales felis interdum et. Duis pulvinar lorem non orci rutrum, eu sodales leo lacinia.Donec vitae fringilla libero, vitae consequat nibh. Ut scelerisque lacus id ullamcorper fringilla. Integer sagittis leo eget semper rhoncus.";
		}

		private void FormTermsAndConditions_Resize(object sender, EventArgs e)
		{
			tbTermsAndConditions.Size = new System.Drawing.Size(this.Size.Width - 27, this.Size.Height - 48);
		}
	}
}
