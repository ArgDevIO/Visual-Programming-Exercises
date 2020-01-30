using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDrawing
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnDraw_Click(object sender, EventArgs e)
		{
			Graphics g = this.CreateGraphics();
			SolidBrush br = new SolidBrush(Color.DarkGray);
			g.FillEllipse(br, this.ClientRectangle);
			Pen pn = new Pen(Color.Black, 1);
			g.DrawEllipse(pn, this.ClientRectangle);
			pn.Dispose();
			br.Dispose();
		}
	}
}
