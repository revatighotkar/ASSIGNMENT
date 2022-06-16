using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {



                string[] str = new string[] { "doll", "chocolate", "icecream", "biscuit", "lollipop" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".JFIF";
            if (DropDownList1.Items.FindByText("doll").Selected == true)
            {
                Label1.Text = "Price: 1000/-";
            }
            else if (DropDownList1.Items.FindByText("chocolate").Selected == true)
            {
                Label1.Text = "Price: /-";
            }
            else if (DropDownList1.Items.FindByText("icecream").Selected == true)
            {
                Label1.Text = "Price: 60/-";
            }
            else if (DropDownList1.Items.FindByText("lollipop").Selected == true)
            {
                Label1.Text = "Price: 10/-";
            }
            else
            {
                Label1.Text = "Price: 240/-";
            }

        }
    }
}