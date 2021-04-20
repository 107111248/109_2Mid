using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (rbl_Res.SelectedIndex == 0)
            {
                td_Des.Text = "";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddl_Area.SelectedValue == "北區") 
            { 
            ddl_Place.Items.Clear();
            ddl_Place.Items.Add("基隆");
            ddl_Place.Items.Add("台北");
            ddl_Place.Items.Add("新北");
            }else if(ddl_Area.SelectedValue == "中區")
            {
                ddl_Place.Items.Clear();
                ddl_Place.Items.Add("苗栗");
                ddl_Place.Items.Add("台中");
                ddl_Place.Items.Add("南投");
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbl_Res.SelectedIndex == 0)
            {
                td_Des.Visible = false;
            }
            else
            {
                td_Des.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" | ddl_Area.Text != "" | ddl_Place.Text != "" | td_Des.Text !="")
            {
                lb_Msg.Text = ddl_Area.Text + "<br/>"+ ddl_Place.Text + "<br/>"+ tb_Name.Text + "<br/>" +td_Des.Text;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}