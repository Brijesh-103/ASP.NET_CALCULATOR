using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArithmeticOperations
{
    public partial class frmOperators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNumber1.Focus();
        }
        protected void btnADD_Click(object sender, EventArgs e)
        {
            lblAns.Text = string.Empty;
            lblNo1Error.Text = "*";
            lblNo2Error.Text = "*";
            lblValidNo1.Text = "*";
            lblValidNo2.Text = "*";
           string n1 = txtNumber1.Text;
           string n2 = txtNumber2.Text;
            if (n1 == string.Empty & n2 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblNo2Error.Text = "Please Enter Number 2";
            }
            else if (n1 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblAns.Text = string.Empty;
            }
            else if (n2 == string.Empty)
            {
                lblNo2Error.Text = "Please Enter Number 2";
                lblAns.Text = string.Empty;
            }
            else
            {
                int no1 = Convert.ToInt32(n1);
                int no2 = Convert.ToInt32(n2);
                if (no1 < 0 || no1 == 0 && no2 < 0 || no2 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else if (no1 < 0 || no1 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    return;
                }
                else if (no2 < 0 || no2 == 0)
                {
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else
                {
                    int ans = no1 + no2;
                    lblAns.Text += "Addition is : " +ans;
                } 
            } 
        }

        protected void btnSUB_Click(object sender, EventArgs e)
        {
            lblAns.Text = string.Empty;
            lblNo1Error.Text = "*";
            lblNo2Error.Text = "*";
            lblValidNo1.Text = "*";
            lblValidNo2.Text = "*";
            string n1 = txtNumber1.Text;
            string n2 = txtNumber2.Text;
            if (n1 == string.Empty & n2 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblNo2Error.Text = "Please Enter Number 2";
            }
            else if (n1 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblAns.Text = string.Empty;
            }
            else if (n2 == string.Empty)
            {
                lblNo2Error.Text = "Please Enter Number 2";
                lblAns.Text = string.Empty;
            }
            else
            {
                int no1 = Convert.ToInt32(n1);
                int no2 = Convert.ToInt32(n2);
                if (no1 < 0 || no1 == 0 && no2 < 0 || no2 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else if (no1 < 0 || no1 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";                   
                }
                else if (no2 < 0 || no2 == 0)
                {
                    lblValidNo2.Text = "Invalid Number 2.";  
                }
                else
                {
                    int ans = no1 - no2;
                  
                    lblAns.Text += "Subtraction is : " + Math.Abs(ans);
                }
            }
        }

        protected void btnMUL_Click(object sender, EventArgs e)
        {
            lblAns.Text = string.Empty;
            lblNo1Error.Text = "*";
            lblNo2Error.Text = "*";
            lblValidNo1.Text = "*";
            lblValidNo2.Text = "*";
            string n1 = txtNumber1.Text;
            string n2 = txtNumber2.Text;
            if (n1 == string.Empty & n2 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblNo2Error.Text = "Please Enter Number 2";
            }
            else if (n1 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblAns.Text = string.Empty;
            }
            else if (n2 == string.Empty)
            {
                lblNo2Error.Text = "Please Enter Number 2";
                lblAns.Text = string.Empty;
            }
            else
            {
                int no1 = Convert.ToInt32(n1);
                int no2 = Convert.ToInt32(n2);
                if (no1 < 0 || no1 == 0 && no2 < 0 || no2 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else if (no1 < 0 || no1 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    return;
                }
                else if (no2 < 0 || no2 == 0)
                {
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else
                {
                    int ans = no1 * no2;
                    lblAns.Text += "Multiaplication is : " + ans;
                }
            }
        }

        protected void btnDIV_Click(object sender, EventArgs e)
        {
            lblAns.Text = string.Empty;
            lblNo1Error.Text = "*";
            lblNo2Error.Text = "*";
            lblValidNo1.Text = "*";
            lblValidNo2.Text = "*";
            string n1 = txtNumber1.Text;
            string n2 = txtNumber2.Text;
            if (n1 == string.Empty & n2 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblNo2Error.Text = "Please Enter Number 2";
            }
            else if (n1 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblAns.Text = string.Empty;
            }
            else if (n2 == string.Empty)
            {
                lblNo2Error.Text = "Please Enter Number 2";
                lblAns.Text = string.Empty;
            }
            else
            {
                int no1 = Convert.ToInt32(n1);
                int no2 = Convert.ToInt32(n2);
                if (no1 < 0 || no1 == 0 && no2 < 0 || no2 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else if (no1 < 0 || no1 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    return;
                }
                else if (no2 < 0 || no2 == 0)
                {
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else
                {
                    double ans = no1 / no2;
                    lblAns.Text += "Division is : " + ans;
                }
            }
        }

        protected void btnPOW_Click(object sender, EventArgs e)
        {
            lblAns.Text = string.Empty;
            lblNo1Error.Text = "*";
            lblNo2Error.Text = "*";
            lblValidNo1.Text = "*";
            lblValidNo2.Text = "*";
            string n1 = txtNumber1.Text;
            string n2 = txtNumber2.Text;
            if (n1 == string.Empty & n2 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblNo2Error.Text = "Please Enter Number 2";
            }
            else if (n1 == string.Empty)
            {
                lblNo1Error.Text = "Please Enter Number 1";
                lblAns.Text = string.Empty;
            }
            else if (n2 == string.Empty)
            {
                lblNo2Error.Text = "Please Enter Number 2";
                lblAns.Text = string.Empty;
            }
            else
            {
                int no1 = Convert.ToInt32(n1);
                int no2 = Convert.ToInt32(n2);
                if (no1 < 0 || no1 == 0 && no2 < 0 || no2 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else if (no1 < 0 || no1 == 0)
                {
                    lblValidNo1.Text = "Invalid Number 1.";
                    return;
                }
                else if (no2 < 0 || no2 == 0)
                {
                    lblValidNo2.Text = "Invalid Number 2.";
                    return;
                }
                else
                {
                    double ans = Math.Pow(no1,no2);
                    lblAns.Text += "Power is : " + ans;
                }
            }
        }
    }
}
 