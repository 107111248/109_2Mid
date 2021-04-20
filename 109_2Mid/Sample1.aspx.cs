using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String ans;
            if (tb_Acc.Text != "" | tb_Pass.Text != "")
            {
                TextBox1.Text = tb_Acc.Text + "<br />" + tb_Pass.Text + "<br />";
            }

                if (rbg_Interest.SelectedIndex == 0 | rbg_Interest.SelectedIndex == 1 | rbg_Interest.SelectedIndex == 2)
                {
                    TextBox1.Text = TextBox1.Text + rbg_Interest.SelectedValue;
                }
                 ans = "Sample1Com.aspx?ans=" + TextBox1.Text + "<br />";
                 Response.Redirect(ans);
            }
        }
  }