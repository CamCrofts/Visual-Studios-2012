using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       //         var spend;
       // var discount;

       // spend = "101";

       //TextBox1 = int
       //    Button1 

       //    if TextBox1 = > $100
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double spend = double.Parse(TextBox1.Text);

        if (spend > 100 && FlyBuys.Checked == true)
        {
            TextBox2.Text = (spend * 0.75).ToString();
        }

        else if (spend > 100 && FlyBuys.Checked == false)
        {
            TextBox2.Text = (spend * 0.85).ToString();
        }

        else if (spend < 100 || spend == 100)
        {
            TextBox2.Text = (spend * 1).ToString();
        }
        

    }
}