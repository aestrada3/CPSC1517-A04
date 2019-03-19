using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Alternatic Namespaces
using NorthwindSystem.BLL;
using NorthwindSystem.Data;
#endregion

namespace WebApp.SamplePages
{
    public partial class SimpleQueries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear old messages
            MessageLabel.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int productid = 0;
            //validate your input
            if (string.IsNullOrEmpty(SearchArg.Text.Trim()))
            {
                //bad message to user
                MessageLabel.Text = "A valid Product ID is required";
            }
            else if (int.TryParse(SearchArg.Text, out productid))
            {
                //good: Standar Lookup pattern and display
                //since we are leaving this project (webapp)
                // and going to another project (BLL)
                // user friendly error handling is required
                try
                {
                    //create an instance of the appropriate
                    // BLL class
                    ProductController sysmgr = new ProductController();
                    //Issue your request to the new appropriate BLL class
                    // Method
                    Product results = sysmgr.Product_get(int.Parse(SearchArg.Text));
                    //test results to see if anything was found
                    //null: product id not found
                    //otherwise: Product instance exists
                    if (results == null)
                    {
                        MessageLabel.Text = "Product data was not found using product ID.";
                    }
                    else
                    {
                        ProductID.Text = results.ProductID.ToString();
                        ProductName.Text = results.ProductName.ToString();
                    }

                }
                catch(Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
            }
            else
            {
                //bad :message to user
                MessageLabel.Text = "Product ID must be a number greater than 0.";
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            SearchArg.Text = "";
            ProductID.Text = "";
            ProductName.Text = "";
        }
    }
}