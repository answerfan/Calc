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
        string p = "";
        string c = "";
        string d = "";
        double res = 0;
        bool plus;
        bool minus;
        bool del;
        bool umn;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (p == "")
            {
                a = "1";
                p = p + a;
                if (lblDisp.Text == "0")
                {
                    p = a;
                }
                lblDisp.Text = p.ToString();
            }
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
            c = "";
            d = "";
            res = 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (c == "")
            {
                c = p;
            }
            else if (d == "")
            {
                d = p;
            }
            if (plus == true)
            {
                    Convert.ToDouble(res);
                    res = Convert.ToDouble(c) + Convert.ToDouble(d);
                    lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (del == true)
            {
                    Convert.ToDouble(res);
                    res = Convert.ToDouble(c) / Convert.ToDouble(d);
                    lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (umn == true)
            {
                    Convert.ToDouble(res);
                    res = Convert.ToDouble(p) * Convert.ToDouble(c);
                    lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else
            {
                p = "";
                d = "";
                plus = true;
                minus = false;
                del = false;
                umn = false;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (c == "")
            {
                c = p;
            }
            else if (d == "")
            {
                d = p;
            }
            if (plus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) + Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else
            {
                minus = true;
                plus = false;
                umn = false;
                del = false;
                p = "";
                d = "";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (c == "")
            {
                c = p;
            }
            else if (d == "")
            {
                d = p;
            }
            if (plus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) + Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else
            {
                umn = true;
                plus = false;
                minus = false;
                del = false;
                p = "";
                d = "";
            }
        }

        private void btnDemul_Click(object sender, EventArgs e)
        {
            if (c == "")
            {
                c = p;
            }
            else if (d == "")
            {
                d = p;
            }
            if (plus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) + Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else
            {
                del = true;
                plus = false;
                minus = false;
                umn = false;
                p = "";
                d = "";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (c == "")
            {
                c = p;
            }
            else if (d == "")
            {
                d = p;
            }
            if (plus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) + Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                c = "";
                p = "";
            }
            lblDisp.Text = Convert.ToString(res);
            del = false;
            plus = false;
            minus = false;
            umn = false;
            p = Convert.ToString(res);
            c = "";
            d = "";
        }
    }
}
