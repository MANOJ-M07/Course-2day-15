using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment15
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                LblErrorMessage.Visible = false;
            }
        }

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int divident = int.Parse(TxtNumOne.Text);
                int divisor = int.Parse(TxtNum2.Text);
                int result = divident / divisor;

                LblErrorMessage.Text = "Result after Division: " + result.ToString();
                //you can also throw a custom exception
                if (result > 5)
                {
                    throw new Exception("Result is greater than 5.");
                }

            }
            catch (DivideByZeroException ex)
            {
                //LblErrorMessage.Text = "Divide by zero error occurred."+ex.Message;
                Session["error"] = "Divide by zero error occurred." + ex.Message;
                Response.Redirect("Error.aspx");
            }
            catch (Exception ex)
            {
                //handle other exception
                //ypu can also redirect to an error page here
                // LblErrorMessage.Text = "An error occurred: " + ex.Message;
                Session["error"] = "Divide by zero error occurred." + ex.Message;
                Response.Redirect("Error.aspx");
            }
            }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatBinding.aspx");
        }
    }
}