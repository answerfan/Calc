using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        string a;
        string p;
        int res = 0;
        bool plus = false;
        bool minus = false;
        bool del = false;
        bool umn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            a = "1";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            a = "2";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            a = "3";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            a = "4";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            a = "5";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            a = "6";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            a = "7";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            a = "8";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            a = "9";
            p = p + a;
            if (lblDisp.Text == "0")
            {
                p = a;
            }
            lblDisp.Text = p.ToString();
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (lblDisp.Text == "0")
            {
                lblDisp.Text = "0";
                i++;
                if (i > 100)
                {
                    lblDisp.Text = "0";
                    break;
                }
                if (i < 100)
                {
                    p = "";
                }
            }
            a = "0";
            p = p + a;
            lblDisp.Text = p.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisp.Text = "";
            p = "";
            res = 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (res == 0)
            {
                res = 0 + Convert.ToInt32(p);
                lblDisp.Text = res.ToString();
                p = "";
            }
            else
            {
                Convert.ToInt32(res);
                res = res + Convert.ToInt32(p);
                lblDisp.Text = res.ToString();
                p = "";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (res == 0)
            {
                res = 0 + Convert.ToInt32(p);
                lblDisp.Text = res.ToString();
                p = "";
            }
            else
            {
                Convert.ToInt32(res);
                res = res - Convert.ToInt32(p);
                lblDisp.Text = res.ToString();
                p = "";
            }
        }
    }
}
