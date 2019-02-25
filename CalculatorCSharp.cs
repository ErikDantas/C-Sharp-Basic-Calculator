using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCsharp
{
	public partial class mainfrm : Form
	{
		public mainfrm()
		{
			InitializeComponent();
            InicializeTimer();
		}

		private void btnexit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{			
			if (rbaddition.Checked)
			{
				try {

					int num1 = Convert.ToInt32(tbfirst.Text);
					int num2 = Convert.ToInt32(tbsecond.Text);
					int result = num1 + num2;
					tbresult.Text = Convert.ToString(result);
				}
				catch {
					MessageBox.Show("You cannot use string.","ERROR");

				}
			}
			if (rbmultiplication.Checked)
			{
				try { 
					int num1 = Convert.ToInt32(tbfirst.Text);
					int num2 = Convert.ToInt32(tbsecond.Text);
					int result = num1 * num2;
					tbresult.Text = Convert.ToString(result);
				}
				catch
				{
					MessageBox.Show("You cannot use string.", "ERROR");
				}
			}
			if (rbdivision.Checked)
			{
				
				try { 
					Double num1 = Convert.ToDouble(tbfirst.Text);
					Double num2 = Convert.ToDouble(tbsecond.Text);
					Double result = num1 / num2;
					if (num2 <= 0) {
						MessageBox.Show("The second number cannot is Zero.", "ERROR!");

					}
					else
					{
						tbresult.Text = Convert.ToString(result);
					}

				}
				catch{
					MessageBox.Show("You cannot use string.", "ERROR");
				}
			}
			if (rbsubtraction.Checked)
			{
				try { 
					int num1 = Convert.ToInt32(tbfirst.Text);
					int num2 = Convert.ToInt32(tbsecond.Text);
					int result = num1 - num2;
					tbresult.Text = Convert.ToString(result);
				}
				catch
				{
					MessageBox.Show("You cannot use string.", "ERROR");
				}
			}
			if (rbroot.Checked)
			{
				try{
					double num1 = Convert.ToInt32(tbfirst.Text);
					double result = Math.Sqrt(num1);
					tbresult.Text = Convert.ToString(result);
				}
				catch
				{
					MessageBox.Show("You cannot use string.", "ERROR");
				}
			}
		}

		private void rbroot_CheckedChanged(object sender, EventArgs e)
		{
			tbsecond.Visible = false;
			lbsecond.Visible = false;
			tbresult.Text = "";
		}

		private void rbaddition_CheckedChanged(object sender, EventArgs e)
		{
			tbsecond.Visible = true;
			lbsecond.Visible = true;
			tbresult.Text = "";
		}

		private void rbsubtraction_CheckedChanged(object sender, EventArgs e)
		{
			tbsecond.Visible = true;
			lbsecond.Visible = true;
			tbresult.Text = "";
		}

		private void rbmultiplication_CheckedChanged(object sender, EventArgs e)
		{
			tbsecond.Visible = true;
			lbsecond.Visible = true;
			tbresult.Text = "";
		}

		private void rbdivision_CheckedChanged(object sender, EventArgs e)
		{
			tbsecond.Visible = true;
			lbsecond.Visible = true;
			tbresult.Text = "";
		}

		private void tbfirst_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double num1 = Convert.ToDouble(tbfirst.Text);
			}
			catch
			{
				tbfirst.Text = "";
			}
		}

		private void tbsecond_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double num2 = Convert.ToDouble(tbsecond.Text);
			}
			catch
			{
				tbsecond.Text = "";
			}
		}
        private void InicializeTimer()
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbname.Location.X <= 460)
            {
                int step = 5;
                lbname.Location = new Point(lbname.Location.X + step, lbname.Location.Y);

            }
            else
            {
                lbname.Location = new Point(10, lbname.Location.Y);
            }

        }
    }
}
