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
        double res = 0;
        bool plus;
        bool minus;
        bool del;
        bool umn;

        private void Plus(double b, string t)
        {
            b = res;
            t = p;
            if (res == 0)
            {
                res = 0 + Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            else
            {
                Convert.ToDouble(res);
                res = res + Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            p = "";
        }

        private void Minus(double b, string t)
        {
            b = res;
            t = p;
            if (res == 0)
            {
                res = 0 + Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            else
            {
                Convert.ToDouble(res);
                res = res - Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            p = "";
        }

        private void Del(double b, string t)
        {
            b = res;
            t = p;
            if (res == 0)
            {
                res = 0 + Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            else
            {
                Convert.ToDouble(res);
                res = res * Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            p = "";
        }

        private void Mult(double b, string t)
        {
            b = res;
            t = p;
            if (res == 0)
            {
                res = 0 + Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            else
            {
                Convert.ToDouble(res);
                res = res / Convert.ToDouble(p);
                lblDisp.Text = res.ToString();
            }
            p = "";
        }

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
            if (plus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (minus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res - Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (del == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res / Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (umn == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res * Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else
            {
                p = "";
                plus = true;
                minus = false;
                del = false;
                umn = false;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (minus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res - Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (del == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res / Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (umn == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res * Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                    p = "";
                }
            }
            else
            {
                minus = true;
                plus = false;
                umn = false;
                del = false;
                p = "";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (minus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res - Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (del == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res / Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (umn == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res * Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else
            {
                umn = true;
                plus = false;
                minus = false;
                del = false;
                p = "";
            }
        }

        private void btnDemul_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (minus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res - Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (del == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res / Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (umn == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res * Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else
            {
                del = true;
                plus = false;
                minus = false;
                umn = false;
                p = "";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (minus == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res - Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (del == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res / Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            else if (umn == true)
            {
                if (res == 0)
                {
                    res = 0 + Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
                else
                {
                    Convert.ToDouble(res);
                    res = res * Convert.ToDouble(p);
                    lblDisp.Text = res.ToString();
                }
            }
            p = "";
            lblDisp.Text = Convert.ToString(res);
        }
    }
}
