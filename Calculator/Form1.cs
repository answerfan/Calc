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
        bool zap = true;
        double m;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (p == "")
            {
                lblMod.Text = "";
            }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
        if (p == "")
        {
            lblMod.Text = "";
        }
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
            zap = true;
            res = 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (c == "" && p == "")
            {
                c = Convert.ToString(res);
            }
            else if (c == "")
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
                p = "";
                c = "";
                d = "";
                plus = false;
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                minus = false;
            }
            else if (del == true)
            {
                    Convert.ToDouble(res);
                    res = Convert.ToDouble(c) / Convert.ToDouble(d);
                    lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                del = false;
            }
            else if (umn == true)
            {
                    Convert.ToDouble(res);
                    res = Convert.ToDouble(p) * Convert.ToDouble(c);
                    lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                umn = false;
            }
            else
            {
                p = "";
                d = "";
                plus = true;
                minus = false;
                del = false;
                umn = false;
                zap = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (c == "" && p == "")
            {
                c = Convert.ToString(res);
            }
            else if (c == "")
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
                p = "";
                c = "";
                d = "";
                plus = false;
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                minus = false;
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                del = false;
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                umn = false;
            }
            else
            {
                minus = true;
                plus = false;
                umn = false;
                del = false;
                zap = true;
                p = "";
                d = "";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (c == "" && p == "")
            {
                c = Convert.ToString(res);
            }
            else if (c == "")
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
                p = "";
                c = "";
                d = "";
                plus = false;
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                minus = false;
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                del = false;
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                umn = false;
            }
            else
            {
                umn = true;
                plus = false;
                minus = false;
                del = false;
                zap = true;
                p = "";
                d = "";
            }
        }

        private void btnDemul_Click(object sender, EventArgs e)
        {
            if (c == "" && p == "")
            {
                c = Convert.ToString(res);
            }
            else if (c == "")
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
                p = "";
                c = "";
                d = "";
                plus = false;
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                minus = false;
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                del = false;
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                umn = false;
            }
            else
            {
                del = true;
                plus = false;
                minus = false;
                umn = false;
                zap = true;
                p = "";
                d = "";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (c == "" && p == "")
            {
                c = Convert.ToString(res);
            }
            else if (c == "")
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
                p = "";
                c = "";
                d = "";
                plus = false;
            }
            else if (minus == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) - Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                minus = false;
            }
            else if (del == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(c) / Convert.ToDouble(d);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                del = false;
            }
            else if (umn == true)
            {
                Convert.ToDouble(res);
                res = Convert.ToDouble(p) * Convert.ToDouble(c);
                lblDisp.Text = res.ToString();
                p = "";
                c = "";
                d = "";
                umn = false;
            }
            lblDisp.Text = Convert.ToString(res);
            del = false;
            plus = false;
            minus = false;
            umn = false;
            zap = true;
            p = Convert.ToString(res);
            c = "";
            d = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (zap == true)
            {
                if (p == "")
                {
                    p = "0.";
                }
                else
                {
                    p = p + ".";
                }
                zap = false;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            m = Convert.ToDouble(p);
            p = Convert.ToString(m * -1);
            if (Convert.ToDouble(p) < 0)
            {
                lblMod.Text = "-";
            }
            else
            {
                lblMod.Text = "";
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный калькулятор создан специально для Вероники Шмидт", "Калькулятор");
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
