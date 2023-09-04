using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppErrorHandling
{
    public partial class Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                LblErrorMessage.Visible = false;    
            }

        }

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int dividend = int.Parse(TxtNumOne.Text);
                int divisor = int.Parse(TxtNumTwo.Text);
                int result = dividend / divisor;

                LblErrorMessage.Text = "Result after division:" + result.ToString();
                if(result>5)
                {
                    throw new Exception("Result is greater than 5");
                }
            }
            catch (DivideByZeroException ex)
            {
                //LblErrorMessage.Text = "Dividde by zero Error Occured"+ex.Message;
                Session["error"]= "Dividde by zero Error Occured"+ex.Message;
                Response.Redirect("Error.aspx");
            }
            catch(Exception ex)
            {
                //LblErrorMessage.Text = "An error occurred:" + ex.Message;
                Session["error"] = "An Error Occured" + ex.Message;
                Response.Redirect("Error.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Databinding.aspx");
        }
    }
}