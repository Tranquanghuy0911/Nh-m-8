using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop.Users
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Request.Url.AbsoluteUri.ToString().Contains("Default.aspx"))
            {
                form1.Attributes.Add("class", "bg0 m-t-23 p-b-140");
            }   
            else
            {
                form1.Attributes.Remove("class");


                Control sliderUserControl = (Control)Page.LoadControl("SliderUserControl.ascx");


                pnlSliderUC.Controls.Add(sliderUserControl); 
            }    
        }
    }
}